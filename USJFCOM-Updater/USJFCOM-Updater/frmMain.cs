using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

// https://docs.google.com/uc?export=download&id=
// So This is the ACRE Download Link Below
// https://docs.google.com/uc?export=download&id=0B3bZS-OYx2DLanBUVHVDVWFnSVU
//
// Alive Link
// http://dev.withsix.com/attachments/download/21631/@alive_0-5-6-1401291.7z

namespace USJFCOM_Updater
{
    public partial class frmMain : Form
    {
        // Generate StopWatch
        Stopwatch sw1 = new Stopwatch();

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

        string arma3Path;

        // bool Is 64Bit version of Windows
        public bool Is64Bit()
        {
            bool retVal;
            IsWow64Process(Process.GetCurrentProcess().Handle, out retVal);
            return retVal;
        }

        // Main Form
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // If zip files are in the folder then enable Unzip
            // Get File Path
            if (Is64Bit())// Is 64Bit
                arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
            else
                // 32Bit Version
                arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\";

            string modUSJFCOM = arma3Path + @"USJFCOM.zip";
            string modCBA = arma3Path + @"CBA.zip";
            string modALIVE = arma3Path + @"@alive_0-5-6-1401291.7z";
            string modACRE = arma3Path + @"ACRE.zip";

            if (File.Exists(modUSJFCOM))
            {
                btnUZusjfcom.Enabled = true;
            }
            if (File.Exists(modCBA))
            {
                btnUZcba.Enabled = true;
            }
            if (File.Exists(modALIVE))
            {
                btnUZalive.Enabled = true;
            }
            if (File.Exists(modACRE))
            {
                btnUZacre.Enabled = true;
            }

        }

        // USJFCOM Button
        private void btnUSJFCOM_MouseEnter(object sender, EventArgs e)
        {
            btnUSJFCOM.BackgroundImage = USJFCOM_Updater.Properties.Resources.Button2_hover;
        }

        private void btnUSJFCOM_MouseLeave(object sender, EventArgs e)
        {
            btnUSJFCOM.BackgroundImage = USJFCOM_Updater.Properties.Resources.Button_nonhover;
        }

        private void btnUSJFCOM_Click(object sender, EventArgs e)
        {

            if (Is64Bit())// Is 64Bit
                arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
            else
                // 32Bit Version
                arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\";

            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            try
            {
                webClient.DownloadFileAsync(new Uri("https://docs.google.com/uc?export=download&id=0B3bZS-OYx2DLVW5ub296VzMzM0U"), arma3Path + @"USJFCOM.zip");
                sw1.Start();
                btnUSJFCOM.Enabled = false;
                btnCBA.Enabled = false;
                btnAlive.Enabled = false;
                btnACRE.Enabled = false;
             //   btnUSJFCOM.Text = "Downloading...";
            }
            catch (Exception)
            {
                MessageBox.Show("\r\nDownload failed.\r\n");
            }
        }

        // CBA Button
        private void btnCBA_MouseEnter(object sender, EventArgs e)
        {
            btnCBA.BackgroundImage = USJFCOM_Updater.Properties.Resources.Button2_hover;
        }

        private void btnCBA_MouseLeave(object sender, EventArgs e)
        {
            btnCBA.BackgroundImage = USJFCOM_Updater.Properties.Resources.Button_nonhover;
        }

        private void btnCBA_Click(object sender, EventArgs e)
        {

            if (Is64Bit())// Is 64Bit
                arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
            else
                // 32Bit Version
                arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\";

            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            try
            {
                webClient.DownloadFileAsync(new Uri("https://docs.google.com/uc?export=download&id=0B3bZS-OYx2DLZHZSZGE4TUVXOUE"), arma3Path + @"CBA.zip");
                sw1.Start();
                btnUSJFCOM.Enabled = false;
                btnCBA.Enabled = false;
                btnAlive.Enabled = false;
                btnACRE.Enabled = false;
                //btnCBA.Text = "Downloading...";
            }
            catch (Exception)
            {
                MessageBox.Show("\r\nDownload failed.\r\n");
            }
        }

        // ACRE Button
        private void btnACRE_MouseEnter(object sender, EventArgs e)
        {
            btnACRE.BackgroundImage = Properties.Resources.Button2_hover;
        }

        private void btnACRE_MouseLeave(object sender, EventArgs e)
        {
            btnACRE.BackgroundImage = Properties.Resources.Button_nonhover;
        }

        private void btnACRE_Click(object sender, EventArgs e)
        {

            if (Is64Bit())// Is 64Bit
                arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
            else
                // 32Bit Version
                arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\";

            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            try
            {
                webClient.DownloadFileAsync(new Uri("https://docs.google.com/uc?export=download&id=0B3bZS-OYx2DLanBUVHVDVWFnSVU"), arma3Path + @"ACRE.zip");
                sw1.Start();
                btnUSJFCOM.Enabled = false;
                btnCBA.Enabled = false;
                btnAlive.Enabled = false;
                btnACRE.Enabled = false;
            //    btnUSJFCOM.Text = "Downloading...";
            }
            catch (Exception)
            {
                MessageBox.Show("\r\nDownload failed.\r\n");
            }
        }

