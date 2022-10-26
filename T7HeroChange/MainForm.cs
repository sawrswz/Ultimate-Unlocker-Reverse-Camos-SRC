//Call of Duty: Modern Warfare - Camo/Name/Etc Utility PUBLIC
//By VrTx Galaxy | GalaxyYT | JaxonKEKW on MPGH and UnKnoWnCheaTs and everywhere else

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
using IW8NameChange;
using T8ZMPrivate;

namespace T7HeroChange
{
    public partial class MainForm : DarkForm
    {
        public Mem m = new Mem();
        public MainForm()
        {
            InitializeComponent();
            string randomTitle = (RandomUtil.GetRandomString());
            //this.Text = randomTitle;

            //Sets the default color and text for the process checker
            ProcOpenLabel.ForeColor = Color.Red;
            ProcOpenLabel.Text = "Not Found!";

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

        bool ProcOpen = false;

        // - fade in
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        private void MainForm_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 1;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }
        void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.03;
        }
        // --- fade in

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("ModernWarfare"); // Open process

            Thread.Sleep(600);
            BGWorker.ReportProgress(0);
            {
                // PROCESS PRIORITY
                using (Process p = Process.GetCurrentProcess())           //set process priority to high
                    p.PriorityClass = ProcessPriorityClass.High;          //set process priority to high
                // PROCESS PRIORITY
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)       //set process priority to high
        {                                                             //set process priority to high
            BGWorker.RunWorkerAsync();                               //set process priority to high
            using (Process p = Process.GetCurrentProcess())           //set process priority to high
                p.PriorityClass = ProcessPriorityClass.High;          //set process priority to high
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen) // if process is open
            {
                ProcOpenLabel.ForeColor = Color.DarkCyan;
                ProcOpenLabel.Text = "Found!"; // update process status
                ProcOpenLabel.Left = 338; // shift left
            }
            else
            {
                ProcOpenLabel.ForeColor = Color.Red;         // else, keep not found status
                ProcOpenLabel.Text = "Not Found!";           // else, keep not found status
                ProcOpenLabel.Left = 306;                    // else, keep not found status
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void DarkButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog(); // Shows Form1 (about)
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            Process.GetCurrentProcess().Kill();
            Environment.FailFast("exit");
        }

        private void ApplyMW_Click(object sender, EventArgs e)
        {
            if (MWCamoCombobox.Text == "")
            {
                DarkMessageBox.ShowError("Please select a camo first.", "Error");
            }
            else if (MWCamoCombobox.Text == "MW Gold")
            {
                
                m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 31 31 61 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Gold.", "Success");
            }
            else if (MWCamoCombobox.Text == "MW Platinum")
            {
                
                m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 31 31 62 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Platinum.", "Success");
            }
            else if (MWCamoCombobox.Text == "MW Damascus")
            {
                
                m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 31 31 63 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Damascus.", "Success");
            }
            else if (MWCamoCombobox.Text == "MW Obsidian")
            {
                
                m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 31 31 64 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Obsidian.", "Success");
            }
            else if (MWCamoCombobox.Text == "CW Gold")
            {
                
                m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 6D 61 73 74 65 72 79 5F 67 6F 6C 64 00 41 54 54 45 52 00 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to CW Gold.", "Success");
            }
            else if (MWCamoCombobox.Text == "CW Diamond")
            {
                
                m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 6D 61 73 74 65 72 79 5F 64 69 61 6D 6F 6E 64 00 45 52 00 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to CW Diamond.", "Success");
            }
            else if (MWCamoCombobox.Text == "CW DM Ultra")
            {
                
                m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 6D 61 73 74 65 72 79 5F 64 61 72 6B 6D 61 74 74 65 72 00 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to CW DM Ultra.", "Success");
            }
            else if (MWCamoCombobox.Text == "CW Golden Viper")
            {
                DarkMessageBox.ShowWarning("CW Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT");
                m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 67 6F 6C 64 00 41 54 54 45 52 00 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray Paint' category and equip 'Desert Snake' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT");
                DarkMessageBox.ShowWarning("The camo should now be on the gun, but it will not stick and you can't save it as a blueprint yet. So, simply copy and paste the class you are doing this in, and the camo should be permanent in the pasted class. Press Ok once you have pasted the class.", "Warning | IMPORTANT");
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to CW Golden Viper. Now, RESET CAMOS TO DEFAULT OR YOU MAY NOT BE ABLE TO JOIN GAMES.", "Success");
            }
            else if (MWCamoCombobox.Text == "CW Plague Diamond")
            {
                DarkMessageBox.ShowWarning("CW Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT");
                m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 64 69 61 6D 6F 6E 64 00 45 52 00 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray Paint' category and equip 'Desert Snake' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT");
                DarkMessageBox.ShowWarning("The camo should now be on the gun, but it will not stick and you can't save it as a blueprint yet. So, simply copy and paste the class you are doing this in, and the camo should be permanent in the pasted class. Press Ok once you have pasted the class.", "Warning | IMPORTANT");
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to CW Plague Diamond. Now, RESET CAMOS TO DEFAULT OR YOU MAY NOT BE ABLE TO JOIN GAMES.", "Success");
            }
            else if (MWCamoCombobox.Text == "CW Dark Aether")
            {
                DarkMessageBox.ShowWarning("CW Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT");
                m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 64 61 72 6B 6D 61 74 74 65 72 00 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray Paint' category and equip 'Desert Snake' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT");
                DarkMessageBox.ShowWarning("The camo should now be on the gun, but it will not stick and you can't save it as a blueprint yet. So, simply copy and paste the class you are doing this in, and the camo should be permanent in the pasted class. Press Ok once you have pasted the class.", "Warning | IMPORTANT");
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to CW Dark Aether. Now, RESET CAMOS TO DEFAULT OR YOU MAY NOT BE ABLE TO JOIN GAMES.", "Success");
            }
        }

