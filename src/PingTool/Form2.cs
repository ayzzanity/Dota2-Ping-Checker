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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void lnkTwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.twitch.tv/ezznoobnetwork");
        }

        private void lnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("github.com/ezzredfox/");
        }

        private void lnkYt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.youtube.com/channel/UCa_0_4SiKpvU0MhwRdEGouw");
        }

        private void lnkEzz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.facebook.com/alw003");
        }
    }
}
