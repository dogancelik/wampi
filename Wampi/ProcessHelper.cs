using System;
using System.Diagnostics;

namespace Wampi
{
    public static class ProcessHelper
    {
        public static string ReadFromProcess(string path, string args, bool readError)
        {
            var process = new Process
            {
                StartInfo =
                {
                    FileName = path,
                    Arguments = args,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                }
            };
            process.Start();

            string output = String.Empty;
            if (readError)
            {
                output = process.StandardError.ReadToEnd();
            }
            else
            {
                output = process.StandardOutput.ReadToEnd();
            }

            process.WaitForExit();
            return output;
        }

        public static bool IsProcessRunning(string processName)
        {
            var processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }
    }
}