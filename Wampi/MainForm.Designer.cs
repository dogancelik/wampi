namespace Wampi
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDownload = new System.Windows.Forms.TabPage();
            this.tableDownload = new System.Windows.Forms.TableLayoutPanel();
            this.tableDownloadPrograms = new System.Windows.Forms.TableLayoutPanel();
            this.flowDownloadTop = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoadSourceOfficial = new System.Windows.Forms.Button();
            this.buttonLoadSourceLocal = new System.Windows.Forms.Button();
            this.buttonLoadSourceUrl = new System.Windows.Forms.Button();
            this.checkAppendSource = new System.Windows.Forms.CheckBox();
            this.panelDownloadBottom = new System.Windows.Forms.Panel();
            this.progressDownload = new System.Windows.Forms.ProgressBar();
            this.labelDownload = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.linkDownloadHelp = new System.Windows.Forms.LinkLabel();
            this.tabInstall = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelInstallBottom = new System.Windows.Forms.Panel();
            this.buttonListDownloads = new System.Windows.Forms.Button();
            this.linkInstallHelp = new System.Windows.Forms.LinkLabel();
            this.labelInstallProgress = new System.Windows.Forms.Label();
            this.progressInstall = new System.Windows.Forms.ProgressBar();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.panelInstallTop = new System.Windows.Forms.Panel();
            this.buttonInstallFolderDialog = new System.Windows.Forms.Button();
            this.textInstallDirectory = new System.Windows.Forms.TextBox();
            this.labelInstallDirectory = new System.Windows.Forms.Label();
            this.listDownloads = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.flowSetup = new System.Windows.Forms.FlowLayoutPanel();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.tableManage = new System.Windows.Forms.TableLayoutPanel();
            this.tabPlugins = new System.Windows.Forms.TabPage();
            this.splitPlugins = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listPlugins = new System.Windows.Forms.ListView();
            this.columnPluginName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPluginVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowPluginsTop = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPluginsRestartApp = new System.Windows.Forms.Button();
            this.labelPluginsHelp = new System.Windows.Forms.Label();
            this.richPlugin = new System.Windows.Forms.RichTextBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.groupDownloadDirectory = new System.Windows.Forms.GroupBox();
            this.buttonDownloadDirectoryOpen = new System.Windows.Forms.Button();
            this.textDownloadDirectory = new System.Windows.Forms.TextBox();
            this.radioDownloadDirectoryCustom = new System.Windows.Forms.RadioButton();
            this.radioDownloadDirectoryDefault = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOptionsSave = new System.Windows.Forms.Button();
            this.checkUpdatesOnStartup = new System.Windows.Forms.CheckBox();
            this.checkMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.buttonUpdateCheck = new System.Windows.Forms.Button();
            this.richAbout = new System.Windows.Forms.RichTextBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sourcesDialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl.SuspendLayout();
            this.tabDownload.SuspendLayout();
            this.tableDownload.SuspendLayout();
            this.flowDownloadTop.SuspendLayout();
            this.panelDownloadBottom.SuspendLayout();
            this.tabInstall.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelInstallBottom.SuspendLayout();
            this.panelInstallTop.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tabManage.SuspendLayout();
            this.tabPlugins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPlugins)).BeginInit();
            this.splitPlugins.Panel1.SuspendLayout();
            this.splitPlugins.Panel2.SuspendLayout();
            this.splitPlugins.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowPluginsTop.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.groupDownloadDirectory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDownload);
            this.tabControl.Controls.Add(this.tabInstall);
            this.tabControl.Controls.Add(this.tabSetup);
            this.tabControl.Controls.Add(this.tabManage);
            this.tabControl.Controls.Add(this.tabPlugins);
            this.tabControl.Controls.Add(this.tabOptions);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(464, 392);
            this.tabControl.TabIndex = 1;
            // 
            // tabDownload
            // 
            this.tabDownload.Controls.Add(this.tableDownload);
            this.tabDownload.Location = new System.Drawing.Point(4, 22);
            this.tabDownload.Name = "tabDownload";
            this.tabDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabDownload.Size = new System.Drawing.Size(456, 366);
            this.tabDownload.TabIndex = 1;
            this.tabDownload.Text = "Download";
            this.tabDownload.UseVisualStyleBackColor = true;
            // 
            // tableDownload
            // 
            this.tableDownload.ColumnCount = 1;
            this.tableDownload.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDownload.Controls.Add(this.tableDownloadPrograms, 0, 0);
            this.tableDownload.Controls.Add(this.flowDownloadTop, 0, 0);
            this.tableDownload.Controls.Add(this.panelDownloadBottom, 0, 2);
            this.tableDownload.Controls.Add(this.linkDownloadHelp, 0, 3);
            this.tableDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDownload.Location = new System.Drawing.Point(3, 3);
            this.tableDownload.Name = "tableDownload";
            this.tableDownload.RowCount = 4;
            this.tableDownload.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableDownload.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableDownload.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableDownload.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableDownload.Size = new System.Drawing.Size(450, 360);
            this.tableDownload.TabIndex = 20;
            // 
            // tableDownloadPrograms
            // 
            this.tableDownloadPrograms.AutoSize = true;
            this.tableDownloadPrograms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableDownloadPrograms.ColumnCount = 2;
            this.tableDownloadPrograms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableDownloadPrograms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableDownloadPrograms.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableDownloadPrograms.Location = new System.Drawing.Point(3, 70);
            this.tableDownloadPrograms.Name = "tableDownloadPrograms";
            this.tableDownloadPrograms.Size = new System.Drawing.Size(444, 0);
            this.tableDownloadPrograms.TabIndex = 21;
            // 
            // flowDownloadTop
            // 
            this.flowDownloadTop.AutoSize = true;
            this.flowDownloadTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowDownloadTop.Controls.Add(this.buttonLoadSourceOfficial);
            this.flowDownloadTop.Controls.Add(this.buttonLoadSourceLocal);
            this.flowDownloadTop.Controls.Add(this.buttonLoadSourceUrl);
            this.flowDownloadTop.Controls.Add(this.checkAppendSource);
            this.flowDownloadTop.Location = new System.Drawing.Point(3, 3);
            this.flowDownloadTop.Name = "flowDownloadTop";
            this.flowDownloadTop.Size = new System.Drawing.Size(388, 61);
            this.flowDownloadTop.TabIndex = 24;
            // 
            // buttonLoadSourceOfficial
            // 
            this.buttonLoadSourceOfficial.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadSourceOfficial.Name = "buttonLoadSourceOfficial";
            this.buttonLoadSourceOfficial.Size = new System.Drawing.Size(140, 32);
            this.buttonLoadSourceOfficial.TabIndex = 0;
            this.buttonLoadSourceOfficial.Text = "Load the official sources";
            this.buttonLoadSourceOfficial.UseVisualStyleBackColor = true;
            this.buttonLoadSourceOfficial.Click += new System.EventHandler(this.buttonLoadSourceOfficial_Click);
            // 
            // buttonLoadSourceLocal
            // 
            this.buttonLoadSourceLocal.Location = new System.Drawing.Point(149, 3);
            this.buttonLoadSourceLocal.Name = "buttonLoadSourceLocal";
            this.buttonLoadSourceLocal.Size = new System.Drawing.Size(148, 32);
            this.buttonLoadSourceLocal.TabIndex = 1;
            this.buttonLoadSourceLocal.Text = "Load a custom sources file";
            this.buttonLoadSourceLocal.UseVisualStyleBackColor = true;
            this.buttonLoadSourceLocal.Click += new System.EventHandler(this.buttonLoadSourceLocal_Click);
            // 
            // buttonLoadSourceUrl
            // 
            this.buttonLoadSourceUrl.Location = new System.Drawing.Point(303, 3);
            this.buttonLoadSourceUrl.Name = "buttonLoadSourceUrl";
            this.buttonLoadSourceUrl.Size = new System.Drawing.Size(82, 32);
            this.buttonLoadSourceUrl.TabIndex = 2;
            this.buttonLoadSourceUrl.Text = "Load a URL";
            this.buttonLoadSourceUrl.UseVisualStyleBackColor = true;
            this.buttonLoadSourceUrl.Click += new System.EventHandler(this.buttonLoadSourceUrl_Click);
            // 
            // checkAppendSource
            // 
            this.checkAppendSource.AutoSize = true;
            this.checkAppendSource.Location = new System.Drawing.Point(3, 41);
            this.checkAppendSource.Name = "checkAppendSource";
            this.checkAppendSource.Size = new System.Drawing.Size(103, 17);
            this.checkAppendSource.TabIndex = 3;
            this.checkAppendSource.Text = "Append sources";
            this.checkAppendSource.UseVisualStyleBackColor = true;
            // 
            // panelDownloadBottom
            // 
            this.panelDownloadBottom.Controls.Add(this.progressDownload);
            this.panelDownloadBottom.Controls.Add(this.labelDownload);
            this.panelDownloadBottom.Controls.Add(this.buttonDownload);
            this.panelDownloadBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDownloadBottom.Location = new System.Drawing.Point(3, 76);
            this.panelDownloadBottom.Name = "panelDownloadBottom";
            this.panelDownloadBottom.Size = new System.Drawing.Size(444, 84);
            this.panelDownloadBottom.TabIndex = 22;
            // 
            // progressDownload
            // 
            this.progressDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressDownload.Location = new System.Drawing.Point(6, 16);
            this.progressDownload.Name = "progressDownload";
            this.progressDownload.Size = new System.Drawing.Size(435, 23);
            this.progressDownload.TabIndex = 17;
            // 
            // labelDownload
            // 
            this.labelDownload.AutoSize = true;
            this.labelDownload.Location = new System.Drawing.Point(3, 0);
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Size = new System.Drawing.Size(72, 13);
            this.labelDownload.TabIndex = 16;
            this.labelDownload.Text = "Downloading:";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload.Image = global::Wampi.Properties.Resources.download;
            this.buttonDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDownload.Location = new System.Drawing.Point(6, 45);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(435, 32);
            this.buttonDownload.TabIndex = 6;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // linkDownloadHelp
            // 
            this.linkDownloadHelp.AutoSize = true;
            this.linkDownloadHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkDownloadHelp.Location = new System.Drawing.Point(3, 163);
            this.linkDownloadHelp.Name = "linkDownloadHelp";
            this.linkDownloadHelp.Size = new System.Drawing.Size(444, 13);
            this.linkDownloadHelp.TabIndex = 25;
            this.linkDownloadHelp.TabStop = true;
            this.linkDownloadHelp.Text = "What should I download?";
            this.linkDownloadHelp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkDownloadHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDownloadHelp_LinkClicked);
            // 
            // tabInstall
            // 
            this.tabInstall.Controls.Add(this.tableLayoutPanel2);
            this.tabInstall.Location = new System.Drawing.Point(4, 22);
            this.tabInstall.Name = "tabInstall";
            this.tabInstall.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstall.Size = new System.Drawing.Size(456, 366);
            this.tabInstall.TabIndex = 2;
            this.tabInstall.Text = "Install";
            this.tabInstall.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panelInstallBottom, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panelInstallTop, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listDownloads, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(450, 360);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panelInstallBottom
            // 
            this.panelInstallBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInstallBottom.Controls.Add(this.buttonListDownloads);
            this.panelInstallBottom.Controls.Add(this.linkInstallHelp);
            this.panelInstallBottom.Controls.Add(this.labelInstallProgress);
            this.panelInstallBottom.Controls.Add(this.progressInstall);
            this.panelInstallBottom.Controls.Add(this.buttonInstall);
            this.panelInstallBottom.Location = new System.Drawing.Point(3, 255);
            this.panelInstallBottom.Name = "panelInstallBottom";
            this.panelInstallBottom.Size = new System.Drawing.Size(444, 102);
            this.panelInstallBottom.TabIndex = 10;
            // 
            // buttonListDownloads
            // 
            this.buttonListDownloads.Image = global::Wampi.Properties.Resources.refresh;
            this.buttonListDownloads.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonListDownloads.Location = new System.Drawing.Point(6, 52);
            this.buttonListDownloads.Name = "buttonListDownloads";
            this.buttonListDownloads.Size = new System.Drawing.Size(176, 32);
            this.buttonListDownloads.TabIndex = 14;
            this.buttonListDownloads.Text = "Refresh download list";
            this.buttonListDownloads.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonListDownloads.UseVisualStyleBackColor = true;
            this.buttonListDownloads.Click += new System.EventHandler(this.buttonListDownloads_Click);
            // 
            // linkInstallHelp
            // 
            this.linkInstallHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkInstallHelp.AutoSize = true;
            this.linkInstallHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkInstallHelp.LinkColor = System.Drawing.Color.Red;
            this.linkInstallHelp.Location = new System.Drawing.Point(278, 88);
            this.linkInstallHelp.Name = "linkInstallHelp";
            this.linkInstallHelp.Size = new System.Drawing.Size(155, 13);
            this.linkInstallHelp.TabIndex = 13;
            this.linkInstallHelp.TabStop = true;
            this.linkInstallHelp.Text = "Read this before installing";
            this.linkInstallHelp.Click += new System.EventHandler(this.linkInstallHelp_Click);
            // 
            // labelInstallProgress
            // 
            this.labelInstallProgress.AutoSize = true;
            this.labelInstallProgress.Location = new System.Drawing.Point(3, 7);
            this.labelInstallProgress.Name = "labelInstallProgress";
            this.labelInstallProgress.Size = new System.Drawing.Size(48, 13);
            this.labelInstallProgress.TabIndex = 12;
            this.labelInstallProgress.Text = "Progress";
            // 
            // progressInstall
            // 
            this.progressInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressInstall.Location = new System.Drawing.Point(6, 23);
            this.progressInstall.Name = "progressInstall";
            this.progressInstall.Size = new System.Drawing.Size(428, 23);
            this.progressInstall.TabIndex = 11;
            // 
            // buttonInstall
            // 
            this.buttonInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstall.Image = global::Wampi.Properties.Resources.download;
            this.buttonInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInstall.Location = new System.Drawing.Point(295, 52);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(139, 32);
            this.buttonInstall.TabIndex = 10;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // panelInstallTop
            // 
            this.panelInstallTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInstallTop.Controls.Add(this.buttonInstallFolderDialog);
            this.panelInstallTop.Controls.Add(this.textInstallDirectory);
            this.panelInstallTop.Controls.Add(this.labelInstallDirectory);
            this.panelInstallTop.Location = new System.Drawing.Point(3, 3);
            this.panelInstallTop.Name = "panelInstallTop";
            this.panelInstallTop.Size = new System.Drawing.Size(444, 39);
            this.panelInstallTop.TabIndex = 8;
            // 
            // buttonInstallFolderDialog
            // 
            this.buttonInstallFolderDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstallFolderDialog.Location = new System.Drawing.Point(336, 3);
            this.buttonInstallFolderDialog.Name = "buttonInstallFolderDialog";
            this.buttonInstallFolderDialog.Size = new System.Drawing.Size(104, 33);
            this.buttonInstallFolderDialog.TabIndex = 8;
            this.buttonInstallFolderDialog.Text = "Open folder dialog";
            this.buttonInstallFolderDialog.UseVisualStyleBackColor = true;
            this.buttonInstallFolderDialog.Click += new System.EventHandler(this.buttonInstallFolderDialog_Click);
            // 
            // textInstallDirectory
            // 
            this.textInstallDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInstallDirectory.Location = new System.Drawing.Point(6, 16);
            this.textInstallDirectory.Name = "textInstallDirectory";
            this.textInstallDirectory.Size = new System.Drawing.Size(324, 20);
            this.textInstallDirectory.TabIndex = 7;
            // 
            // labelInstallDirectory
            // 
            this.labelInstallDirectory.AutoSize = true;
            this.labelInstallDirectory.Location = new System.Drawing.Point(3, 0);
            this.labelInstallDirectory.Name = "labelInstallDirectory";
            this.labelInstallDirectory.Size = new System.Drawing.Size(80, 13);
            this.labelInstallDirectory.TabIndex = 6;
            this.labelInstallDirectory.Text = "Install directory:";
            // 
            // listDownloads
            // 
            this.listDownloads.CheckBoxes = true;
            this.listDownloads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listDownloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDownloads.FullRowSelect = true;
            this.listDownloads.Location = new System.Drawing.Point(3, 48);
            this.listDownloads.Name = "listDownloads";
            this.listDownloads.Size = new System.Drawing.Size(444, 201);
            this.listDownloads.TabIndex = 12;
            this.listDownloads.UseCompatibleStateImageBehavior = false;
            this.listDownloads.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Downloads";
            this.columnHeader1.Width = 250;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.flowSetup);
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(456, 366);
            this.tabSetup.TabIndex = 3;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // flowSetup
            // 
            this.flowSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSetup.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowSetup.Location = new System.Drawing.Point(3, 3);
            this.flowSetup.Name = "flowSetup";
            this.flowSetup.Size = new System.Drawing.Size(450, 360);
            this.flowSetup.TabIndex = 3;
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.tableManage);
            this.tabManage.Location = new System.Drawing.Point(4, 22);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabManage.Size = new System.Drawing.Size(456, 366);
            this.tabManage.TabIndex = 4;
            this.tabManage.Text = "Manage";
            this.tabManage.UseVisualStyleBackColor = true;
            // 
            // tableManage
            // 
            this.tableManage.ColumnCount = 1;
            this.tableManage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableManage.Location = new System.Drawing.Point(3, 3);
            this.tableManage.Name = "tableManage";
            this.tableManage.RowCount = 1;
            this.tableManage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableManage.Size = new System.Drawing.Size(450, 360);
            this.tableManage.TabIndex = 6;
            // 
            // tabPlugins
            // 
            this.tabPlugins.Controls.Add(this.splitPlugins);
            this.tabPlugins.Location = new System.Drawing.Point(4, 22);
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlugins.Size = new System.Drawing.Size(456, 366);
            this.tabPlugins.TabIndex = 6;
            this.tabPlugins.Text = "Plugins";
            this.tabPlugins.UseVisualStyleBackColor = true;
            // 
            // splitPlugins
            // 
            this.splitPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPlugins.Location = new System.Drawing.Point(3, 3);
            this.splitPlugins.Name = "splitPlugins";
            this.splitPlugins.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPlugins.Panel1
            // 
            this.splitPlugins.Panel1.Controls.Add(this.panel3);
            this.splitPlugins.Panel1.Controls.Add(this.panel2);
            // 
            // splitPlugins.Panel2
            // 
            this.splitPlugins.Panel2.Controls.Add(this.richPlugin);
            this.splitPlugins.Size = new System.Drawing.Size(450, 360);
            this.splitPlugins.SplitterDistance = 247;
            this.splitPlugins.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listPlugins);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 211);
            this.panel3.TabIndex = 4;
            // 
            // listPlugins
            // 
            this.listPlugins.CheckBoxes = true;
            this.listPlugins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPluginName,
            this.columnPluginVersion});
            this.listPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPlugins.FullRowSelect = true;
            this.listPlugins.Location = new System.Drawing.Point(0, 0);
            this.listPlugins.MultiSelect = false;
            this.listPlugins.Name = "listPlugins";
            this.listPlugins.Size = new System.Drawing.Size(450, 211);
            this.listPlugins.TabIndex = 4;
            this.listPlugins.UseCompatibleStateImageBehavior = false;
            this.listPlugins.View = System.Windows.Forms.View.Details;
            this.listPlugins.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listPlugin_ItemSelectionChanged);
            // 
            // columnPluginName
            // 
            this.columnPluginName.Text = "Name";
            this.columnPluginName.Width = 150;
            // 
            // columnPluginVersion
            // 
            this.columnPluginVersion.Text = "Version";
            this.columnPluginVersion.Width = 100;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowPluginsTop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 36);
            this.panel2.TabIndex = 3;
            // 
            // flowPluginsTop
            // 
            this.flowPluginsTop.AutoSize = true;
            this.flowPluginsTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPluginsTop.Controls.Add(this.buttonPluginsRestartApp);
            this.flowPluginsTop.Controls.Add(this.labelPluginsHelp);
            this.flowPluginsTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPluginsTop.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowPluginsTop.Location = new System.Drawing.Point(0, 0);
            this.flowPluginsTop.Name = "flowPluginsTop";
            this.flowPluginsTop.Size = new System.Drawing.Size(450, 36);
            this.flowPluginsTop.TabIndex = 0;
            // 
            // buttonPluginsRestartApp
            // 
            this.buttonPluginsRestartApp.Location = new System.Drawing.Point(356, 3);
            this.buttonPluginsRestartApp.Name = "buttonPluginsRestartApp";
            this.buttonPluginsRestartApp.Size = new System.Drawing.Size(91, 30);
            this.buttonPluginsRestartApp.TabIndex = 0;
            this.buttonPluginsRestartApp.Text = "Restart Wampi";
            this.buttonPluginsRestartApp.UseVisualStyleBackColor = true;
            this.buttonPluginsRestartApp.Click += new System.EventHandler(this.buttonPluginsRestartApp_Click);
            // 
            // labelPluginsHelp
            // 
            this.labelPluginsHelp.Location = new System.Drawing.Point(237, 0);
            this.labelPluginsHelp.Name = "labelPluginsHelp";
            this.labelPluginsHelp.Size = new System.Drawing.Size(113, 36);
            this.labelPluginsHelp.TabIndex = 1;
            this.labelPluginsHelp.Text = "Enabling/disabling plugins require restart";
            this.labelPluginsHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richPlugin
            // 
            this.richPlugin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richPlugin.Location = new System.Drawing.Point(0, 0);
            this.richPlugin.Name = "richPlugin";
            this.richPlugin.ReadOnly = true;
            this.richPlugin.Size = new System.Drawing.Size(450, 109);
            this.richPlugin.TabIndex = 3;
            this.richPlugin.Text = "";
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.groupDownloadDirectory);
            this.tabOptions.Controls.Add(this.panel1);
            this.tabOptions.Controls.Add(this.checkUpdatesOnStartup);
            this.tabOptions.Controls.Add(this.checkMinimizeToTray);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(456, 366);
            this.tabOptions.TabIndex = 5;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // groupDownloadDirectory
            // 
            this.groupDownloadDirectory.Controls.Add(this.buttonDownloadDirectoryOpen);
            this.groupDownloadDirectory.Controls.Add(this.textDownloadDirectory);
            this.groupDownloadDirectory.Controls.Add(this.radioDownloadDirectoryCustom);
            this.groupDownloadDirectory.Controls.Add(this.radioDownloadDirectoryDefault);
            this.groupDownloadDirectory.Location = new System.Drawing.Point(6, 52);
            this.groupDownloadDirectory.Name = "groupDownloadDirectory";
            this.groupDownloadDirectory.Size = new System.Drawing.Size(444, 108);
            this.groupDownloadDirectory.TabIndex = 5;
            this.groupDownloadDirectory.TabStop = false;
            this.groupDownloadDirectory.Text = "Download && Unpack Directory";
            // 
            // buttonDownloadDirectoryOpen
            // 
            this.buttonDownloadDirectoryOpen.Location = new System.Drawing.Point(6, 68);
            this.buttonDownloadDirectoryOpen.Name = "buttonDownloadDirectoryOpen";
            this.buttonDownloadDirectoryOpen.Size = new System.Drawing.Size(432, 30);
            this.buttonDownloadDirectoryOpen.TabIndex = 3;
            this.buttonDownloadDirectoryOpen.Text = "Open Current Selected Directory";
            this.buttonDownloadDirectoryOpen.UseVisualStyleBackColor = true;
            this.buttonDownloadDirectoryOpen.Click += new System.EventHandler(this.buttonDownloadDirectoryOpen_Click);
            // 
            // textDownloadDirectory
            // 
            this.textDownloadDirectory.Location = new System.Drawing.Point(115, 42);
            this.textDownloadDirectory.Name = "textDownloadDirectory";
            this.textDownloadDirectory.Size = new System.Drawing.Size(323, 20);
            this.textDownloadDirectory.TabIndex = 2;
            this.textDownloadDirectory.TextChanged += new System.EventHandler(this.textDownloadDirectory_TextChanged);
            // 
            // radioDownloadDirectoryCustom
            // 
            this.radioDownloadDirectoryCustom.AutoSize = true;
            this.radioDownloadDirectoryCustom.Location = new System.Drawing.Point(6, 42);
            this.radioDownloadDirectoryCustom.Name = "radioDownloadDirectoryCustom";
            this.radioDownloadDirectoryCustom.Size = new System.Drawing.Size(103, 17);
            this.radioDownloadDirectoryCustom.TabIndex = 1;
            this.radioDownloadDirectoryCustom.TabStop = true;
            this.radioDownloadDirectoryCustom.Text = "Custom directory";
            this.radioDownloadDirectoryCustom.UseVisualStyleBackColor = true;
            this.radioDownloadDirectoryCustom.CheckedChanged += new System.EventHandler(this.radioDownloadDirectoryDefault_CheckedChanged);
            // 
            // radioDownloadDirectoryDefault
            // 
            this.radioDownloadDirectoryDefault.AutoSize = true;
            this.radioDownloadDirectoryDefault.Location = new System.Drawing.Point(6, 19);
            this.radioDownloadDirectoryDefault.Name = "radioDownloadDirectoryDefault";
            this.radioDownloadDirectoryDefault.Size = new System.Drawing.Size(223, 17);
            this.radioDownloadDirectoryDefault.TabIndex = 0;
            this.radioDownloadDirectoryDefault.TabStop = true;
            this.radioDownloadDirectoryDefault.Text = "Windows Application Data folder / Wampi";
            this.radioDownloadDirectoryDefault.UseVisualStyleBackColor = true;
            this.radioDownloadDirectoryDefault.CheckedChanged += new System.EventHandler(this.radioDownloadDirectoryDefault_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOptionsSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 42);
            this.panel1.TabIndex = 3;
            // 
            // buttonOptionsSave
            // 
            this.buttonOptionsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOptionsSave.Location = new System.Drawing.Point(327, 3);
            this.buttonOptionsSave.Name = "buttonOptionsSave";
            this.buttonOptionsSave.Size = new System.Drawing.Size(120, 36);
            this.buttonOptionsSave.TabIndex = 2;
            this.buttonOptionsSave.Text = "Save";
            this.buttonOptionsSave.UseVisualStyleBackColor = true;
            this.buttonOptionsSave.Click += new System.EventHandler(this.buttonOptionsSave_Click);
            // 
            // checkUpdatesOnStartup
            // 
            this.checkUpdatesOnStartup.AutoSize = true;
            this.checkUpdatesOnStartup.Location = new System.Drawing.Point(6, 29);
            this.checkUpdatesOnStartup.Name = "checkUpdatesOnStartup";
            this.checkUpdatesOnStartup.Size = new System.Drawing.Size(163, 17);
            this.checkUpdatesOnStartup.TabIndex = 1;
            this.checkUpdatesOnStartup.Text = "Check for updates on startup";
            this.checkUpdatesOnStartup.UseVisualStyleBackColor = true;
            this.checkUpdatesOnStartup.CheckedChanged += new System.EventHandler(this.checkUpdatesOnStartup_CheckedChanged);
            // 
            // checkMinimizeToTray
            // 
            this.checkMinimizeToTray.AutoSize = true;
            this.checkMinimizeToTray.Location = new System.Drawing.Point(6, 6);
            this.checkMinimizeToTray.Name = "checkMinimizeToTray";
            this.checkMinimizeToTray.Size = new System.Drawing.Size(133, 17);
            this.checkMinimizeToTray.TabIndex = 0;
            this.checkMinimizeToTray.Text = "Enable minimize to tray";
            this.checkMinimizeToTray.UseVisualStyleBackColor = true;
            this.checkMinimizeToTray.CheckedChanged += new System.EventHandler(this.checkMinimizeToTray_CheckedChanged);
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.buttonUpdateCheck);
            this.tabAbout.Controls.Add(this.richAbout);
            this.tabAbout.Controls.Add(this.labelVersion);
            this.tabAbout.Controls.Add(this.label1);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(456, 366);
            this.tabAbout.TabIndex = 7;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCheck
            // 
            this.buttonUpdateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateCheck.Location = new System.Drawing.Point(362, 6);
            this.buttonUpdateCheck.Name = "buttonUpdateCheck";
            this.buttonUpdateCheck.Size = new System.Drawing.Size(88, 42);
            this.buttonUpdateCheck.TabIndex = 3;
            this.buttonUpdateCheck.Text = "Check for updates";
            this.buttonUpdateCheck.UseVisualStyleBackColor = true;
            this.buttonUpdateCheck.Click += new System.EventHandler(this.buttonUpdateCheck_Click);
            // 
            // richAbout
            // 
            this.richAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richAbout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richAbout.Location = new System.Drawing.Point(6, 51);
            this.richAbout.Name = "richAbout";
            this.richAbout.ReadOnly = true;
            this.richAbout.Size = new System.Drawing.Size(444, 309);
            this.richAbout.TabIndex = 2;
            this.richAbout.Text = resources.GetString("richAbout.Text");
            this.richAbout.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richAbout_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVersion.Location = new System.Drawing.Point(3, 35);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(450, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version: ";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wampi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sourcesDialog
            // 
            this.sourcesDialog.Filter = "XML files|*.xml";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 412);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wampi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl.ResumeLayout(false);
            this.tabDownload.ResumeLayout(false);
            this.tableDownload.ResumeLayout(false);
            this.tableDownload.PerformLayout();
            this.flowDownloadTop.ResumeLayout(false);
            this.flowDownloadTop.PerformLayout();
            this.panelDownloadBottom.ResumeLayout(false);
            this.panelDownloadBottom.PerformLayout();
            this.tabInstall.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelInstallBottom.ResumeLayout(false);
            this.panelInstallBottom.PerformLayout();
            this.panelInstallTop.ResumeLayout(false);
            this.panelInstallTop.PerformLayout();
            this.tabSetup.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            this.tabPlugins.ResumeLayout(false);
            this.splitPlugins.Panel1.ResumeLayout(false);
            this.splitPlugins.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPlugins)).EndInit();
            this.splitPlugins.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowPluginsTop.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            this.groupDownloadDirectory.ResumeLayout(false);
            this.groupDownloadDirectory.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDownload;
        private System.Windows.Forms.TabPage tabInstall;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.OpenFileDialog sourcesDialog;
        private System.Windows.Forms.TableLayoutPanel tableDownload;
        private System.Windows.Forms.FlowLayoutPanel flowDownloadTop;
        private System.Windows.Forms.Button buttonLoadSourceOfficial;
        private System.Windows.Forms.Button buttonLoadSourceLocal;
        private System.Windows.Forms.Button buttonLoadSourceUrl;
        private System.Windows.Forms.Panel panelDownloadBottom;
        private System.Windows.Forms.ProgressBar progressDownload;
        private System.Windows.Forms.Label labelDownload;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelInstallBottom;
        private System.Windows.Forms.Button buttonListDownloads;
        private System.Windows.Forms.LinkLabel linkInstallHelp;
        private System.Windows.Forms.Label labelInstallProgress;
        private System.Windows.Forms.ProgressBar progressInstall;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Panel panelInstallTop;
        private System.Windows.Forms.Button buttonInstallFolderDialog;
        private System.Windows.Forms.TextBox textInstallDirectory;
        private System.Windows.Forms.Label labelInstallDirectory;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.LinkLabel linkDownloadHelp;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.TabPage tabPlugins;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.CheckBox checkMinimizeToTray;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox checkUpdatesOnStartup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richPlugin;
        private System.Windows.Forms.TableLayoutPanel tableDownloadPrograms;
        private System.Windows.Forms.FlowLayoutPanel flowSetup;
        private System.Windows.Forms.ListView listDownloads;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.SplitContainer splitPlugins;
        private System.Windows.Forms.Button buttonOptionsSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listPlugins;
        private System.Windows.Forms.ColumnHeader columnPluginName;
        private System.Windows.Forms.ColumnHeader columnPluginVersion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowPluginsTop;
        private System.Windows.Forms.Button buttonPluginsRestartApp;
        private System.Windows.Forms.Label labelPluginsHelp;
        private System.Windows.Forms.TableLayoutPanel tableManage;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.RichTextBox richAbout;
        private System.Windows.Forms.CheckBox checkAppendSource;
        private System.Windows.Forms.Button buttonUpdateCheck;
        private System.Windows.Forms.GroupBox groupDownloadDirectory;
        private System.Windows.Forms.Button buttonDownloadDirectoryOpen;
        private System.Windows.Forms.TextBox textDownloadDirectory;
        private System.Windows.Forms.RadioButton radioDownloadDirectoryCustom;
        private System.Windows.Forms.RadioButton radioDownloadDirectoryDefault;




    }
}

