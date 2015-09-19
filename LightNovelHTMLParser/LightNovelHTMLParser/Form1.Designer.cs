namespace LightNovelHTMLParser
{
    partial class LightNovelDownloadForm
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
            this.LightNovelAvailableField = new System.Windows.Forms.CheckedListBox();
            this.LightNovelListLabel = new System.Windows.Forms.Label();
            this.SupportedPageList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchpage_btn = new System.Windows.Forms.Button();
            this.download_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LightNovelAvailableField
            // 
            this.LightNovelAvailableField.AccessibleDescription = "Light Novels";
            this.LightNovelAvailableField.AccessibleName = "LightNovelField";
            this.LightNovelAvailableField.FormattingEnabled = true;
            this.LightNovelAvailableField.HorizontalScrollbar = true;
            this.LightNovelAvailableField.Location = new System.Drawing.Point(393, 42);
            this.LightNovelAvailableField.Name = "LightNovelAvailableField";
            this.LightNovelAvailableField.Size = new System.Drawing.Size(217, 94);
            this.LightNovelAvailableField.TabIndex = 0;
            // 
            // LightNovelListLabel
            // 
            this.LightNovelListLabel.AutoSize = true;
            this.LightNovelListLabel.Location = new System.Drawing.Point(390, 26);
            this.LightNovelListLabel.Name = "LightNovelListLabel";
            this.LightNovelListLabel.Size = new System.Drawing.Size(77, 13);
            this.LightNovelListLabel.TabIndex = 1;
            this.LightNovelListLabel.Text = "LightNovel List";
            this.LightNovelListLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SupportedPageList
            // 
            this.SupportedPageList.FormattingEnabled = true;
            this.SupportedPageList.HorizontalScrollbar = true;
            this.SupportedPageList.Location = new System.Drawing.Point(158, 42);
            this.SupportedPageList.Name = "SupportedPageList";
            this.SupportedPageList.Size = new System.Drawing.Size(217, 94);
            this.SupportedPageList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " Supported LightNovel Pages";
            // 
            // searchpage_btn
            // 
            this.searchpage_btn.Location = new System.Drawing.Point(13, 42);
            this.searchpage_btn.Name = "searchpage_btn";
            this.searchpage_btn.Size = new System.Drawing.Size(124, 36);
            this.searchpage_btn.TabIndex = 4;
            this.searchpage_btn.Text = "Search Pages";
            this.searchpage_btn.UseVisualStyleBackColor = true;
            this.searchpage_btn.Click += new System.EventHandler(this.searchpage_btn_Click);
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(12, 93);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(124, 36);
            this.download_btn.TabIndex = 5;
            this.download_btn.Text = "Download LN";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // LightNovelDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 154);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.searchpage_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupportedPageList);
            this.Controls.Add(this.LightNovelListLabel);
            this.Controls.Add(this.LightNovelAvailableField);
            this.Name = "LightNovelDownloadForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.LightNovelDownloadForm_Load);
            this.Resize += new System.EventHandler(this.LightNovelDownloadForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox LightNovelAvailableField;
        private System.Windows.Forms.Label LightNovelListLabel;
        private System.Windows.Forms.CheckedListBox SupportedPageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchpage_btn;
        private System.Windows.Forms.Button download_btn;
    }
}

