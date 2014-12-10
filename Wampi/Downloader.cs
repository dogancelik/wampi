using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Net;

namespace Wampi
{
    internal class Downloader
    {
        private WebClient client = new WebClient();

        public event DownloadProgressChangedEventHandler DownloadProgress;

        public event AsyncCompletedEventHandler DownloadFinished;

        public delegate void DownloadBeforeStartDelegate(Uri remotePath, string localPath);

        public event DownloadBeforeStartDelegate DownloadBeforeStart;

        public delegate void DownloadAllFinishedDelegate();

        public event DownloadAllFinishedDelegate DownloadAllFinished;

        public OrderedDictionary Files = new OrderedDictionary();

        public Downloader()
        {
            client.DownloadProgressChanged += delegate(object sender, DownloadProgressChangedEventArgs args)
            {
                if (DownloadProgress != null) DownloadProgress(sender, args);
            };
            client.DownloadFileCompleted += delegate(object sender, AsyncCompletedEventArgs args)
            {
                if (DownloadFinished != null) DownloadFinished(sender, args);
            };
        }

        public void AddFile(Uri remotePath, string localPath)
        {
            Files.Add(remotePath, localPath);
        }

        private bool cancelDownload = false;

        public async void StartDownload()
        {
            cancelDownload = false;
            foreach (DictionaryEntry pair in Files)
            {
                if (cancelDownload) break;

                var remote = (Uri)pair.Key;
                var local = (string)pair.Value;
                DownloadBeforeStart(remote, local);
                try
                {
                    await client.DownloadFileTaskAsync(remote, local);
                }
                catch (WebException)
                {
                    File.Delete(local);
                }
            }
            DownloadAllFinished();
        }

        public void CancelDownload()
        {
            cancelDownload = true;
            client.CancelAsync();
        }
    }
}