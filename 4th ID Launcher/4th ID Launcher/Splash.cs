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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4th_ID_Launcher
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
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

        lblVer.Text = String.Format("Version: {0} Beta", AssemblyVersion);
         
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            prgbProgress.Increment(1);
            if (prgbProgress.Value == 500) tmrTimer.Stop();

        }

        private void prgbProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
