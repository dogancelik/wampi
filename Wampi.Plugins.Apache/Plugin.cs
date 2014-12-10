using System;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Wampi.Plugins.Apache
{
    public class Plugin : IPlugin
    {
        public MainForm MainForm { get; set; }

        private ManageServiceControl control;

        public void Load()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Test config.", null, TestConfig);
            control = MainForm.AddManageRow("apache", "Apache Service", "Apache2", null, menu);

            MainForm.AddUnpackRule(
                new Regex(@"httpd-[0-9\.]+-win[0-9]+-VC[0-9]+", MainForm.UnpackRegexOptions),
                new MainForm.UnpackMatch { Name = "apache", DisplayName = "Apache", FileToFind = "bin\\httpd.exe", TargetRoot = ".." }
                );

            MainForm.AddDownloadRow("apache", "Apache", Properties.Resources.apache);

            MainForm.AddSetupRow("apache", "Apache Setup", typeof(SetupFormApache), Properties.Resources.apache);
        }

        private void TestConfig(object sender, EventArgs eventArgs)
        {
            ManagementObject mo = ServiceHelper.FindServiceByClosestName(control.CurrentServiceName);
            if (mo != null)
            {
                string path = mo.GetPropertyValue("PathName").ToString().Split('"')[1];
                MessageBox.Show(ProcessHelper.ReadFromProcess(path, "-t", true));
            }
            else
            {
                MessageBox.Show(control.TextServiceNotFound + control.CurrentServiceName);
            }
        }

        public void Unload()
        {
            if (control != null) control.Dispose();
        }
    }
}