using System.Text.RegularExpressions;

namespace Wampi.Plugins.Phpmyadmin
{
    public class Plugin : IPlugin
    {
        public MainForm MainForm { get; set; }

        public void Load()
        {
            MainForm.AddUnpackRule(
                new Regex(@"phpMyAdmin-[0-9\.]+-[\w\-]+", MainForm.UnpackRegexOptions),
                new MainForm.UnpackMatch { Name = "phpmyadmin", DisplayName = "PhpMyAdmin", FileToFind = "phpmyadmin.css.php", TargetRoot = "." }
                );
            MainForm.AddDownloadRow("phpmyadmin", "PhpMyAdmin", Properties.Resources.phpmyadmin);
        }

        public void Unload()
        {
        }
    }
}