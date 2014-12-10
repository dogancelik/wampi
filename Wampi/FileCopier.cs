using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Wampi
{
    internal class FileCopier
    {
        // Windows API
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern unsafe bool CopyFileEx(string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, Boolean* pbCancel, CopyFileFlags dwCopyFlags);

        [Flags]
        public enum CopyFileFlags : uint
        {
            COPY_FILE_FAIL_IF_EXISTS = 0x00000001,
            COPY_FILE_RESTARTABLE = 0x00000002,
            COPY_FILE_OPEN_SOURCE_FOR_WRITE = 0x00000004,
            COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 0x00000008
        }

        public enum CopyProgressResult : uint
        {
            PROGRESS_CONTINUE = 0,
            PROGRESS_CANCEL = 1,
            PROGRESS_STOP = 2,
            PROGRESS_QUIET = 3
        }

        public enum CopyProgressCallbackReason : uint
        {
            CALLBACK_CHUNK_FINISHED = 0x00000000,
            CALLBACK_STREAM_SWITCH = 0x00000001
        }

        public delegate CopyProgressResult CopyProgressRoutine(long TotalFileSize, long TotalBytesTransferred, long StreamSize, long StreamBytesTransferred, uint dwStreamNumber, CopyProgressCallbackReason dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

        public FileCopier()
        {
            InternalFileCopyProgress += CopyProgressRoutineInternal;
        }

        private int copiedFiles;
        private int totalFiles;
        private string sourceFile;
        private string destinationFile;

        private CopyProgressResult CopyProgressRoutineInternal(long TotalFileSize, long TotalBytesTransferred,
            long StreamSize, long StreamBytesTransferred, uint dwStreamNumber,
            CopyProgressCallbackReason dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData)
        {
            if (FileCopyProgress != null)
                FileCopyProgress(new FileCopyProgressEventArgs
                {
                    TransferredBytes = TotalBytesTransferred,
                    TotalBytes = TotalFileSize,
                    SourceFile = sourceFile,
                    DestinationFile = destinationFile,
                    ProgressPercentage = (int)((double)TotalBytesTransferred / TotalFileSize * 100)
                });

            if (TotalFileSize == TotalBytesTransferred)
            {
                if (FileCopyCompleted != null)
                    FileCopyCompleted(new FileCopyCompletedEventArgs
                    {
                        CopiedFiles = copiedFiles,
                        TotalFiles = totalFiles,
                        SourceFile = sourceFile,
                        DestinationFile = destinationFile
                    });
            }

            if (cancelCopyOperation)
            {
                return CopyProgressResult.PROGRESS_CANCEL;
            }
            else
            {
                return CopyProgressResult.PROGRESS_CONTINUE;
            }
        }

        private event CopyProgressRoutine InternalFileCopyProgress;

        public delegate void OnFileCopyProgressDelegate(FileCopyProgressEventArgs args);

        public event OnFileCopyProgressDelegate FileCopyProgress; // This will keep firing when the current file is being copied

        public delegate void OnCopyProgressDelegate(FileCopyCompletedEventArgs args);

        public event OnCopyProgressDelegate AllCopyProgress; // This will fire before a file starts copying process

        public delegate void OnFileCopyCompletedDelegate(FileCopyCompletedEventArgs args);

        public event OnFileCopyCompletedDelegate FileCopyCompleted; // This will fire when a file copy completes

        public delegate void OnAllCopyCompletedDelegate(AllCopyCompletedEventArgs args);

        public event OnAllCopyCompletedDelegate AllCopyCompleted; // This will fire when whole copying progress completes

        public Dictionary<string, string> Files = new Dictionary<string, string>();

        public class FileCopyProgressEventArgs : EventArgs
        {
            public long TransferredBytes;
            public long TotalBytes;
            public int ProgressPercentage;
            public string SourceFile;
            public string DestinationFile;
        }

        public class FileCopyCompletedEventArgs : EventArgs // Also used for AllCopyProgress
        {
            public int TotalFiles;
            public int CopiedFiles;
            public int ProgressPercentage;
            public string SourceFile;
            public string DestinationFile;
        }

        public class AllCopyCompletedEventArgs : EventArgs
        {
            public int TotalFiles;
            public int CopiedFiles;
        }

        public void AddDirectory(string source, string destination, string searchPattern, SearchOption searchOption)
        {
            foreach (var file in Directory.GetFiles(source, searchPattern, searchOption))
            {
                var info = new FileInfo(file);
                Files.Add(file, info.FullName.Replace(source, destination));
            }
        }

        public void AddFile(string source, string destination)
        {
            // If destination is a directory we will replace source's directory with destination
            try
            {
                var attrs = File.GetAttributes(destination);
                if ((attrs & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    var info = new FileInfo(source);
                    Files.Add(source, info.FullName.Replace(info.DirectoryName, destination));
                }
                else
                {
                    Files.Add(source, destination);
                }
            }
            catch (FileNotFoundException)
            {
                var info = new FileInfo(source);
                Files.Add(source, info.FullName.Replace(info.DirectoryName, destination));
            }
        }

        public void StartCopy()
        {
            copiedFiles = 0;
            totalFiles = Files.Count;
            bool returnValue = false;

            foreach (var pair in Files)
            {
                var newInfo = new FileInfo(pair.Value);
                if (!Directory.Exists(newInfo.DirectoryName))
                {
                    Directory.CreateDirectory(newInfo.DirectoryName);
                }

                if (cancelCopyOperation)
                {
                    break;
                }

                sourceFile = pair.Key;
                destinationFile = pair.Value;

                returnValue = CopyFile(pair.Key, pair.Value); // TODO: Track return values of files
                copiedFiles++;

                if (AllCopyProgress != null)
                    AllCopyProgress(new FileCopyCompletedEventArgs
                    {
                        CopiedFiles = copiedFiles,
                        TotalFiles = totalFiles,
                        SourceFile = pair.Key,
                        DestinationFile = pair.Value,
                        ProgressPercentage = (int)((double)copiedFiles / totalFiles * 100)
                    });
            }

            if (AllCopyCompleted != null)
                AllCopyCompleted(new AllCopyCompletedEventArgs { CopiedFiles = copiedFiles, TotalFiles = totalFiles });
        }

        private bool cancelCopyOperation = false;

        public void CancelCopy()
        {
            cancelCopyOperation = true;
        }

        public CopyFileFlags CopyMethod = 0;

        private bool CopyFile(string source, string destination)
        {
            bool returnValue;
            unsafe
            {
                fixed (Boolean* cancelPointer = &cancelCopyOperation)
                {
                    returnValue = CopyFileEx(source, destination, InternalFileCopyProgress, IntPtr.Zero, cancelPointer, CopyMethod);
                }
            }
            return returnValue;
        }
    }
}