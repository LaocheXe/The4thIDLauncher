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
using System.Windows;
using System.Windows.Forms;


namespace _4th_ID_Launcher
{
    public partial class Downloads : Form
    {
        Stopwatch sw1 = new Stopwatch();

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

        public Downloads()
        {
            InitializeComponent();
        }

        private void Downloads_Load(object sender, EventArgs e)
        {
            if (Is64Bit())// Is 64Bit
                arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
            else
                // 32Bit Version
                arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\";

            string mod4thid = arma3Path + @"@4thID.zip";

            if (File.Exists(mod4thid))
            {
                btnUnZip1.Enabled = true;
                btnDownload1.Enabled = false;
            }

        }


        private void btnDownload3_Click(object sender, EventArgs e)
        {
            Process.Start("https://dl.dropboxusercontent.com/s/gb3gjxjtxh28dg3/ACRE.zip?dl=1&token_hash=AAGK7K1_xNi_MR6_m_p1fmyRhTFcC7vIPbxOmD5xaVE9EA");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDownload2_Click(object sender, EventArgs e)
        {
            Process.Start("https://dl.dropboxusercontent.com/s/myv1aqjj5ldf7s7/CBA.zip?dl=1&token_hash=AAHhHXFrryV_bhOvwTJkJObNYz5Nh4f-w62krlDguwOz-g");
        }

        private void btnDownload1_Click(object sender, EventArgs e)
        {
            //cts = new CancellationTokenSource();

            if (Is64Bit())// Is 64Bit
                arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
            else
                // 32Bit Version
                arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\";

            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
           // webClient.DownloadCancelled += new CancelEventHandler(DownloadCancelled);

            try
            {
                webClient.DownloadFileAsync(new Uri("https://dl.dropboxusercontent.com/s/wx0v6jd6f55xrfb/4thID.zip?dl=1&token_hash=AAHt9NURsrmqsublmI9fHVoM5NSzpfLcFRw2iUWOiaizrw"), arma3Path + @"@4thID.zip");
                sw1.Start();
                btnDownload1.Enabled = false;
                btnCancel1.Enabled = true;
                btnDownload1.Text = "Downloading...";
            }
            catch (Exception)
            {
                MessageBox.Show("\r\nDownload failed.\r\n");
            }

        //    cts = null;
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            prg4thIDmd.Value = e.ProgressPercentage;

            lblSpeed1.Text = string.Format("Speed: {0} kb/s", (e.BytesReceived / 1024d / sw1.Elapsed.TotalSeconds).ToString("0.00"));

            lblPrecentage1.Text = e.ProgressPercentage.ToString() + "%";

            lblDownloaded1.Text = string.Format("Downloaded: {0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
            (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {

            if (Is64Bit())// Is 64Bit
                arma3Path = @"C:\Program Files (x86)\Steam\steamapps\common\Arma 3\";
            else
                // 32Bit Version
                arma3Path = @"C:\Program Files\Steam\steamapps\common\Arma 3\";

            sw1.Reset();

            btnDownload1.Enabled = true;
            btnCancel1.Enabled = false;
            btnDownload1.Text = "Download";

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



        private void btnCancel1_Click(object sender, EventArgs e)
        {
            //CancelAsync()

            btnCancel1.Enabled = false;
            btnDownload1.Enabled = true;


        }

        private void btnUnZip1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(arma3Path);

            foreach (FileInfo fi in di.GetFiles("@4thID.zip"))
            {
                Decompress(fi);
            }

        }

    }
}
