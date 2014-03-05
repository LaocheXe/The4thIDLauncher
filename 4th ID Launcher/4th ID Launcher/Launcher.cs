// Form: Launcher
// Name: Launcher MainForm
// Program: 4th ID Launcher
//
// Decription: This is the Launcher program, main form - will launch the game
//

using USJFCOM_Launcher.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4th_ID_Launcher
{
    public partial class Launcher : Form
    {
        // Public const for movement
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        // Import DLL For Movement
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Start of Checking if windows os is 64Bit or 32Bit
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process([In] IntPtr hProcess, [Out] out bool lpSystemInfo);
        // bool Is 64Bit version of Windows
        public bool Is64Bit()
        {
            bool retVal;
            IsWow64Process(Process.GetCurrentProcess().Handle, out retVal);
            return retVal;
        }

        public Launcher()
        {
            // Splash Screen Start
            Thread splash = new Thread(new ThreadStart(SplashScreen));
            splash.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            splash.Abort();
            // Splash Screen Stop
        }

        private void Launcher_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            // Load Settings
            chkPlayClose.Checked = Settings.Default.CloseLS;
         //   ckbxlSMods.CheckedItems = Settings.Default.ModsLS;
          //  rdoMod.Checked = (Settings.Default.Withmods = ModsSelect.Mod);
          //  rdoNomod.Checked = (Settings.Default.Withmods = ModsSelect.Nomods);


            //Display Current Version
            lblVerson.Text = String.Format("Beta Version: {0}", AssemblyVersion);

            // Start looking for Mods
            string arma3Path = Settings.Default["ArmaPath"].ToString();
            string armaPath;
            string modName = "@*";

            if (arma3Path == null)
            {
                armaPath = arma3Path.Substring(0, arma3Path.Length - "arma3.exe".Length);
            }
            else
            {
                if (Is64Bit())
                {
                    // If it is 64bit then armaPath is this
                    armaPath = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
                }
                else
                {
                    // Else is this armaPath
                    armaPath = @"C:\Program Files\Steam\steamapps\common\Arma 3\";
                }
            }



            try
            {
                // This list the current folders that start with an @ in front of it - For Mod Folders
                string[] dirs = Directory.GetDirectories(armaPath, modName);

                // For each modName @ - display them in the CheckBoxList
                for (int i = 0; i < dirs.Length; i++)
                {
                    string folderName = Path.GetFileName(dirs[i]);
                    ckbxlSMods.Items.Add(folderName, false);
                }

                // Check if Items are being listed
                if (ckbxlSMods.Items != null)
                {
                    // If yes then enable Refresh button
                    btnRefresh.Enabled = true;
                }
                else
                {
                    // If not then disable the button
                    btnRefresh.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("\r\nFile Path Not Found.\r\n");
            }
        }

        // Splash Screen void
        public void SplashScreen()
        {
            // Start Splash Screen
            Application.Run(new Splash());
        }

        // Exit Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(81, 201, 224);
            btnClose.BackgroundImage = USJFCOM_Launcher.Properties.Resources.CloseButton_hover;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(30, 32, 37);
            btnClose.BackgroundImage = USJFCOM_Launcher.Properties.Resources.CloseButton;
        }

        // About Box Button - Show About Box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aAbout = new AboutBox();
            aAbout.Show();
        }

        // File-Exit button - Exit the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Restart Button - Restarts the application
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Browser Form - Show The Browser
        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Browser aBrowser = new Browser();
                aBrowser.web4thIDSite.Navigate("http://usjfc.us");
                aBrowser.Show();
        }

        // Support Button - Link to website
        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Browser bBrowser = new Browser();
             bBrowser.web4thIDSite.Navigate("http://usjfc.us/phpbb/viewforum.php?f=34");
             bBrowser.Show(); 
        }

        // Refresh Button - Refrest current installed mods in checklistbox
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string arma3Path = Settings.Default["ArmaPath"].ToString();
            string armaPath;
            string modName = "@*";

            if (arma3Path == null)
            {
                armaPath = arma3Path.Substring(0, arma3Path.Length - "arma3.exe".Length);
            }
            else
            {
                if (Is64Bit())
                {
                    // If it is 64bit then armaPath is this
                    armaPath = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
                }
                else
                {
                    // Else is this armaPath
                    armaPath = @"C:\Program Files\Steam\steamapps\common\Arma 3\";
                }
            }

            try
            {

                // This list the current folders that start with an @ in front of it - For Mod Folders
                string[] dirs = Directory.GetDirectories(armaPath, modName);
                // Clear Current listed mods
                ckbxlSMods.Items.Clear();
                // For each modName @ - display them in the CheckBoxList
                for (int i = 0; i < dirs.Length; i++)
                {
                    string folderName = Path.GetFileName(dirs[i]);
                    ckbxlSMods.Items.Add(folderName, false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("\r\nFile path not detected.\r\n");
            }
        }

        // Start Launcher
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            // Start Selection
            string arma3Path = Settings.Default["ArmaPath"].ToString();
            string selectedMods = string.Empty;

            if (arma3Path == null)
            {
                // Error Message
                MessageBox.Show("Error: 107\nGame Path Not Detected, Go to settings and select your arma 3 path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Is64Bit()) // Is 64Bit
                    arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\arma3.exe";
                else
                    // 32Bit Version
                    arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\arma3.exe";
            }


            // Start Checking if arma3Path currently exsist
            if (File.Exists(arma3Path))
            {
                // Check Box List if not Null then selectedMods
                if (ckbxlSMods.CheckedItems != null)
                {
                    foreach (string s in ckbxlSMods.CheckedItems)
                        selectedMods += "-nosplash -noLods -mod=" + s + "; ";

                }
                else
                {
                    selectedMods = "-nosplash -noLogs";
                }

                // If No Mod Radio Button is Checked
                if (rdoNomod.Checked)
                {
                    // Start Game
                    Process.Start(arma3Path);
                }

                // If With Mod Radio Button is Checked
                else if (rdoMod.Checked)
                {
                        // Start Game With Mods
                        ProcessStartInfo info = new ProcessStartInfo();
                        info.FileName = arma3Path;
                        // Start game with mods added to the line
                        info.Arguments = selectedMods;
                        Process.Start(info);
                }
            }
            else
            {
                // Error Message
                MessageBox.Show("Error: 100\nGame Path Not Detected, Go to settings and select your arma 3 path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If Close Launcher was selected - When game launches the launcher will close
            if (chkPlayClose.Checked)
            {
                this.Close();
            }
        }
        // End Play/Launch Button

        private void downloadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Downloads aDownloads = new Downloads();
            aDownloads.ShowDialog();
        }

        // FAQ MenuItem
        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser cBrowser = new Browser();
            cBrowser.web4thIDSite.Navigate("http://usjfc.us/phpbb/viewtopic.php?f=34&t=14");
            cBrowser.Show();
        }

        // Minimize Button
        private void btnMinie_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinie_MouseEnter(object sender, EventArgs e)
        {
            btnMinie.ForeColor = Color.FromArgb(81, 201, 224);
            btnMinie.BackgroundImage = USJFCOM_Launcher.Properties.Resources.MiniButton_hover;
        }

        private void btnMinie_MouseLeave(object sender, EventArgs e)
        {
            btnMinie.ForeColor = Color.FromArgb(30, 32, 37);
            btnMinie.BackgroundImage = USJFCOM_Launcher.Properties.Resources.MiniButton;
        }

        private void launcherSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USJFCOM_Launcher.Options nSettings = new USJFCOM_Launcher.Options();
            nSettings.ShowDialog();
        }

        private void chkPlayClose_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.CloseLS = chkPlayClose.Checked;
            Settings.Default.Save();
        }        
    }
}
