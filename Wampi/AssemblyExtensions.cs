using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Wampi
{
    public static class AssemblyExtensions
    {
        public static string GetTitle(this Assembly assembly)
        {
            var attribute = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false)
                .Select(a => a as AssemblyTitleAttribute).FirstOrDefault();

            return attribute == null ? String.Empty : attribute.Title;
        }

        public static string GetDescription(this Assembly assembly)
        {
            var attribute = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false)
                .Select(a => a as AssemblyDescriptionAttribute).FirstOrDefault();

            return attribute == null ? String.Empty : attribute.Description;
        }

        public static string GetCopyright(this Assembly assembly)
        {
            var attribute = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false)
                .Select(a => a as AssemblyCopyrightAttribute).FirstOrDefault();

            return attribute == null ? String.Empty : attribute.Copyright;
        }

        public static string GetDescCopy(this Assembly assembly)
        {
            return GetDescription(assembly) + "\n" + GetCopyright(assembly);
        }

        public static string GetVersion(this Assembly assembly, int count = 3)
        {
            var version = assembly.GetName().Version;
            return count > -1 ? version.ToString(count) : version.ToString();
        }

        public static string GetFileVersion(this Assembly assembly)
        {
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            return version;
        }
    }
}