namespace ThreadsAndDelegates
{
    partial class DirectorySearcherForm
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
            this.SearchLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.directorySearcher = new ThreadsAndDelegates.DirectorySearcher();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.ForeColor = System.Drawing.Color.Red;
            this.SearchLabel.Location = new System.Drawing.Point(238, 107);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(411, 36);
            this.SearchLabel.TabIndex = 7;
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.Location = new System.Drawing.Point(238, 54);
            this.searchText.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(403, 35);
            this.searchText.TabIndex = 5;
            this.searchText.Text = "c:\\*.cs";
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(14, 36);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(205, 89);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "&Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // directorySearcher
            // 
            this.directorySearcher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directorySearcher.Location = new System.Drawing.Point(14, 161);
            this.directorySearcher.Margin = new System.Windows.Forms.Padding(7);
            this.directorySearcher.Name = "directorySearcher";
            this.directorySearcher.SearchCriteria = null;
            this.directorySearcher.Size = new System.Drawing.Size(632, 386);
            this.directorySearcher.TabIndex = 6;
            // 
            // DirectorySearcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 582);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.directorySearcher);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.SearchButton);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "DirectorySearcherForm";
            this.Text = "DirectorySearcherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLabel;
        private DirectorySearcher directorySearcher;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button SearchButton;
    }
}