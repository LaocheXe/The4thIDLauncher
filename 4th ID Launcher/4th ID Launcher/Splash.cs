// Form: Splash
// Name: Splash Screen
// Program: 4th ID Launcher
//
// Decription: This is the Splash Screen, this will display first on a timer, allows the main launcher to load up.
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4th_ID_Launcher
{
    public partial class Splash : Form
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

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void Splash_Load(object sender, EventArgs e)
        {

        lblVer.Text = String.Format("Beta Version: {0}", AssemblyVersion);
         
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            prgbProgress.Increment(1);
            if (prgbProgress.Value == 500) tmrTimer.Stop();

        }
    }
}
