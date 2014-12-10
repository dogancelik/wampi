using System.Text.RegularExpressions;

namespace Wampi.Plugins.Mysql
{
    public class Plugin : IPlugin
    {
        public MainForm MainForm { get; set; }

        private ManageServiceControl control;

        public void Load()
        {
            control = MainForm.AddManageRow("mysql", "MySQL Service", "MySQL");

            MainForm.AddUnpackRule(
                new Regex(@"mysql-[0-9\.]+-winx?[0-9]+", MainForm.UnpackRegexOptions),
                new MainForm.UnpackMatch { Name = "mysql", DisplayName = "MySQL", FileToFind = "bin\\mysql.exe", TargetRoot = ".." }
                );

            MainForm.AddDownloadRow("mysql", "MySQL", Properties.Resources.mysql);

            MainForm.AddSetupRow("mysql", "MySQL Setup", typeof(SetupFormMysql), Properties.Resources.mysql);
        }

        public void Unload()
        {
            if (control != null) control.Dispose();
        }
    }
}