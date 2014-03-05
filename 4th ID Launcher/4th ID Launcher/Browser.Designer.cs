namespace _4th_ID_Launcher
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.web4thIDSite = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // web4thIDSite
            // 
            this.web4thIDSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web4thIDSite.Location = new System.Drawing.Point(0, 0);
            this.web4thIDSite.MinimumSize = new System.Drawing.Size(20, 20);
            this.web4thIDSite.Name = "web4thIDSite";
            this.web4thIDSite.Size = new System.Drawing.Size(1424, 682);
            this.web4thIDSite.TabIndex = 0;
            this.web4thIDSite.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 682);
            this.Controls.Add(this.web4thIDSite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser";
            this.Text = "Browser - UNITED STATES JOINT FORCES COMMAND";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser web4thIDSite;

    }
}