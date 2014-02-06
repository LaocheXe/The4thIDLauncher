// Form: Launcher
// Name: Launcher MainForm
// Program: 4th ID Launcher
//
// Decription: This is the Launcher program, main form - will launch the game
//

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            Thread.Sleep(5000);
            InitializeComponent(); // Needed to work
            splash.Abort();
            // Splash Screen Stop
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
            //Display Current Version
            lblVerson.Text = String.Format("Beta Version: {0}", AssemblyVersion);



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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nothing
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

        // 
        private void modsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aAbout = new AboutBox();
            aAbout.Show();
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
            aBrowser.web4thIDSite.Navigate("http://4thid.us");
            aBrowser.Show();
        }

        // Support Button - Link to website
        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Browser bBrowser = new Browser();
             bBrowser.web4thIDSite.Navigate("http://4thid.us/forum/categories/general-support");
             bBrowser.Show(); 
        }

        // Refresh Button - Refrest current installed mods in checklistbox
        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        // Start Launcher
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            // List 64Bit or 32Bit Version
            string arma3Path;
            string selectedMods;

            if (Is64Bit()) // Is 64Bit
                arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\arma3.exe";
            else
                // 32Bit Version
                arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\arma3.exe";
            // Start Checking if arma3Path currently exsist
            if (File.Exists(arma3Path))
            {
                // If it does then start the launcher
                if (ckb4thID.Checked && !ckbCba3a.Checked)
                {
                    selectedMods = "-mod=@4thID;";
                }
                else if (ckbCba3a.Checked && !ckb4thID.Checked)
                {
                    selectedMods = "-mod=@CBA_A3;";
                }
                else if (ckb4thID.Checked && ckbCba3a.Checked)
                {
                    selectedMods = "-mod=@4thID; -mod=@CBA_A3;";
                }
                else
                {
                    selectedMods = "";
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
                    // Error Checking - If radio button is selected for mods but no mods are selected
                    if (!ckb4thID.Checked && !ckbCba3a.Checked)
                    {
                        // Error Message
                        MessageBox.Show("Error: 101\nNo Mods Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        // If nothing is wrong start the game
                    else
                    {
                        // Start Game With Mods
                        ProcessStartInfo info = new ProcessStartInfo();
                        info.FileName = arma3Path;
                        // Start game with mods added to the line
                        info.Arguments = selectedMods;
                        Process.Start(info);

                    }
                }
            }
            else
            {
                // Error Message
                MessageBox.Show("Error: 100\nGame Path Not Detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void rulesRegulationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void teamSpeakRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // FAQ MenuItem
        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser cBrowser = new Browser();
            cBrowser.web4thIDSite.Navigate("http://4thid.us/forum/discussion/75/frequently-asked-questions-faq");
            cBrowser.Show();
        }
        
    }
}
