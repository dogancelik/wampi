using System;
using System.IO;
using System.Windows.Forms;

namespace Wampi
{
    public partial class SetupFormApache : SetupFormBase
    {
        private ApacheConfig config;
        private string pathRoot;
        private string pathParent;
        private string pathBin;
        private string pathHttpd;

        private const string textRequired = "(required)";
        private const string textOptional = "(optional)";

        public SetupFormApache()
        {
            InitializeComponent();

            SendMessage(textServerRoot.Handle, EM_SETCUEBANNER, 0, textRequired);
            SendMessage(textDocumentRoot.Handle, EM_SETCUEBANNER, 0, textRequired);
            SendMessage(textListen.Handle, EM_SETCUEBANNER, 0, textRequired);
            SendMessage(textService.Handle, EM_SETCUEBANNER, 0, "Name " + textOptional);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var info = new FileInfo(fileDialog.FileName);
                pathRoot = info.Directory.Parent.FullName;
                pathParent = info.Directory.Parent.Parent.FullName;
                pathBin = Path.Combine(pathRoot, "bin");
                pathHttpd = Path.Combine(pathBin, "httpd.exe");

                config = new ApacheConfig(fileDialog.FileName);

                buttonSave.Enabled = buttonAutoConfig.Enabled = buttonActivatePhp.Enabled = panelService.Enabled = groupDirectives.Enabled = true;

                textServerRoot.Text = config.Variables["ServerRoot"];
                textDocumentRoot.Text = config.Variables["DocumentRoot"];
                textListen.Text = config.Variables["Listen"];
                textServerAdmin.Text = config.Variables["ServerAdmin"];
                textServerName.Text = config.Variables["ServerName"];
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            config.Modules.Clear();

            config.Variables["ServerRoot"] = textServerRoot.Text;
            if (!Directory.Exists(textDocumentRoot.Text)) Directory.CreateDirectory(textDocumentRoot.Text);
            config.Variables["DocumentRoot"] = textDocumentRoot.Text;
            config.Variables["Listen"] = textListen.Text;
            config.Variables["ServerAdmin"] = textServerAdmin.Text;
            config.Variables["ServerName"] = textServerName.Text;

            config.Save();
            MessageBox.Show("Saved");
        }

        private string GetArgumentForServiceName()
        {
            return (textService.Text != "" ? (" -n \"" + textService.Text + "\"") : "");
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            var output = ProcessHelper.ReadFromProcess(pathHttpd, "-k install" + GetArgumentForServiceName(), true);
            MessageBox.Show(output.Trim());
        }

        private void buttonUninstall_Click(object sender, EventArgs e)
        {
            var output = ProcessHelper.ReadFromProcess(pathHttpd, "-k uninstall" + GetArgumentForServiceName(), true);
            MessageBox.Show(output.Trim());
        }

        private string BackslashToSlash(string path)
        {
            return path.Replace('\\', '/');
        }

        private void buttonAutoConfig_Click(object sender, EventArgs e)
        {
            textServerRoot.Text = BackslashToSlash(pathRoot);
            textDocumentRoot.Text = BackslashToSlash(Path.Combine(new DirectoryInfo(pathBin).Parent.Parent.FullName, "www"));
        }

        private void buttonActivatePhp_Click(object sender, EventArgs e)
        {
            const string dll24 = "php5apache2_4.dll";
            const string dll22 = "php5apache2_2.dll";
            const string phpDirectives = "LoadModule php5_module {0}\nAddHandler application/x-httpd-php .php\nPHPIniDir \"{1}\"";

            string path = String.Empty;
            string dll = String.Empty;

            var finder = RootFolderFinder.FindAll(pathParent, dll24, ".");
            if (finder.Length > 0)
            {
                path = finder[0];
                dll = dll24;
            }

            var finder2 = RootFolderFinder.FindAll(pathParent, dll22, ".");
            if (finder2.Length > 0)
            {
                path = finder2[0];
                dll = dll22;
            }

            if (String.IsNullOrEmpty(path)) return;

            var text = String.Format(phpDirectives, BackslashToSlash(Path.Combine(path, dll)),
                BackslashToSlash(path).TrimEnd('/'));
            config.AddText(text, phpDirectives.Substring(0, 22));
        }
    }
}