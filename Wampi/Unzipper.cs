using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Wampi
{
    internal struct UnzipFileObject
    {
        public string FileName;
        public string ExtractTo;
    }

    internal class Unzipper
    {
        private Queue<Task> queue;
        public EventHandler<ExtractProgressEventArgs> Progress;
        private BackgroundWorker worker;

        public delegate void QueueFinishedDelegate(Dictionary<string, string> files);

        public event QueueFinishedDelegate QueueFinished;

        public Dictionary<string, string> Files;

        public bool IsBusy { get { return worker.IsBusy; } }

        private bool cancelFromClass = false;

        public Unzipper()
        {
            queue = new Queue<Task>();

            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += WorkerDoWork;
            worker.RunWorkerCompleted += WorkerCompleted;

            Files = new Dictionary<string, string>();
        }

        private void UnzipFile(string file, string extractTo)
        {
            Files.Add(file, extractTo);
            ZipFile zip = ZipFile.Read(file);
            zip.ExtractProgress += Progress;
            zip.ExtractAll(extractTo);
        }

        public void AddToQueue(string file, string extractTo)
        {
            queue.Enqueue(new Task(() => UnzipFile(file, extractTo)));
        }

        public void StartQueue()
        {
            worker.RunWorkerAsync();
        }

        public void CancelQueue()
        {
            cancelFromClass = true;
            worker.CancelAsync();
        }

        // Worker
        private void WorkerDoWork(object sender, DoWorkEventArgs e)
        {
            if (queue.Count > 0)
            {
                var task = queue.Dequeue();
                task.Start();
                task.Wait();
            }
            else
            {
                e.Cancel = true;
                QueueFinished(Files);
                Files.Clear();
            }
        }

        private void WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                worker.RunWorkerAsync();
            }
        }
    }
}