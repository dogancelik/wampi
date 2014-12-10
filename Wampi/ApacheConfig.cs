using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Wampi
{
    public class ApacheConfig
    {
        public struct Module
        {
            public bool Enabled;
            public string Name;
            public string Path;

            public override string ToString()
            {
                return Name;
            }
        }

        public string FilePath;
        private string fileData;

        public static readonly string[] QuotedVariables = { "ServerRoot", "DocumentRoot" };
        public static readonly string[] UnquotedVariables = { "Listen", "ServerAdmin", "ServerName" };
        private Dictionary<string, string> initVariables = new Dictionary<string, string>();
        public Dictionary<string, string> Variables = new Dictionary<string, string>();
        public List<Module> Modules;

        public ApacheConfig(string file)
        {
            FilePath = file;
            fileData = File.ReadAllText(file);
            ParseEverything();
        }

        private void ParseEverything()
        {
            Modules = GetModuleList();
            Variables.Clear();
            ParseVariable("ServerRoot");
            ParseVariable("Listen");
            ParseVariable("ServerAdmin");
            ParseVariable("ServerName");
            ParseVariable("DocumentRoot");
            initVariables = new Dictionary<string, string>(Variables);
        }

        private void ParseVariable(string name)
        {
            Variables.Add(name, GetParam(name));
        }

        private string GetParam(string name, RegexOptions options = RegexOptions.Multiline)
        {
            var regex = new Regex(@"^" + name + @"\s+(.+)", options);
            var match = regex.Match(fileData);
            var value = match.Groups[1].Value;
            return value.TrimEnd().Trim('"');
        }

        private List<Module> GetModuleList()
        {
            var regex = new Regex(@"(#?LoadModule)\s+([\w_]+)\s+([\w_\\\/\.]+)");
            var list = new List<Module>();
            var matches = regex.Matches(fileData);
            foreach (Match match in matches)
            {
                var module = new Module
                {
                    Enabled = match.Groups[1].Value.StartsWith("#"),
                    Name = match.Groups[2].Value,
                    Path = match.Groups[3].Value
                };
                list.Add(module);
            }
            return list;
        }

        public void AddText(string text, string search)
        {
            if (fileData.Contains(search)) return;
            fileData += text;
        }

        public void Save()
        {
            /* Current implementation doesn't allow me to save Modules
             * because there is no way to know what has changed
             */

            foreach (var variable in QuotedVariables)
            {
                fileData = Regex.Replace(
                    fileData,
                    @"^" + variable + " \"" + initVariables[variable] + "\"",
                    variable + " \"" + Variables[variable] + "\"",
                    RegexOptions.Multiline
                    );

                if (variable == "DocumentRoot")
                {
                    fileData = fileData.Replace(
                        String.Format("<Directory \"{0}\">", initVariables[variable]),
                        String.Format("<Directory \"{0}\">", Variables[variable])
                        );
                }
            }

            foreach (var variable in UnquotedVariables)
            {
                fileData = Regex.Replace(
                    fileData,
                    @"^#?" + variable + " .*" + initVariables[variable] + "$",
                    variable + " " + Variables[variable],
                    RegexOptions.Multiline
                    );
            }

            File.WriteAllText(FilePath, fileData);
            ParseEverything();
        }
    }
}