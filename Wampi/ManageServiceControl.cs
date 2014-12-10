using System;
using System.Drawing;
using System.Management;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wampi
{
    public partial class ManageServiceControl : UserControl
    {
        public string DefaultServiceName = String.Empty;
        public string CurrentServiceName = String.Empty;
        private readonly string netPath = "net";
        public readonly string TextServiceNotFound = "Service not found: ";

        public ManageServiceControl(string groupName, string defaultServiceName, Action<GroupBox> action = null, ContextMenuStrip contextMenu = null)
        {
            InitializeComponent();

            this.DefaultServiceName = defaultServiceName;
            groupBox.Text = groupName;
            pictureStatus.Image = Properties.Resources.down;

            if (contextMenu != null)
            {
                buttonMore.Click += (sender, args) => contextMenu.Show(buttonMore, new Point(0, buttonMore.Height));
                buttonMore.Visible = true;
            }

            worker.RunWorkerAsync();

            if (action != null) action(groupBox);
        }

        private bool IsServiceUp(string name)
        {
            var state = String.Empty;
            var path = string.Format("Win32_Service.Name='{0}'", name);
            using (var service = new ManagementObject(new ManagementPath(path)))
            {
                try
                {
                    state = service.Properties["State"].Value.ToString().Trim();
                    CurrentServiceName = service.Properties["Name"].Value.ToString();
                    return state == "Running";
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        private bool IsServiceUpByClosestName(string name)
        {
            try
            {
                using (ManagementObject mo = ServiceHelper.FindServiceByClosestName(name))
                {
                    if (mo != null) return IsServiceUp(mo["Name"].ToString());
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsRunning = false;
        public int WatchDelay = 1000;

        private void CheckService()
        {
            if (String.IsNullOrEmpty(textServiceName.Text))
            {
                IsRunning = IsServiceUpByClosestName(DefaultServiceName);
            }
            else
            {
                IsRunning = IsServiceUp(textServiceName.Text);
            }

            if (IsRunning)
            {
                WatchDelay = 1000;
            }
            else
            {
                if (WatchDelay < 5000)
                {
                    WatchDelay += 500;
                }
            }

            Invoke((MethodInvoker)(() => pictureStatus.Image = IsRunning ? Properties.Resources.up : Properties.Resources.down));
        }

        private async Task ToggleService(bool toggle)
        {
            ProcessHelper.ReadFromProcess(netPath, (toggle ? "start" : "stop") + " \"" + CurrentServiceName + "\"", false);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => ToggleService(true));
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => ToggleService(false));
        }

        private void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (!worker.CancellationPending)
            {
                try
                {
                    CheckService();
                }
                catch (Exception)
                {
                }
                Thread.Sleep(WatchDelay);
            }
            e.Cancel = true;
        }
    }
}