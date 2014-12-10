using System.Text.RegularExpressions;

namespace Wampi.Plugins.Php
{
    public class Plugin : IPlugin
    {
        public MainForm MainForm { get; set; }

        public void Load()
        {
            MainForm.AddUnpackRule(
                new Regex(@"php-[0-9\.]+-Win32-VC[0-9]+-x[0-9]+", MainForm.UnpackRegexOptions),
                new MainForm.UnpackMatch { Name = "php", DisplayName = "PHP", FileToFind = "php.exe", TargetRoot = "." }
                );
            MainForm.AddDownloadRow("php", "PHP", Properties.Resources.php);
        }

        public void Unload()
        {
        }
    }
}