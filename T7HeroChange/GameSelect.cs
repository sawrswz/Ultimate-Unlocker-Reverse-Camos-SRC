using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.Net.NetworkInformation;
using Memory;
using System.Runtime.InteropServices;
using DarkUI.Collections;
using DarkUI.Config;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Forms;
using DarkUI.Renderers;
using IW8NameChange;
using T8ZMPrivate;
using T7HeroChange;
using System.Reflection;

namespace T8ZMPrivate
{
    public partial class GameSelect : DarkForm
    {
        public GameSelect()
        {
            InitializeComponent();
            string randomTitle = (RandomUtil.GetRandomString());
            this.Text = randomTitle;
        }

        /// Random string generators.
        static class RandomUtil
        {
            public static string GetRandomString()
            {
                string path = Path.GetRandomFileName();
                path = path.Replace(".", ""); // Remove period.
                return path;
            }
        }

        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();

        public string ProcCheck;
        public string ProcCheck1;
        public string ProcCheck2;

        private void GameSelect_Load(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("ModernWarfare");
            if (pname.Length == 0)
            {
                DarkMessageBox.ShowError("Please open Modern Warfare before opening.", "Error");
                System.Windows.Forms.Application.Exit();
                Process.GetCurrentProcess().Kill();
                Environment.FailFast("wz not detected, exit");
            }
            else
            {
                Opacity = 0;      //first the opacity is 0

                t1.Interval = 1;  //we'll increase the opacity every 10ms
                t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
                t1.Start();
            }
        }

        void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.03;
        }

        private void GameSelect_Shown(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            DarkMessageBox.ShowError("Unavailable in this version.", "Error");
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            DarkMessageBox.ShowError("Unavailable in this version.", "Error");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
