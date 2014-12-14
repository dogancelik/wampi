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

        public delegate void QueueCancelledDelegate();

        public event QueueCancelledDelegate QueueCancelled;

        public Dictionary<string, string> Files;

        public bool IsBusy { get { return worker.IsBusy; } }

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
            using (ZipFile zip = ZipFile.Read(file))
            {
                zip.ExtractProgress += Progress;
                zip.ExtractProgress += delegate(object sender, ExtractProgressEventArgs args)
                {
                    if (worker.CancellationPending)
                    {
                        args.Cancel = true;
                    }
                };
                zip.ExtractAll(extractTo);
            }
        }

        public void AddToQueue(string file, string extractTo)
        {
            Files.Add(file, extractTo);
            queue.Enqueue(new Task(() => UnzipFile(file, extractTo)));
        }

        public void StartQueue()
        {
            worker.RunWorkerAsync();
        }

        public void CancelQueue()
        {
            worker.CancelAsync();
        }

        private bool finished = false;

        // Worker
        private void WorkerDoWork(object sender, DoWorkEventArgs e)
        {
            finished = false;
            if (queue.Count > 0)
            {
                var task = queue.Dequeue();
                task.Start();
                task.Wait();
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
                finished = true;
                QueueFinished(Files);
                Files.Clear();
                queue.Clear();
            }
        }

        private void WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled || finished)
            {
                queue.Clear(); // Otherwise it will move to the next item when after clicking Install again
                Files.Clear(); // To avoid "key already exists" exceptions
                if (!finished) // Quick fix -- If we don't call e.Cancel = true in DoWork, worker will keep running
                {
                    QueueCancelled();
                }
            }
            else
            {
                worker.RunWorkerAsync();
            }
        }
    }
}