namespace T7HeroChange
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.ProcDefLabel = new DarkUI.Controls.DarkLabel();
            this.ProcOpenLabel = new DarkUI.Controls.DarkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPublicTab = new System.Windows.Forms.TabPage();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.ResetCW = new DarkUI.Controls.DarkButton();
            this.ResetMW = new DarkUI.Controls.DarkButton();
            this.ApplyCW = new DarkUI.Controls.DarkButton();
            this.CWCamoCombobox = new DarkUI.Controls.DarkComboBox();
            this.CWCamoLabel = new System.Windows.Forms.Label();
            this.ApplyMW = new DarkUI.Controls.DarkButton();
            this.MWCamoCombobox = new DarkUI.Controls.DarkComboBox();
            this.MWCamoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.MainPublicTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // ProcDefLabel
            // 
            this.ProcDefLabel.AutoSize = true;
            this.ProcDefLabel.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcDefLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ProcDefLabel.Location = new System.Drawing.Point(11, 214);
            this.ProcDefLabel.Name = "ProcDefLabel";
            this.ProcDefLabel.Size = new System.Drawing.Size(126, 19);
            this.ProcDefLabel.TabIndex = 27;
            this.ProcDefLabel.Text = "MW/WZ Process:";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcOpenLabel.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcOpenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ProcOpenLabel.Location = new System.Drawing.Point(306, 212);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(84, 21);
            this.ProcOpenLabel.TabIndex = 28;
            this.ProcOpenLabel.Text = "Not Found!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainPublicTab);
            this.tabControl1.Location = new System.Drawing.Point(-4, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 514);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 33;
            // 
            // MainPublicTab
            // 
            this.MainPublicTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MainPublicTab.Controls.Add(this.label2);
            this.MainPublicTab.Controls.Add(this.linkLabel2);
            this.MainPublicTab.Controls.Add(this.linkLabel1);
            this.MainPublicTab.Controls.Add(this.label1);
            this.MainPublicTab.Controls.Add(this.darkButton2);
            this.MainPublicTab.Controls.Add(this.ResetCW);
            this.MainPublicTab.Controls.Add(this.ResetMW);
            this.MainPublicTab.Controls.Add(this.ApplyCW);
            this.MainPublicTab.Controls.Add(this.CWCamoCombobox);
            this.MainPublicTab.Controls.Add(this.CWCamoLabel);
            this.MainPublicTab.Controls.Add(this.ApplyMW);
            this.MainPublicTab.Controls.Add(this.MWCamoCombobox);
            this.MainPublicTab.Controls.Add(this.MWCamoLabel);
            this.MainPublicTab.Location = new System.Drawing.Point(4, 22);
            this.MainPublicTab.Name = "MainPublicTab";
            this.MainPublicTab.Size = new System.Drawing.Size(412, 488);
            this.MainPublicTab.TabIndex = 1;
            this.MainPublicTab.Text = "Main - PUBLIC";
            // 
            // darkButton2
            // 
            this.darkButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.darkButton2.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton2.Location = new System.Drawing.Point(160, 163);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(90, 23);
            this.darkButton2.TabIndex = 57;
            this.darkButton2.Text = "Readme/About";
            this.darkButton2.Click += new System.EventHandler(this.DarkButton2_Click);
            // 
            // ResetCW
            // 
            this.ResetCW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ResetCW.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetCW.Location = new System.Drawing.Point(214, 115);
            this.ResetCW.Name = "ResetCW";
            this.ResetCW.Padding = new System.Windows.Forms.Padding(5);
            this.ResetCW.Size = new System.Drawing.Size(182, 42);
            this.ResetCW.TabIndex = 65;
            this.ResetCW.Text = "Reset to Default";
            this.ResetCW.Click += new System.EventHandler(this.ResetCW_Click);
            // 
            // ResetMW
            // 
            this.ResetMW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ResetMW.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetMW.Location = new System.Drawing.Point(12, 115);
            this.ResetMW.Name = "ResetMW";
            this.ResetMW.Padding = new System.Windows.Forms.Padding(5);
            this.ResetMW.Size = new System.Drawing.Size(185, 42);
            this.ResetMW.TabIndex = 64;
            this.ResetMW.Text = "Reset to Default";
            this.ResetMW.Click += new System.EventHandler(this.ResetMW_Click);
            // 
            // ApplyCW
            // 
            this.ApplyCW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ApplyCW.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyCW.Location = new System.Drawing.Point(214, 67);
            this.ApplyCW.Name = "ApplyCW";
            this.ApplyCW.Padding = new System.Windows.Forms.Padding(5);
            this.ApplyCW.Size = new System.Drawing.Size(182, 42);
            this.ApplyCW.TabIndex = 63;
            this.ApplyCW.Text = "Apply Changes";
            this.ApplyCW.Click += new System.EventHandler(this.ApplyCW_Click);
            // 
            // CWCamoCombobox
            // 
            this.CWCamoCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CWCamoCombobox.FormattingEnabled = true;
            this.CWCamoCombobox.Items.AddRange(new object[] {
            "MW Gold",
            "MW Platinum",
            "MW Damascus",
            "MW Obsidian",
            "CW Gold",
            "CW Diamond",
            "CW DM Ultra",
            "CW Golden Viper",
            "CW Plague Diamond",
            "CW Dark Aether"});
            this.CWCamoCombobox.Location = new System.Drawing.Point(214, 40);
            this.CWCamoCombobox.Name = "CWCamoCombobox";
            this.CWCamoCombobox.Size = new System.Drawing.Size(182, 21);
            this.CWCamoCombobox.TabIndex = 62;
            // 
            // CWCamoLabel
            // 
            this.CWCamoLabel.AutoSize = true;
            this.CWCamoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CWCamoLabel.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CWCamoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.CWCamoLabel.Location = new System.Drawing.Point(231, 12);
            this.CWCamoLabel.Name = "CWCamoLabel";
            this.CWCamoLabel.Size = new System.Drawing.Size(150, 25);
            this.CWCamoLabel.TabIndex = 61;
            this.CWCamoLabel.Text = "Set CW Camos to:";
            // 
            // ApplyMW
            // 
            this.ApplyMW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ApplyMW.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyMW.Location = new System.Drawing.Point(12, 67);
            this.ApplyMW.Name = "ApplyMW";
            this.ApplyMW.Padding = new System.Windows.Forms.Padding(5);
            this.ApplyMW.Size = new System.Drawing.Size(185, 42);
            this.ApplyMW.TabIndex = 60;
            this.ApplyMW.Text = "Apply Changes";
            this.ApplyMW.Click += new System.EventHandler(this.ApplyMW_Click);
            // 
            // MWCamoCombobox
            // 
            this.MWCamoCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MWCamoCombobox.FormattingEnabled = true;
            this.MWCamoCombobox.Items.AddRange(new object[] {
            "MW Gold",
            "MW Platinum",
            "MW Damascus",
            "MW Obsidian",
            "CW Gold",
            "CW Diamond",
            "CW DM Ultra",
            "CW Golden Viper",
            "CW Plague Diamond",
            "CW Dark Aether"});
            this.MWCamoCombobox.Location = new System.Drawing.Point(12, 40);
            this.MWCamoCombobox.Name = "MWCamoCombobox";
            this.MWCamoCombobox.Size = new System.Drawing.Size(185, 21);
            this.MWCamoCombobox.TabIndex = 31;
            // 
            // MWCamoLabel
            // 
            this.MWCamoLabel.AutoSize = true;
            this.MWCamoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MWCamoLabel.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MWCamoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MWCamoLabel.Location = new System.Drawing.Point(26, 12);
            this.MWCamoLabel.Name = "MWCamoLabel";
            this.MWCamoLabel.Size = new System.Drawing.Size(157, 25);
            this.MWCamoLabel.TabIndex = 30;
            this.MWCamoLabel.Text = "Set MW Camos to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 140);
            this.label1.TabIndex = 66;
            this.label1.Text = "THIS TOOL IS 100% FREE. IF YOU PAID FOR THIS\r\nSOFTWARE, YOU HAVE BEEN SCAMMED, AN" +
    "D\r\n THE TOOL COULD BE INFECTED.\r\nTHIS TOOL WAS MADE BY JaxonKEKW\r\n\r\nORIGINAL YOU" +
    "TUBE VIDEO AND LINKS:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(100, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(190, 26);
            this.linkLabel1.TabIndex = 69;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linktr.ee/JaxonKEKW";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel2.Location = new System.Drawing.Point(76, 395);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(238, 26);
            this.linkLabel2.TabIndex = 70;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "youtu.be/t19NVMWw8hk";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(64, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "DON\'T SELL FREE SHIT, DICKHEAD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(408, 504);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.ProcDefLabel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.Text = "MW/WZ Only PUBLIC Tool 1.2 - By JaxonKEKW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.MainPublicTab.ResumeLayout(false);
            this.MainPublicTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker BGWorker;
        private DarkUI.Controls.DarkLabel ProcDefLabel;
        private DarkUI.Controls.DarkLabel ProcOpenLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainPublicTab;
        private DarkUI.Controls.DarkComboBox MWCamoCombobox;
        private System.Windows.Forms.Label MWCamoLabel;
        private DarkUI.Controls.DarkButton ApplyMW;
        private DarkUI.Controls.DarkButton ApplyCW;
        private DarkUI.Controls.DarkComboBox CWCamoCombobox;
        private System.Windows.Forms.Label CWCamoLabel;
        private DarkUI.Controls.DarkButton ResetCW;
        private DarkUI.Controls.DarkButton ResetMW;
        private DarkUI.Controls.DarkButton darkButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
    }
}

