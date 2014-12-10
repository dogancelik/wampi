namespace Wampi
{
    partial class SetupFormMysql
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
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonLocate = new System.Windows.Forms.Button();
            this.buttonUninstall = new System.Windows.Forms.Button();
            this.groupService = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textService = new System.Windows.Forms.TextBox();
            this.textRoot = new System.Windows.Forms.TextBox();
            this.mysqldDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupService.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInstall
            // 
            this.buttonInstall.Location = new System.Drawing.Point(6, 71);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(161, 32);
            this.buttonInstall.TabIndex = 4;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // buttonLocate
            // 
            this.buttonLocate.Location = new System.Drawing.Point(12, 12);
            this.buttonLocate.Name = "buttonLocate";
            this.buttonLocate.Size = new System.Drawing.Size(284, 32);
            this.buttonLocate.TabIndex = 0;
            this.buttonLocate.Text = "Locate MySQLd";
            this.buttonLocate.UseVisualStyleBackColor = true;
            this.buttonLocate.Click += new System.EventHandler(this.buttonLocate_Click);
            // 
            // buttonUninstall
            // 
            this.buttonUninstall.Location = new System.Drawing.Point(173, 71);
            this.buttonUninstall.Name = "buttonUninstall";
            this.buttonUninstall.Size = new System.Drawing.Size(105, 32);
            this.buttonUninstall.TabIndex = 5;
            this.buttonUninstall.Text = "Uninstall";
            this.buttonUninstall.UseVisualStyleBackColor = true;
            this.buttonUninstall.Click += new System.EventHandler(this.buttonUninstall_Click);
            // 
            // groupService
            // 
            this.groupService.Controls.Add(this.label2);
            this.groupService.Controls.Add(this.label1);
            this.groupService.Controls.Add(this.textService);
            this.groupService.Controls.Add(this.buttonInstall);
            this.groupService.Controls.Add(this.textRoot);
            this.groupService.Controls.Add(this.buttonUninstall);
            this.groupService.Location = new System.Drawing.Point(12, 50);
            this.groupService.Name = "groupService";
            this.groupService.Size = new System.Drawing.Size(284, 111);
            this.groupService.TabIndex = 2;
            this.groupService.TabStop = false;
            this.groupService.Text = "Windows service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Root password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Service name:";
            // 
            // textService
            // 
            this.textService.Location = new System.Drawing.Point(93, 19);
            this.textService.Name = "textService";
            this.textService.Size = new System.Drawing.Size(169, 20);
            this.textService.TabIndex = 6;
            // 
            // textRoot
            // 
            this.textRoot.Location = new System.Drawing.Point(93, 45);
            this.textRoot.Name = "textRoot";
            this.textRoot.Size = new System.Drawing.Size(169, 20);
            this.textRoot.TabIndex = 3;
            // 
            // mysqldDialog
            // 
            this.mysqldDialog.Filter = "mysqld.exe|mysqld.exe";
            // 
            // SetupFormMysql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 171);
            this.Controls.Add(this.groupService);
            this.Controls.Add(this.buttonLocate);
            this.Name = "SetupFormMysql";
            this.Text = "Setup: MySQL";
            this.groupService.ResumeLayout(false);
            this.groupService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Button buttonLocate;
        private System.Windows.Forms.Button buttonUninstall;
        private System.Windows.Forms.GroupBox groupService;
        private System.Windows.Forms.OpenFileDialog mysqldDialog;
        private System.Windows.Forms.TextBox textRoot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textService;
    }
}