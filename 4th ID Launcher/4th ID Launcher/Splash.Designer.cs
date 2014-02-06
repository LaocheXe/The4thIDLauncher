namespace _4th_ID_Launcher
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.prgbProgress = new System.Windows.Forms.ProgressBar();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lblVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prgbProgress
            // 
            this.prgbProgress.Location = new System.Drawing.Point(351, 142);
            this.prgbProgress.Name = "prgbProgress";
            this.prgbProgress.Size = new System.Drawing.Size(238, 23);
            this.prgbProgress.TabIndex = 3;
            this.prgbProgress.Click += new System.EventHandler(this.prgbProgress_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 40;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.ForeColor = System.Drawing.Color.White;
            this.lblVer.Location = new System.Drawing.Point(404, 327);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(67, 20);
            this.lblVer.TabIndex = 4;
            this.lblVer.Text = "Version:";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(939, 356);
            this.ControlBox = false;
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.prgbProgress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgbProgress;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lblVer;

    }
}