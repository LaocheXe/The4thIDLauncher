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
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lblVer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prgbProgress = new QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx();
            this.SuspendLayout();
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 50;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.BackColor = System.Drawing.Color.Transparent;
            this.lblVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(222)))), ((int)(((byte)(229)))));
            this.lblVer.Location = new System.Drawing.Point(239, 286);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(118, 20);
            this.lblVer.TabIndex = 4;
            this.lblVer.Text = "Beta Version:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::USJFCOM_Launcher.Properties.Resources.logos_animated_usjfcom_2;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 226);
            this.label1.TabIndex = 5;
            // 
            // prgbProgress
            // 
            this.prgbProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.prgbProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.prgbProgress.Location = new System.Drawing.Point(12, 238);
            this.prgbProgress.Name = "prgbProgress";
            this.prgbProgress.Size = new System.Drawing.Size(614, 23);
            this.prgbProgress.TabIndex = 6;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::USJFCOM_Launcher.Properties.Resources.stripes;
            this.ClientSize = new System.Drawing.Size(638, 356);
            this.ControlBox = false;
            this.Controls.Add(this.prgbProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVer);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Splash_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label label1;
        private QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx prgbProgress;

    }
}