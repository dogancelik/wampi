using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Wampi
{
    internal class PluginLoader
    {
        private List<Assembly> assemblies = new List<Assembly>();

        public void LoadDirectory(string path, string pattern = "*.dll")
        {
            if (!Directory.Exists(path)) return;

            foreach (string filePath in Directory.GetFiles(path, pattern))
            {
                Assembly assembly = Assembly.LoadFrom(filePath);
                assemblies.Add(assembly);
            }
        }

        public IPlugin[] GetPlugins()
        {
            var plugins = new List<object>();

            foreach (Assembly assembly in assemblies)
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (typeof(IPlugin).IsAssignableFrom(type))
                        plugins.Add(Activator.CreateInstance(type));
                }
            }

            return plugins.Cast<IPlugin>().ToArray();
        }
    }
}