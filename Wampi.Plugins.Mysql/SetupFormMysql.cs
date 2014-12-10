using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Wampi
{
    public partial class SetupFormMysql : SetupFormBase
    {
        private string configPath;
        private string mysqldPath;

        public SetupFormMysql()
        {
            InitializeComponent();
            const string textOptional = "(optional)";
            SendMessage(textService.Handle, EM_SETCUEBANNER, 0, textOptional);
            SendMessage(textRoot.Handle, EM_SETCUEBANNER, 0, textOptional);
            ToggleControls(groupService.Controls, false);
        }

        private void buttonLocate_Click(object sender, EventArgs e)
        {
            if (mysqldDialog.ShowDialog() == DialogResult.OK && File.Exists(mysqldDialog.FileName))
            {
                mysqldPath = mysqldDialog.FileName;
                ToggleControls(groupService.Controls, true);
            }
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            string installArg = "--install \"" + (textService.Text == "" ? "MySQL" : textService.Text) + "\"";

            string sqlPath = String.Empty;
            if (textRoot.Text != "")
            {
                var sql = "UPDATE mysql.user SET Password=PASSWORD('" + textRoot.Text + "') WHERE User='root'; FLUSH PRIVILEGES;";
                sqlPath = Path.GetTempFileName();
                File.WriteAllText(sqlPath, sql);
            }
            string sqlArg = !String.IsNullOrEmpty(sqlPath) ? " --init-file=\"" + sqlPath + "\"" : "";

            var args = installArg + sqlArg;
            Debug.WriteLine(args);
            var res = ProcessHelper.ReadFromProcess(mysqldPath, args, false);
            MessageBox.Show(res);
        }

        private void buttonUninstall_Click(object sender, EventArgs e)
        {
            var args = "--remove" + (textService.Text != "" ? " \"" + textService.Text + "\"" : "");
            var res = ProcessHelper.ReadFromProcess(mysqldPath, args, false);
            MessageBox.Show(res);
        }
    }
}