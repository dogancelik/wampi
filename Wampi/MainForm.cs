using Ionic.Zip;
using Microsoft.VisualBasic;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Wampi
{
    public partial class MainForm : Form
    {
        private SourceLoader sourceLoader;
        private Downloader downloader;
        private Unzipper unzipper;
        private FileCopier copier;
        private ImageList imageList;

        public const RegexOptions UnpackRegexOptions = RegexOptions.IgnoreCase;

        public struct UnpackMatch
        {
            public string Name;
            public string DisplayName;
            public string StartFolder; // Assigned later
            public string FileToFind;
            public string TargetRoot;
            public Bitmap Icon;
        }

        private Dictionary<Regex, UnpackMatch> unpackRules = new Dictionary<Regex, UnpackMatch>();

        private const string PathDownload = "downloads";
        private const string PathTemporary = "temporary";
        private const string PathPlugins = "plugins";

        private const string UrlOfficialSources = "http://dogancelik.github.io/wampi/sources.xml";
        private const string UrlWhatToDownload = "https://github.com/dogancelik/wampi/wiki/Help#in-download-tab-what-should-i-download";

        private const string TextButtonDownload = "Download";
        private const string TextButtonInstall = "Install";
        private const string TextButtonCancel = "Cancel";
        private const string TextDownloading = "Downloading: {0}";
        private const string TextLoading = "Loading...";
        private const string TextEnterUrl = "Please enter a URL";
        private const string TextOverwriteQuestion = "There is already a file named: {0}\nDo you want to overwrite this?";
        private const string TextUnpackHelp = "Clicking \"Install\" will overwrite any existing files in the install directory so do a back-up first.";
        private const string TextUnpack = "Unpacking: {0}";
        private const string TextUnpackCancelled = "Unpack cancelled";
        private const string TextCouldNotLoad = "Couldn't load URL: {0}";
        private const string TextDownloadCancelled = "Download is cancelled";
        private const string TextDownloadFinished = "Download is finished";
        private const string TextInstallPathRequired = "Please choose an install directory.";
        private const string TextErrorDeleteTemporary = "An error occured when deleting the temporary folder.";
        private const string TextMoveProcessProgress = "Moving: {0}";
        private const string TextMoveProcessCompleted = "Move process completed";
        private const string TextMoveProcessCancelled = "Move process cancelled";
        private const string TextQuestionOpenLink = "Do you want to open: {0}";

        public MainForm()
        {
            InitializeComponent();

            sourceLoader = new SourceLoader();
            imageList = new ImageList();

            downloader = new Downloader();
            downloader.DownloadBeforeStart += DownloaderOnDownloadBeforeStart;
            downloader.DownloadProgress += DownloaderOnDownloadProgress;
            downloader.DownloadFinished += DownloaderOnDownloadFinished;
            downloader.DownloadAllFinished += DownloaderOnDownloadAllFinished;

            unzipper = new Unzipper();
            unzipper.Progress += UnzipperProgress;
            unzipper.QueueFinished += UnzipperFinished;
            unzipper.QueueCancelled += UnzipperCancelled;

            copier = new FileCopier();
            copier.AllCopyProgress += CopierOnAllCopyProgress;
            copier.AllCopyCompleted += CopierOnAllCopyCompleted;
            copier.CopyCancelled += CopierOnCopyCancelled;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPlugins();
            listDownloads.SmallImageList = imageList;
            buttonListDownloads_Click(sender, e);
            LoadConfiguration(Properties.Settings.Default.checkForUpdates);
            labelVersion.Text += Application.ProductVersion;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnloadPlugins();
        }

        private void ToggleButton(Button button, bool enable, EventHandler newEvent, EventHandler oldEvent, string newString, string oldString)
        {
            button.Click -= newEvent; // What a stupid fix for double button click triggering
            button.Click -= oldEvent;

            if (enable)
            {
                button.Text = newString;
                button.Click += newEvent;
                button.Click -= oldEvent;
            }
            else
            {
                button.Text = oldString;
                button.Click -= newEvent;
                button.Click += oldEvent;
            }
        }

        private void ToggleButton(Button button, bool enable, string text)
        {
            button.Enabled = enable;
            button.Text = text;
        }

        #region Download

        private void DownloaderOnDownloadAllFinished()
        {
            ToggleDownloadButton(false);
        }

        private void DownloaderOnDownloadFinished(object sender, AsyncCompletedEventArgs args)
        {
            labelDownload.Text = args.Cancelled ? TextDownloadCancelled : TextDownloadFinished;
            progressDownload.Value = 0;
        }

        private void DownloaderOnDownloadProgress(object sender, DownloadProgressChangedEventArgs args)
        {
            progressDownload.Value = args.ProgressPercentage;
        }

        private void DownloaderOnDownloadBeforeStart(Uri remotePath, string localPath)
        {
            labelDownload.Text = String.Format(TextDownloading, Path.GetFileName(remotePath.LocalPath));
        }

        private const string nameComboDownload = "comboDownload_";

        private Uri GetSourceUrl(Object source)
        {
            return new Uri((source as Source).Url);
        }

        private ComboBox[] GetDownloadCombos()
        {
            var list = new List<ComboBox>();
            foreach (Control control in tableDownloadPrograms.Controls)
            {
                if (control is ComboBox)
                    list.Add((ComboBox)control);
            }
            return list.ToArray();
        }

        private void AddSources(string xml)
        {
            if (String.IsNullOrEmpty(xml)) return;

            try
            {
                sourceLoader.Parse(xml);
            }
            catch (Exception)
            {
                MessageBox.Show("Error when parsing", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var combo in GetDownloadCombos())
            {
                if (!checkAppendSource.Checked) combo.Items.Clear();
                combo.BeginUpdate();
                string name = combo.Name.Substring(nameComboDownload.Length);
                foreach (var src in sourceLoader.Sources[name]) combo.Items.Add(src);
                combo.EndUpdate();
            }
        }

        private async void ButtonLoadUrlHelper(object sender, string url)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;
            button.Text = TextLoading;
            button.Enabled = false;

            string xml = String.Empty;
            try
            {
                xml = await new HttpClient().GetStringAsync(url);
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format(TextCouldNotLoad, url));
            }
            AddSources(xml);

            button.Text = buttonText;
            button.Enabled = true;
        }

        private void buttonLoadSourceOfficial_Click(object sender, EventArgs e)
        {
            ButtonLoadUrlHelper(sender, UrlOfficialSources);
        }

        private void buttonLoadSourceLocal_Click(object sender, EventArgs e)
        {
            if (sourcesDialog.ShowDialog() == DialogResult.OK) AddSources(File.ReadAllText(sourcesDialog.FileName));
        }

        private void buttonLoadSourceUrl_Click(object sender, EventArgs e)
        {
            var str = Interaction.InputBox(TextEnterUrl);
            if (str != String.Empty) ButtonLoadUrlHelper(sender, str);
        }

        private void AddDownload(Downloader downloader, ComboBox combo, Regex regex = null)
        {
            if (combo.SelectedIndex == -1) return;
            var url = GetSourceUrl(combo.SelectedItem);

            string filenameOnly = String.Empty;
            if (regex != null)
            {
                filenameOnly = regex.Match(url.ToString()).Groups[1].Value;
            }
            else
            {
                filenameOnly = Path.GetFileName(url.LocalPath);
            }

            var localPath = Path.Combine(PathDownload, filenameOnly);
            if (File.Exists(localPath))
            {
                if (MessageBox.Show(String.Format(TextOverwriteQuestion, Path.GetFileName(url.LocalPath)), Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    downloader.AddFile(url, localPath);
            }
            else
            {
                downloader.AddFile(url, localPath);
            }
        }

        private void ToggleDownloadButton(bool turnToCancelButton)
        {
            ToggleButton(buttonDownload, turnToCancelButton, buttonDownload_Click_Cancel, buttonDownload_Click, TextButtonCancel, TextButtonDownload);
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(PathDownload)) Directory.CreateDirectory(PathDownload);
            ToggleDownloadButton(true);

            downloader.Files.Clear();
            foreach (ComboBox combo in GetDownloadCombos())
            {
                AddDownload(downloader, combo);
            }
            downloader.StartDownload();
        }

        private void buttonDownload_Click_Cancel(object sender, EventArgs e)
        {
            downloader.CancelDownload();
            ToggleDownloadButton(false);
        }

        private void linkDownloadHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(UrlWhatToDownload);
        }

        #endregion Download

        #region Install

        private void CopierOnAllCopyCompleted(FileCopier.AllCopyCompletedEventArgs args)
        {
            Action action = delegate
            {
                Debug.WriteLine("Copy Completed");
                labelInstallProgress.Text = TextMoveProcessCompleted;
                progressInstall.Value = 0;
                ToggleButton(buttonInstall, false, buttonInstall_Click_Cancel, buttonInstall_Click, TextButtonCancel, TextButtonInstall);
            };

            Invoke((MethodInvoker)(() => action()));
        }

        private void CopierOnAllCopyProgress(FileCopier.FileCopyCompletedEventArgs args)
        {
            Action action = delegate { progressInstall.Value = args.ProgressPercentage; };

            if (progressInstall.InvokeRequired)
                Invoke((MethodInvoker)(() => action()));
            else
                action();
        }

        private void CopierOnCopyCancelled()
        {
            Invoke((MethodInvoker)delegate
            {
                Debug.WriteLine("Copy Cancelled");
                labelInstallProgress.Text = TextMoveProcessCancelled;
                progressInstall.Value = 0;
            });
        }

        private void UnzipperProgress(object sender, ExtractProgressEventArgs args)
        {
            // Tried to cancel Worker with WorkerSupportsCancellation, and Task with CancellationTokenSource. Both didn't work
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    labelInstallProgress.Text = String.Format(TextUnpack, args.ArchiveName);
                    if (args.EntriesExtracted > 0 || args.EntriesTotal > 0)
                    {
                        var percentage = (int)((double)args.EntriesExtracted / args.EntriesTotal * 100.0);
                        progressInstall.Value = percentage;
                    }
                });
            }
            catch (Exception)
            {
            }
        }

        private void UnzipperCancelled()
        {
            labelInstallProgress.Text = TextUnpackCancelled;
            progressInstall.Value = 0;
        }

        private void UnzipperFinished(Dictionary<string, string> files)
        {
            foreach (var pair in files)
            {
                bool ret = true;
                foreach (var rule in unpackRules)
                {
                    var match = rule.Key.Match(pair.Key);
                    if (match.Success)
                    {
                        var unpackMatch = rule.Value;
                        unpackMatch.StartFolder = pair.Value;

                        Invoke((MethodInvoker)delegate { labelInstallProgress.Text = String.Format(TextMoveProcessProgress, unpackMatch.DisplayName); });
                        var movePath = RootFolderFinder.FindAll(unpackMatch.StartFolder, unpackMatch.FileToFind, unpackMatch.TargetRoot)[0];
                        copier.Files.Clear();
                        copier.AddDirectory(movePath, Path.Combine(textInstallDirectory.Text, unpackMatch.Name), "*.*", SearchOption.AllDirectories);
                        ret = copier.StartCopy(); // TODO: To fix -- triggers again after cancelling -- because UnzipperFinished loop continues
                    }
                }
                if (!ret) break; // If cancel then break out of loop
            }
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            if (listDownloads.CheckedItems.Count == 0) return;
            if (textInstallDirectory.Text.Length == 0)
            {
                MessageBox.Show(TextInstallPathRequired, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (Directory.Exists(PathTemporary)) Directory.Delete(PathTemporary, true);
            }
            catch (IOException)
            {
                MessageBox.Show(TextErrorDeleteTemporary);
            }

            Debug.WriteLine("Düğmeye bastık");
            foreach (ListViewItem item in listDownloads.CheckedItems)
            {
                string file = item.Text;
                string extractTo = String.Empty;
                foreach (var pair in unpackRules)
                {
                    Match match = pair.Key.Match(file);
                    if (match.Success) extractTo = pair.Value.Name;
                }
                extractTo = Path.Combine(PathTemporary, extractTo);
                Debug.WriteLine("Q'ya ekleme yapıyoruz");
                unzipper.AddToQueue(Path.Combine(PathDownload, file), extractTo);
            }

            Debug.WriteLine("Q'yu başlattık");
            unzipper.StartQueue();
            ToggleButton(buttonInstall, true, buttonInstall_Click_Cancel, buttonInstall_Click, TextButtonCancel, TextButtonInstall);
        }

        private void buttonInstall_Click_Cancel(object sender, EventArgs e)
        {
            unzipper.CancelQueue();
            copier.CancelCopy();
            ToggleButton(buttonInstall, false, buttonInstall_Click_Cancel, buttonInstall_Click, TextButtonCancel, TextButtonInstall);
        }

        private void buttonInstallFolderDialog_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog { IsFolderPicker = true };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textInstallDirectory.Text = dialog.FileName;
            }
        }

        private void linkInstallHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TextUnpackHelp, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonListDownloads_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(PathDownload))
            {
                listDownloads.BeginUpdate();
                listDownloads.Items.Clear();
                var files = Directory.GetFiles(PathDownload, "*.zip");
                foreach (var file in files)
                {
                    var realFile = Path.GetFileName(file);
                    var item = new ListViewItem();
                    item.Text = realFile;
                    foreach (var pair in unpackRules)
                    {
                        if (pair.Key.Match(realFile).Success)
                        {
                            item.ImageKey = pair.Value.Name;
                        }
                    }
                    listDownloads.Items.Add(item);
                }
                listDownloads.EndUpdate();
                listDownloads.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        #endregion Install

        #region Plugins

        private readonly Regex regexPluginDisabled = new Regex(@"(\.disabled)*\.dll");
        private readonly Regex regexPluginEnabled = new Regex(@"(?<!\.disabled)\.dll");

        private IEnumerable<IPlugin> plugins;

        private void LoadPlugins()
        {
            PluginLoader loader = new PluginLoader();
            loader.LoadDirectory(PathPlugins);
            plugins = loader.GetPlugins();

            listPlugins.BeginUpdate();
            foreach (IPlugin plugin in plugins)
            {
                var isEnabled = regexPluginEnabled.IsMatch(plugin.GetType().Assembly.Location);
                var item = new ListViewItem { Text = plugin.GetType().Assembly.GetTitle(), Tag = plugin, Checked = isEnabled };
                item.SubItems.Add(plugin.GetType().Assembly.GetFileVersion());
                listPlugins.Items.Add(item);
                plugin.MainForm = this;
                if (isEnabled)
                {
                    plugin.Load();
                }
            }
            listPlugins.EndUpdate();
        }

        private void UnloadPlugins()
        {
            foreach (IPlugin plugin in plugins)
            {
                plugin.Unload();
            }
        }

        public void AddUnpackRule(Regex regex, UnpackMatch unpackMatch)
        {
            unpackRules.Add(regex, unpackMatch);
        }

        public void AddDownloadRow(string downloadId, string labelName, Bitmap labelImage = null)
        {
            sourceLoader.SourceTags.Add(downloadId);
            if (labelImage != null) imageList.Images.Add(downloadId, labelImage);

            var combo = new ComboBox
            {
                Dock = DockStyle.Top,
                Name = nameComboDownload + downloadId,
                Margin = new Padding(5)
            };

            var label = new Label
            {
                Text = labelName + ":",
                ImageAlign = ContentAlignment.MiddleLeft,
                TextAlign = ContentAlignment.MiddleCenter,
                Image = labelImage,
                AutoSize = false,
                Dock = DockStyle.Fill
            };

            tableDownloadPrograms.RowCount += 1;
            tableDownloadPrograms.Controls.Add(label, 0, tableDownloadPrograms.RowCount);
            tableDownloadPrograms.Controls.Add(combo, 1, tableDownloadPrograms.RowCount);
        }

        public void AddSetupRow(string setupId, string buttonName, Type formType, Bitmap buttonImage = null)
        {
            var button = new SetupButton(setupId, buttonName, buttonImage);
            var form = (Form)Activator.CreateInstance(formType);
            button.Click += delegate
            {
                form.ShowDialog();
            };
            flowSetup.Controls.Add(button);
        }

        public void AddSetupRow(string setupId, string buttonName, Form form, Bitmap buttonImage = null)
        {
            var button = new SetupButton(setupId, buttonName, buttonImage);
            button.Click += delegate
            {
                form.ShowDialog();
            };
            flowSetup.Controls.Add(button);
        }

        public ManageServiceControl AddManageRow(string setupId, string groupName, string defaultServiceName = null, Action<GroupBox> finishAction = null, ContextMenuStrip contextMenu = null)
        {
            defaultServiceName = defaultServiceName ?? String.Empty;
            var control = new ManageServiceControl(groupName, defaultServiceName, finishAction, contextMenu);
            control.Name = "manageControl_" + setupId;
            control.Dock = DockStyle.Top;
            tableManage.Controls.Add(control, 1, tableManage.RowCount);
            tableManage.RowCount += 1;
            return control;
        }

        private void listPlugin_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var plugin = (IPlugin)e.Item.Tag;
            richPlugin.Text = plugin.GetType().Assembly.GetDescCopy();
        }

        private void buttonPluginsRestartApp_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listPlugins.Items)
            {
                var plugin = (IPlugin)item.Tag;
                var path = plugin.GetType().Assembly.Location;
                var newPath = item.Checked ? regexPluginDisabled.Replace(path, ".dll") : regexPluginEnabled.Replace(path, ".disabled.dll");
                if (path != newPath) File.Move(path, newPath);
            }

            Application.Restart();
        }

        #endregion Plugins

        #region Options

        private void LoadConfiguration(bool firstLoad = false)
        {
            notifyIcon.Icon = Icon;
            notifyIcon.Visible = Properties.Settings.Default.minimizeToTray;
            checkMinimizeToTray.Checked = Properties.Settings.Default.minimizeToTray;

            checkUpdatesOnStartup.Checked = Properties.Settings.Default.checkForUpdates;
            if (firstLoad)
            {
                UpdateChecker.Check();
            }
        }

        private void checkMinimizeToTray_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.minimizeToTray = checkMinimizeToTray.Checked;
        }

        private void checkUpdatesOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkForUpdates = checkUpdatesOnStartup.Checked;
        }

        private void buttonOptionsSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            LoadConfiguration();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && Properties.Settings.Default.minimizeToTray)
            {
                Hide();
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (Visible)
            {
                Hide();
            }
            else
            {
                Show();
            }
            WindowState = FormWindowState.Normal;
        }

        #endregion Options

        #region About

        private void richAbout_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (MessageBox.Show(String.Format(TextQuestionOpenLink, e.LinkText), Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Process.Start(e.LinkText);
        }

        private async void buttonUpdateCheck_Click(object sender, EventArgs e)
        {
            var oldText = buttonUpdateCheck.Text;
            ToggleButton(buttonUpdateCheck, false, TextLoading);
            await UpdateChecker.Check(true);
            ToggleButton(buttonUpdateCheck, true, oldText);
        }

        #endregion About
    }
}