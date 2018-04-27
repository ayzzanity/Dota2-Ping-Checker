using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingTool
{
    public partial class frmPingTool : Form
    {
        public frmPingTool()
        {
            InitializeComponent();
        }

        private void btnUSEast_Click(object sender, EventArgs e)
        {
            Process.Start("ping.exe", "208.78.164.1 -t");
        }

        private void btnUSWest_Click(object sender, EventArgs e)
        {
            Process.Start("ping.exe", "192.69.96.1 -t");
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            Process.Start("ping.exe", "209.197.29.1 -t");
        }

        private void btnEUEast_Click(object sender, EventArgs e)
        {
            Process.Start("ping.exe", "146.66.155.1 -t");
        }

        private void btnEUWest_Click(object sender, EventArgs e)
        {
            Process.Start("ping.exe", "146.66.152.1 -t");
        }

        private void btnRussia_Click(object sender, EventArgs e)
        {
            Process.Start("ping.exe", "146.66.156.1 -t");
        }

        private void btnSEA_Click(object sender, EventArgs e)
        {
            Process.Start("ping.exe", "103.28.54.1 -t");
        }

        private void btnAfrica_Click(object sender, EventArgs e)
        {
            Process.Start("ping.exe", "197.80.200.1 -t");
        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            Process.Start("ping.exe", "103.10.125.1 -t");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
