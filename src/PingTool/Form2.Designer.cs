namespace PingTool
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblD2 = new System.Windows.Forms.Label();
            this.grpBoxAbout = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkEzz = new System.Windows.Forms.LinkLabel();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.lnkTwitch = new System.Windows.Forms.LinkLabel();
            this.lnkYt = new System.Windows.Forms.LinkLabel();
            this.lblCheck = new System.Windows.Forms.Label();
            this.grpBoxAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblD2
            // 
            this.lblD2.AutoSize = true;
            this.lblD2.Font = new System.Drawing.Font("MOON GET!", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD2.Location = new System.Drawing.Point(16, 25);
            this.lblD2.Name = "lblD2";
            this.lblD2.Size = new System.Drawing.Size(355, 28);
            this.lblD2.TabIndex = 0;
            this.lblD2.Text = "Dota 2 - Simple Ping Checking Tool";
            // 
            // grpBoxAbout
            // 
            this.grpBoxAbout.Controls.Add(this.lblCheck);
            this.grpBoxAbout.Controls.Add(this.lnkTwitch);
            this.grpBoxAbout.Controls.Add(this.lnkYt);
            this.grpBoxAbout.Controls.Add(this.lnkGithub);
            this.grpBoxAbout.Controls.Add(this.lnkEzz);
            this.grpBoxAbout.Controls.Add(this.label1);
            this.grpBoxAbout.Controls.Add(this.pictureBox1);
            this.grpBoxAbout.Location = new System.Drawing.Point(13, 57);
            this.grpBoxAbout.Name = "grpBoxAbout";
            this.grpBoxAbout.Size = new System.Drawing.Size(358, 100);
            this.grpBoxAbout.TabIndex = 1;
            this.grpBoxAbout.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PingTool.Properties.Resources.Dota2;
            this.pictureBox1.Location = new System.Drawing.Point(31, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Created by:";
            // 
            // lnkEzz
            // 
            this.lnkEzz.AutoSize = true;
            this.lnkEzz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEzz.Location = new System.Drawing.Point(168, 25);
            this.lnkEzz.Name = "lnkEzz";
            this.lnkEzz.Size = new System.Drawing.Size(91, 20);
            this.lnkEzz.TabIndex = 2;
            this.lnkEzz.TabStop = true;
            this.lnkEzz.Text = "Ezz Redfox";
            this.lnkEzz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEzz_LinkClicked);
            // 
            // lnkGithub
            // 
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.Location = new System.Drawing.Point(91, 80);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(40, 13);
            this.lnkGithub.TabIndex = 3;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "GitHub";
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
            // 
            // lnkTwitch
            // 
            this.lnkTwitch.AutoSize = true;
            this.lnkTwitch.Location = new System.Drawing.Point(204, 80);
            this.lnkTwitch.Name = "lnkTwitch";
            this.lnkTwitch.Size = new System.Drawing.Size(39, 13);
            this.lnkTwitch.TabIndex = 3;
            this.lnkTwitch.TabStop = true;
            this.lnkTwitch.Text = "Twitch";
            this.lnkTwitch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTwitch_LinkClicked);
            // 
            // lnkYt
            // 
            this.lnkYt.AutoSize = true;
            this.lnkYt.Location = new System.Drawing.Point(144, 80);
            this.lnkYt.Name = "lnkYt";
            this.lnkYt.Size = new System.Drawing.Size(47, 13);
            this.lnkYt.TabIndex = 3;
            this.lnkYt.TabStop = true;
            this.lnkYt.Text = "Youtube";
            this.lnkYt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYt_LinkClicked);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(149, 61);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(35, 13);
            this.lblCheck.TabIndex = 4;
            this.lblCheck.Text = "Links:";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 169);
            this.Controls.Add(this.grpBoxAbout);
            this.Controls.Add(this.lblD2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            this.grpBoxAbout.ResumeLayout(false);
            this.grpBoxAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblD2;
        private System.Windows.Forms.GroupBox grpBoxAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkTwitch;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.LinkLabel lnkEzz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkYt;
        private System.Windows.Forms.Label lblCheck;
    }
}