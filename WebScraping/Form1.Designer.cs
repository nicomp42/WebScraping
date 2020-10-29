namespace WebScraping
{
    partial class Form1
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
            this.wbScrape = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnScrape = new System.Windows.Forms.Button();
            this.txtHTML = new System.Windows.Forms.TextBox();
            this.lbLinks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // wbScrape
            // 
            this.wbScrape.Location = new System.Drawing.Point(21, 43);
            this.wbScrape.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbScrape.Name = "wbScrape";
            this.wbScrape.Size = new System.Drawing.Size(118, 264);
            this.wbScrape.TabIndex = 0;
            this.wbScrape.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbScrape_Navigated);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(21, 17);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(329, 20);
            this.txtURL.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(356, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnScrape
            // 
            this.btnScrape.Location = new System.Drawing.Point(449, 17);
            this.btnScrape.Name = "btnScrape";
            this.btnScrape.Size = new System.Drawing.Size(75, 23);
            this.btnScrape.TabIndex = 3;
            this.btnScrape.Text = "Scrape";
            this.btnScrape.UseVisualStyleBackColor = true;
            this.btnScrape.Click += new System.EventHandler(this.btnScrape_Click);
            // 
            // txtHTML
            // 
            this.txtHTML.Location = new System.Drawing.Point(21, 329);
            this.txtHTML.Multiline = true;
            this.txtHTML.Name = "txtHTML";
            this.txtHTML.ReadOnly = true;
            this.txtHTML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHTML.Size = new System.Drawing.Size(491, 71);
            this.txtHTML.TabIndex = 4;
            this.txtHTML.WordWrap = false;
            // 
            // lbLinks
            // 
            this.lbLinks.FormattingEnabled = true;
            this.lbLinks.Location = new System.Drawing.Point(156, 46);
            this.lbLinks.Name = "lbLinks";
            this.lbLinks.Size = new System.Drawing.Size(368, 251);
            this.lbLinks.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 412);
            this.Controls.Add(this.lbLinks);
            this.Controls.Add(this.txtHTML);
            this.Controls.Add(this.btnScrape);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.wbScrape);
            this.Name = "Form1";
            this.Text = "Web Scraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbScrape;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnScrape;
        private System.Windows.Forms.TextBox txtHTML;
        private System.Windows.Forms.ListBox lbLinks;
    }
}

