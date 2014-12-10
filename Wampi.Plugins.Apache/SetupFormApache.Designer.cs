namespace Wampi
{
    partial class SetupFormApache
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupDirectives = new System.Windows.Forms.GroupBox();
            this.tableDirectives = new System.Windows.Forms.TableLayoutPanel();
            this.linkServerAdmin = new System.Windows.Forms.LinkLabel();
            this.textServerRoot = new System.Windows.Forms.TextBox();
            this.linkServerRoot = new System.Windows.Forms.LinkLabel();
            this.linkDocumentRoot = new System.Windows.Forms.LinkLabel();
            this.linkListen = new System.Windows.Forms.LinkLabel();
            this.textDocumentRoot = new System.Windows.Forms.TextBox();
            this.textListen = new System.Windows.Forms.TextBox();
            this.linkServerName = new System.Windows.Forms.LinkLabel();
            this.textServerName = new System.Windows.Forms.TextBox();
            this.textServerAdmin = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAutoConfig = new System.Windows.Forms.Button();
            this.panelService = new System.Windows.Forms.Panel();
            this.buttonUninstall = new System.Windows.Forms.Button();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.textService = new System.Windows.Forms.TextBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.buttonActivatePhp = new System.Windows.Forms.Button();
            this.groupDirectives.SuspendLayout();
            this.tableDirectives.SuspendLayout();
            this.panelService.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(177, 32);
            this.buttonLoad.TabIndex = 28;
            this.buttonLoad.Text = "Load Apache Configuration";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "Apache Configuration File|*.conf";
            // 
            // groupDirectives
            // 
            this.groupDirectives.Controls.Add(this.tableDirectives);
            this.groupDirectives.Enabled = false;
            this.groupDirectives.Location = new System.Drawing.Point(12, 50);
            this.groupDirectives.Name = "groupDirectives";
            this.groupDirectives.Size = new System.Drawing.Size(307, 148);
            this.groupDirectives.TabIndex = 27;
            this.groupDirectives.TabStop = false;
            this.groupDirectives.Text = "Directives";
            // 
            // tableDirectives
            // 
            this.tableDirectives.AutoSize = true;
            this.tableDirectives.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableDirectives.ColumnCount = 2;
            this.tableDirectives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableDirectives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableDirectives.Controls.Add(this.linkServerAdmin, 0, 4);
            this.tableDirectives.Controls.Add(this.textServerRoot, 1, 0);
            this.tableDirectives.Controls.Add(this.linkServerRoot, 0, 0);
            this.tableDirectives.Controls.Add(this.linkDocumentRoot, 0, 1);
            this.tableDirectives.Controls.Add(this.linkListen, 0, 2);
            this.tableDirectives.Controls.Add(this.textDocumentRoot, 1, 1);
            this.tableDirectives.Controls.Add(this.textListen, 1, 2);
            this.tableDirectives.Controls.Add(this.linkServerName, 0, 3);
            this.tableDirectives.Controls.Add(this.textServerName, 1, 3);
            this.tableDirectives.Controls.Add(this.textServerAdmin, 1, 4);
            this.tableDirectives.Location = new System.Drawing.Point(6, 19);
            this.tableDirectives.Name = "tableDirectives";
            this.tableDirectives.RowCount = 5;
            this.tableDirectives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableDirectives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableDirectives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableDirectives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableDirectives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableDirectives.Size = new System.Drawing.Size(300, 125);
            this.tableDirectives.TabIndex = 36;
            // 
            // linkServerAdmin
            // 
            this.linkServerAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkServerAdmin.Location = new System.Drawing.Point(3, 100);
            this.linkServerAdmin.Name = "linkServerAdmin";
            this.linkServerAdmin.Size = new System.Drawing.Size(94, 25);
            this.linkServerAdmin.TabIndex = 40;
            this.linkServerAdmin.TabStop = true;
            this.linkServerAdmin.Text = "Server admin";
            this.linkServerAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textServerRoot
            // 
            this.textServerRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textServerRoot.Location = new System.Drawing.Point(103, 3);
            this.textServerRoot.Name = "textServerRoot";
            this.textServerRoot.Size = new System.Drawing.Size(194, 20);
            this.textServerRoot.TabIndex = 18;
            // 
            // linkServerRoot
            // 
            this.linkServerRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkServerRoot.Location = new System.Drawing.Point(3, 0);
            this.linkServerRoot.Name = "linkServerRoot";
            this.linkServerRoot.Size = new System.Drawing.Size(94, 25);
            this.linkServerRoot.TabIndex = 33;
            this.linkServerRoot.TabStop = true;
            this.linkServerRoot.Text = "Server root";
            this.linkServerRoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkDocumentRoot
            // 
            this.linkDocumentRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkDocumentRoot.Location = new System.Drawing.Point(3, 25);
            this.linkDocumentRoot.Name = "linkDocumentRoot";
            this.linkDocumentRoot.Size = new System.Drawing.Size(94, 25);
            this.linkDocumentRoot.TabIndex = 34;
            this.linkDocumentRoot.TabStop = true;
            this.linkDocumentRoot.Text = "Document root";
            this.linkDocumentRoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkListen
            // 
            this.linkListen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkListen.Location = new System.Drawing.Point(3, 50);
            this.linkListen.Name = "linkListen";
            this.linkListen.Size = new System.Drawing.Size(94, 25);
            this.linkListen.TabIndex = 35;
            this.linkListen.TabStop = true;
            this.linkListen.Text = "Listen port";
            this.linkListen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textDocumentRoot
            // 
            this.textDocumentRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDocumentRoot.Location = new System.Drawing.Point(103, 28);
            this.textDocumentRoot.Name = "textDocumentRoot";
            this.textDocumentRoot.Size = new System.Drawing.Size(194, 20);
            this.textDocumentRoot.TabIndex = 27;
            // 
            // textListen
            // 
            this.textListen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textListen.Location = new System.Drawing.Point(103, 53);
            this.textListen.Name = "textListen";
            this.textListen.Size = new System.Drawing.Size(194, 20);
            this.textListen.TabIndex = 31;
            // 
            // linkServerName
            // 
            this.linkServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkServerName.Location = new System.Drawing.Point(3, 75);
            this.linkServerName.Name = "linkServerName";
            this.linkServerName.Size = new System.Drawing.Size(94, 25);
            this.linkServerName.TabIndex = 39;
            this.linkServerName.TabStop = true;
            this.linkServerName.Text = "Server name";
            this.linkServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textServerName
            // 
            this.textServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textServerName.Location = new System.Drawing.Point(103, 78);
            this.textServerName.Name = "textServerName";
            this.textServerName.Size = new System.Drawing.Size(194, 20);
            this.textServerName.TabIndex = 38;
            // 
            // textServerAdmin
            // 
            this.textServerAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textServerAdmin.Location = new System.Drawing.Point(103, 103);
            this.textServerAdmin.Name = "textServerAdmin";
            this.textServerAdmin.Size = new System.Drawing.Size(194, 20);
            this.textServerAdmin.TabIndex = 41;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(11, 288);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(307, 32);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAutoConfig
            // 
            this.buttonAutoConfig.Enabled = false;
            this.buttonAutoConfig.Location = new System.Drawing.Point(195, 12);
            this.buttonAutoConfig.Name = "buttonAutoConfig";
            this.buttonAutoConfig.Size = new System.Drawing.Size(124, 32);
            this.buttonAutoConfig.TabIndex = 32;
            this.buttonAutoConfig.Text = "Auto Config.";
            this.buttonAutoConfig.UseVisualStyleBackColor = true;
            this.buttonAutoConfig.Click += new System.EventHandler(this.buttonAutoConfig_Click);
            // 
            // panelService
            // 
            this.panelService.Controls.Add(this.buttonUninstall);
            this.panelService.Controls.Add(this.buttonInstall);
            this.panelService.Controls.Add(this.textService);
            this.panelService.Controls.Add(this.linkLabel6);
            this.panelService.Enabled = false;
            this.panelService.Location = new System.Drawing.Point(12, 204);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(307, 40);
            this.panelService.TabIndex = 48;
            // 
            // buttonUninstall
            // 
            this.buttonUninstall.Location = new System.Drawing.Point(222, 4);
            this.buttonUninstall.Name = "buttonUninstall";
            this.buttonUninstall.Size = new System.Drawing.Size(81, 32);
            this.buttonUninstall.TabIndex = 50;
            this.buttonUninstall.Text = "Uninstall";
            this.buttonUninstall.UseVisualStyleBackColor = true;
            this.buttonUninstall.Click += new System.EventHandler(this.buttonUninstall_Click);
            // 
            // buttonInstall
            // 
            this.buttonInstall.Location = new System.Drawing.Point(135, 4);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(81, 32);
            this.buttonInstall.TabIndex = 49;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // textService
            // 
            this.textService.Location = new System.Drawing.Point(2, 15);
            this.textService.Name = "textService";
            this.textService.Size = new System.Drawing.Size(127, 20);
            this.textService.TabIndex = 48;
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(-3, 0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(88, 13);
            this.linkLabel6.TabIndex = 47;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Windows service";
            // 
            // buttonActivatePhp
            // 
            this.buttonActivatePhp.Enabled = false;
            this.buttonActivatePhp.Location = new System.Drawing.Point(12, 250);
            this.buttonActivatePhp.Name = "buttonActivatePhp";
            this.buttonActivatePhp.Size = new System.Drawing.Size(307, 32);
            this.buttonActivatePhp.TabIndex = 50;
            this.buttonActivatePhp.Text = "Activate PHP";
            this.buttonActivatePhp.UseVisualStyleBackColor = true;
            this.buttonActivatePhp.Click += new System.EventHandler(this.buttonActivatePhp_Click);
            // 
            // SetupFormApache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 329);
            this.Controls.Add(this.buttonActivatePhp);
            this.Controls.Add(this.panelService);
            this.Controls.Add(this.buttonAutoConfig);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.groupDirectives);
            this.Name = "SetupFormApache";
            this.Text = "Setup: Apache";
            this.groupDirectives.ResumeLayout(false);
            this.groupDirectives.PerformLayout();
            this.tableDirectives.ResumeLayout(false);
            this.tableDirectives.PerformLayout();
            this.panelService.ResumeLayout(false);
            this.panelService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.GroupBox groupDirectives;
        private System.Windows.Forms.TableLayoutPanel tableDirectives;
        private System.Windows.Forms.TextBox textServerRoot;
        private System.Windows.Forms.LinkLabel linkServerRoot;
        private System.Windows.Forms.LinkLabel linkDocumentRoot;
        private System.Windows.Forms.LinkLabel linkListen;
        private System.Windows.Forms.TextBox textDocumentRoot;
        private System.Windows.Forms.TextBox textListen;
        private System.Windows.Forms.LinkLabel linkServerAdmin;
        private System.Windows.Forms.LinkLabel linkServerName;
        private System.Windows.Forms.TextBox textServerName;
        private System.Windows.Forms.TextBox textServerAdmin;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAutoConfig;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.Button buttonUninstall;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.TextBox textService;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.Button buttonActivatePhp;
    }
}