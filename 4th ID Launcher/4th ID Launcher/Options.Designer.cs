namespace USJFCOM_Launcher
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.txtArmap = new System.Windows.Forms.TextBox();
            this.grpArma3path = new System.Windows.Forms.GroupBox();
            this.btnA3browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpArma3path.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArmap
            // 
            this.txtArmap.Location = new System.Drawing.Point(6, 44);
            this.txtArmap.Name = "txtArmap";
            this.txtArmap.Size = new System.Drawing.Size(380, 20);
            this.txtArmap.TabIndex = 0;
            // 
            // grpArma3path
            // 
            this.grpArma3path.BackColor = System.Drawing.Color.Transparent;
            this.grpArma3path.Controls.Add(this.btnA3browse);
            this.grpArma3path.Controls.Add(this.label1);
            this.grpArma3path.Controls.Add(this.txtArmap);
            this.grpArma3path.ForeColor = System.Drawing.Color.White;
            this.grpArma3path.Location = new System.Drawing.Point(29, 12);
            this.grpArma3path.Name = "grpArma3path";
            this.grpArma3path.Size = new System.Drawing.Size(392, 266);
            this.grpArma3path.TabIndex = 1;
            this.grpArma3path.TabStop = false;
            this.grpArma3path.Text = "Arma 3 Settings";
            // 
            // btnA3browse
            // 
            this.btnA3browse.BackColor = System.Drawing.Color.Transparent;
            this.btnA3browse.BackgroundImage = global::USJFCOM_Launcher.Properties.Resources.Button_nonhover;
            this.btnA3browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnA3browse.FlatAppearance.BorderSize = 0;
            this.btnA3browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA3browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA3browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.btnA3browse.Location = new System.Drawing.Point(286, 70);
            this.btnA3browse.Name = "btnA3browse";
            this.btnA3browse.Size = new System.Drawing.Size(100, 40);
            this.btnA3browse.TabIndex = 3;
            this.btnA3browse.Text = "Browse";
            this.btnA3browse.UseVisualStyleBackColor = false;
            this.btnA3browse.Click += new System.EventHandler(this.btnA3browse_Click);
            this.btnA3browse.MouseEnter += new System.EventHandler(this.btnA3browse_MouseEnter);
            this.btnA3browse.MouseLeave += new System.EventHandler(this.btnA3browse_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Arma 3 Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Arma3.exe";
            this.openFileDialog1.Filter = "amra3.exe|arma3.exe";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::USJFCOM_Launcher.Properties.Resources.Button_nonhover;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.btnSave.Location = new System.Drawing.Point(178, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::USJFCOM_Launcher.Properties.Resources.Button_nonhover;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.btnCancel.Location = new System.Drawing.Point(284, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BackgroundImage = global::USJFCOM_Launcher.Properties.Resources.Button_nonhover;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.btnOk.Location = new System.Drawing.Point(72, 298);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 40);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.btnOk_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.btnOk_MouseLeave);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::USJFCOM_Launcher.Properties.Resources.stripes;
            this.ClientSize = new System.Drawing.Size(489, 366);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpArma3path);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Settings - UNITED STATES JOINT FORCES COMMAND";
            this.Load += new System.EventHandler(this.Options_Load);
            this.grpArma3path.ResumeLayout(false);
            this.grpArma3path.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtArmap;
        private System.Windows.Forms.GroupBox grpArma3path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnA3browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}