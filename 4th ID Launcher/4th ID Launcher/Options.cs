using USJFCOM_Launcher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USJFCOM_Launcher
{
    public partial class Options : Form
    {

        string dirName;
            public void GetFile()
            {
                DialogResult result;
                do
                {
                    result = openFileDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        txtArmap.Text = openFileDialog1.FileName;
                        dirName = System.IO.Path.GetDirectoryName(openFileDialog1.FileName) + "\\";
                        dirName = dirName.Replace("\\", "\\\\");
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                } while (result != DialogResult.OK);
            }
        public Options()
        {
            InitializeComponent();
        }

        private void btnA3browse_MouseEnter(object sender, EventArgs e)
        {
            btnA3browse.BackgroundImage = USJFCOM_Launcher.Properties.Resources.Button2_hover;
        }

        private void btnA3browse_MouseLeave(object sender, EventArgs e)
        {
            btnA3browse.BackgroundImage = USJFCOM_Launcher.Properties.Resources.Button_nonhover;
        }

        private void btnA3browse_Click(object sender, EventArgs e)
        {
            GetFile();
        }

        // Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default["ArmaPath"] = txtArmap.Text;
        }
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = USJFCOM_Launcher.Properties.Resources.Button2_hover;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = USJFCOM_Launcher.Properties.Resources.Button_nonhover;
        }

        // Save Button
        private void btnOk_Click(object sender, EventArgs e)
        {
            //Settings.Default["ArmaPath"] = txtArmap.Text;
            Settings.Default["ArmaPath"] = txtArmap.Text;
            this.Close();
        }
        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.BackgroundImage = USJFCOM_Launcher.Properties.Resources.Button2_hover;
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackgroundImage = USJFCOM_Launcher.Properties.Resources.Button_nonhover;
        }

        // Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Settings.Default["ArmaPath"] = txtArmap.Text;
            this.Close();
        }
        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = USJFCOM_Launcher.Properties.Resources.Button2_hover;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = USJFCOM_Launcher.Properties.Resources.Button_nonhover;
        }

        // Load Options Form
        private void Options_Load(object sender, EventArgs e)
        {
            // Load User Save Settings for ArmaPath
            txtArmap.Text = Settings.Default["ArmaPath"].ToString();
            Settings.Default.Save();
        }
    }
}
