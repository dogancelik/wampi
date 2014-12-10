using System.Text.RegularExpressions;

namespace Wampi.Plugins.Mariadb
{
    public class Plugin : IPlugin
    {
        public MainForm MainForm { get; set; }

        private ManageServiceControl control;

        public void Load()
        {
            control = MainForm.AddManageRow("mariadb", "MariaDB Service", "MySQL");

            MainForm.AddUnpackRule(
                new Regex(@"mariadb-[0-9\.]+-winx?[0-9]+", MainForm.UnpackRegexOptions),
                new MainForm.UnpackMatch { Name = "mariadb", DisplayName = "MariaDB", FileToFind = "bin\\mysql.exe", TargetRoot = ".." }
                );

            MainForm.AddDownloadRow("mariadb", "MariaDB", Properties.Resources.mariadb);

            SetupFormMysql form = new SetupFormMysql();
            form.Text = "Setup: MariaDB";
            MainForm.AddSetupRow("mariadb", "MariaDB Setup", form, Properties.Resources.mariadb);
        }

        public void Unload()
        {
            if (control != null) control.Dispose();
        }
    }
}