namespace Wampi
{
    partial class ManageServiceControl
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
            worker.CancelAsync();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonMore = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textServiceName = new System.Windows.Forms.TextBox();
            this.pictureStatus = new System.Windows.Forms.PictureBox();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonMore);
            this.groupBox.Controls.Add(this.buttonStop);
            this.groupBox.Controls.Add(this.buttonStart);
            this.groupBox.Controls.Add(this.textServiceName);
            this.groupBox.Controls.Add(this.pictureStatus);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(392, 56);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // buttonMore
            // 
            this.buttonMore.Location = new System.Drawing.Point(226, 13);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(59, 34);
            this.buttonMore.TabIndex = 4;
            this.buttonMore.Text = "More...";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Visible = false;
            // 
            // buttonStop
            // 
            this.buttonStop.Image = global::Wampi.Properties.Resources.stop;
            this.buttonStop.Location = new System.Drawing.Point(186, 13);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(34, 34);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Image = global::Wampi.Properties.Resources.play;
            this.buttonStart.Location = new System.Drawing.Point(146, 13);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(34, 34);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textServiceName
            // 
            this.textServiceName.Location = new System.Drawing.Point(40, 21);
            this.textServiceName.Name = "textServiceName";
            this.textServiceName.Size = new System.Drawing.Size(100, 20);
            this.textServiceName.TabIndex = 1;
            // 
            // pictureStatus
            // 
            this.pictureStatus.Location = new System.Drawing.Point(10, 19);
            this.pictureStatus.Name = "pictureStatus";
            this.pictureStatus.Size = new System.Drawing.Size(24, 24);
            this.pictureStatus.TabIndex = 0;
            this.pictureStatus.TabStop = false;
            // 
            // worker
            // 
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            // 
            // ManageServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "ManageServiceControl";
            this.Size = new System.Drawing.Size(392, 56);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureStatus;
        private System.Windows.Forms.TextBox textServiceName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonMore;
        public System.ComponentModel.BackgroundWorker worker;
    }
}
