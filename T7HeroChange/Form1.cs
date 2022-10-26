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
using Memory;
using System.Runtime.InteropServices;
using DarkUI.Collections;
using DarkUI.Config;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Forms;
using DarkUI.Renderers;

namespace IW8NameChange
{
    public partial class Form1 : DarkForm
    {
        public Form1()
        {
            InitializeComponent();
            string randomTitle = (RandomUtil.GetRandomString());
            this.Text = randomTitle;
            currentVersion.ForeColor = Color.White;
            credit.ForeColor = Color.White;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
