﻿namespace ThreadsAndDelegates
{
    partial class BackgroundWorkerDemo
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.MyBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(273, 114);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(175, 51);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(58, 114);
            this.StartButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(175, 51);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(58, 49);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(390, 29);
            this.progressBar1.TabIndex = 7;
            // 
            // MyBackgroundWorker
            // 
            this.MyBackgroundWorker.WorkerReportsProgress = true;
            this.MyBackgroundWorker.WorkerSupportsCancellation = true;
            this.MyBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MyBackgroundWorker_DoWork);
            this.MyBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.MyBackgroundWorker_ProgressChanged);
            this.MyBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MyBackgroundWorker_RunWorkerCompleted);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(58, 216);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 29);
            this.OutputLabel.TabIndex = 10;
            // 
            // BackgroundWorkerDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 279);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.OutputLabel);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "BackgroundWorkerDemo";
            this.Text = "BackgroundWorkerDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker MyBackgroundWorker;
        private System.Windows.Forms.Label OutputLabel;
    }
}