        // ALIVE Button
        private void btnAlive_MouseEnter(object sender, EventArgs e)
        {
            btnAlive.BackgroundImage = Properties.Resources.Button2_hover;
        }

        private void btnAlive_MouseLeave(object sender, EventArgs e)
        {
            btnAlive.BackgroundImage = Properties.Resources.Button_nonhover;
        }

        private void btnAlive_Click(object sender, EventArgs e)
        {

            if (Is64Bit())// Is 64Bit
                arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
            else
                // 32Bit Version
                arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\";

            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            try
            {
                webClient.DownloadFileAsync(new Uri("http://dev.withsix.com/attachments/download/21631/@alive_0-5-6-1401291.7z"), arma3Path + @"@alive_0-5-6-1401291.7z");
                sw1.Start();
                btnUSJFCOM.Enabled = false;
                btnCBA.Enabled = false;
                btnAlive.Enabled = false;
                btnACRE.Enabled = false;
          //      btnUSJFCOM.Text = "Downloading...";
            }
            catch (Exception)
            {
                MessageBox.Show("\r\nDownload failed.\r\n");
            }
        }

        // Close Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.CloseButton_hover;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.CloseButton;
        }

        // Minimize Button
        private void btnMinie_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinie_MouseEnter(object sender, EventArgs e)
        {
            btnMinie.BackgroundImage = Properties.Resources.MiniButton_hover;
        }

        private void btnMinie_MouseLeave(object sender, EventArgs e)
        {
            btnMinie.BackgroundImage = Properties.Resources.MiniButton;
        }

        // USJFCOM Unzip Button
        private void btnUZusjfcom_Click(object sender, EventArgs e)
        {
           DirectoryInfo di = new DirectoryInfo(arma3Path);

            foreach (FileInfo fi in di.GetFiles("USJFCOM.zip"))
            {
                Decompress(fi);
            }
        }

        private void btnUZusjfcom_MouseEnter(object sender, EventArgs e)
        {
            btnUZusjfcom.BackgroundImage = Properties.Resources.MiniButton_hover;
        }

        private void btnUZusjfcom_MouseLeave(object sender, EventArgs e)
        {
            btnUZusjfcom.BackgroundImage = Properties.Resources.MiniButton;
        }

        // UCBA Unzip Button
        private void btnUZcba_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(arma3Path);

            foreach (FileInfo fi in di.GetFiles("CBA.zip"))
            {
                Decompress(fi);
            }
        }

        private void btnUZcba_MouseEnter(object sender, EventArgs e)
        {
            btnUZcba.BackgroundImage = Properties.Resources.MiniButton_hover;
        }

        private void btnUZcba_MouseLeave(object sender, EventArgs e)
        {
            btnUZcba.BackgroundImage = Properties.Resources.MiniButton;
        }

        // ALIVE Unzip Button
        private void btnUZalive_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(arma3Path);

            foreach (FileInfo fi in di.GetFiles("@alive_0-5-6-1401291.7z"))
            {
                Decompress(fi);
            }
        }

        private void btnUZalive_MouseEnter(object sender, EventArgs e)
        {
            btnUZalive.BackgroundImage = Properties.Resources.MiniButton_hover;
        }

        private void btnUZalive_MouseLeave(object sender, EventArgs e)
        {
            btnUZalive.BackgroundImage = Properties.Resources.MiniButton;
        }

        // ACRE Unzip Button
        private void btnUZacre_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(arma3Path);

            foreach (FileInfo fi in di.GetFiles("ACRE.zip"))
            {
                Decompress(fi);
            }
        }

        private void btnUZacre_MouseEnter(object sender, EventArgs e)
        {
            btnUZacre.BackgroundImage = Properties.Resources.MiniButton_hover;
        }

        private void btnUZacre_MouseLeave(object sender, EventArgs e)
        {
            btnUZacre.BackgroundImage = Properties.Resources.MiniButton;
        }

        // Progress Change
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarEx1.Value = e.ProgressPercentage;

            lblSpeed.Text = string.Format("Speed: {0} kb/s", (e.BytesReceived / 1024d / sw1.Elapsed.TotalSeconds).ToString("0.00"));

            lblPrecentage.Text = e.ProgressPercentage.ToString() + "%";

            lblDownload.Text = string.Format("Downloaded: {0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
            (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        // Completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {

            if (Is64Bit())// Is 64Bit
                arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
            else
                // 32Bit Version
                arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\";

            sw1.Reset();

            btnUSJFCOM.Enabled = true;
            btnCBA.Enabled = true;
            btnAlive.Enabled = true;
            btnACRE.Enabled = true;

            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                MessageBox.Show("Download Completed!");
            }
        }

        public static void Decompress(FileInfo fi)
        {
            using (FileStream inFile = fi.OpenRead())
            {
                string curFile = fi.FullName;
                string origName = curFile.Remove(curFile.Length - fi.Extension.Length);

                using (FileStream outFile = File.Create(origName))
                {
                    using (GZipStream Decompress = new GZipStream(inFile, CompressionMode.Decompress))
                    {
                        Decompress.CopyTo(outFile);

                        //lblDownloaded1.Text = string.Format(("Decompressed: {0}", fi.Name).ToString("0.00"));
                        Console.WriteLine("Decompressed: {0}", fi.Name);
                    }
                }
            }
        }


    }
}