        private void ResetMW_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+147E9598,28,A97", "bytes", "63 61 6D 6F 5F 30 31 61 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
            DarkMessageBox.ShowInformation("MW Camos reset successfully.", "Success");
        }

        private void ApplyCW_Click(object sender, EventArgs e)
        {
            if (CWCamoCombobox.Text == "")
            {
                DarkMessageBox.ShowError("Please select a camo first.", "Error");
            }
            else if (CWCamoCombobox.Text == "MW Gold")
            {

                m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6d 6f 5f 31 31 61 00 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32");
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to MW Gold.", "Success");
            }
            else if (CWCamoCombobox.Text == "MW Platinum")
            {

                m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6d 6f 5f 31 31 62 00 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32");
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to MW Platinum.", "Success");
            }
            else if (CWCamoCombobox.Text == "MW Damascus")
            {

                m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6d 6f 5f 31 31 63 00 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32");
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to MW Damascus.", "Success");
            }
            else if (CWCamoCombobox.Text == "MW Obsidian")
            {

                m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6d 6f 5f 31 31 64 00 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32");
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to MW Obsidian.", "Success");
            }
            else if (CWCamoCombobox.Text == "CW Gold")
            {

                m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6d 6f 5f 6d 70 5f 74 39 6d 61 73 74 65 72 79 5f 67 6f 6c 64 00");
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to CW Gold.", "Success");
            }
            else if (CWCamoCombobox.Text == "CW Diamond")
            {

                m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6d 6f 5f 6d 70 5f 74 39 6d 61 73 74 65 72 79 5f 64 69 61 6d 6f 6e 64 00");
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to CW Diamond.", "Success");
            }
            else if (CWCamoCombobox.Text == "CW DM Ultra")
            {

                m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6d 6f 5f 6d 70 5f 74 39 6d 61 73 74 65 72 79 5f 64 61 72 6b 6d 61 74 74 65 72 00");
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to CW DM Ultra.", "Success");
            }
            else if (CWCamoCombobox.Text == "CW Golden Viper")
            {
                DarkMessageBox.ShowWarning("CW Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT");
                m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6d 6f 5f 7a 6d 5f 74 39 6d 61 73 74 65 72 79 5f 67 6f 6c 64 00");
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray' category and equip 'Shards' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT");
                DarkMessageBox.ShowWarning("The camo should now be on the gun, but it will not stick and you can't save it as a blueprint yet. So, simply copy and paste the class you are doing this in, and the camo should be permanent in the pasted class. Press Ok once you have pasted the class.", "Warning | IMPORTANT");
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to CW Golden Viper. Now, RESET CAMOS TO DEFAULT OR YOU MAY NOT BE ABLE TO JOIN GAMES.", "Success");
            }
            else if (CWCamoCombobox.Text == "CW Plague Diamond")
            {
                DarkMessageBox.ShowWarning("CW Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT");
                m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6d 6f 5f 7a 6d 5f 74 39 6d 61 73 74 65 72 79 5f 64 69 61 6d 6f 6e 64 00");
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray' category and equip 'Shards' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT");
                DarkMessageBox.ShowWarning("The camo should now be on the gun, but it will not stick and you can't save it as a blueprint yet. So, simply copy and paste the class you are doing this in, and the camo should be permanent in the pasted class. Press Ok once you have pasted the class.", "Warning | IMPORTANT");
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to CW Plague Diamond. Now, RESET CAMOS TO DEFAULT OR YOU MAY NOT BE ABLE TO JOIN GAMES.", "Success");
            }
            else if (CWCamoCombobox.Text == "CW Dark Aether")
            {
                DarkMessageBox.ShowWarning("CW Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT");
                m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6d 6f 5f 7a 6d 5f 74 39 6d 61 73 74 65 72 79 5f 64 61 72 6b 6d 61 74 74 65 72 00");
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray' category and equip 'Shards' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT");
                DarkMessageBox.ShowWarning("The camo should now be on the gun, but it will not stick and you can't save it as a blueprint yet. So, simply copy and paste the class you are doing this in, and the camo should be permanent in the pasted class. Press Ok once you have pasted the class.", "Warning | IMPORTANT");
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to CW Dark Aether. Now, RESET CAMOS TO DEFAULT OR YOU MAY NOT BE ABLE TO JOIN GAMES.", "Success");
            }
        }

        private void ResetCW_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+147E9598,28,817C0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32");
            DarkMessageBox.ShowInformation("CW Camos reset successfully.", "Success");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://linktr.ee/JaxonKEKW");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://youtu.be/t19NVMWw8hk");
        }
    }
}