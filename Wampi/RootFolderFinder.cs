using System.Collections.Generic;
using System.IO;

namespace Wampi
{
    public class RootFolderFinder
    {
        private static string ConvertDirectorySeperator(string path)
        {
            return path.Replace('/', Path.DirectorySeparatorChar);
        }

        public static string[] FindAll(string startFolder, string fileToFind, string targetRoot)
        {
            var list = new List<string>();
            fileToFind = ConvertDirectorySeperator(fileToFind);
            foreach (var file in Directory.GetFiles(startFolder, "*.*", SearchOption.AllDirectories))
            {
                if (file.Contains(fileToFind))
                {
                    var newRoot = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(file), targetRoot)).FullName;
                    list.Add(newRoot);
                }
            }
            return list.ToArray();
        }
    }
}