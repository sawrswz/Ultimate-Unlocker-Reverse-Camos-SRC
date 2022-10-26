
namespace IW8NameChange
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currentVersion = new DarkUI.Controls.DarkLabel();
            this.credit = new DarkUI.Controls.DarkLabel();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.SuspendLayout();
            // 
            // currentVersion
            // 
            this.currentVersion.AutoSize = true;
            this.currentVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentVersion.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.currentVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.currentVersion.Location = new System.Drawing.Point(33, 9);
            this.currentVersion.Name = "currentVersion";
            this.currentVersion.Size = new System.Drawing.Size(198, 21);
            this.currentVersion.TabIndex = 0;
            this.currentVersion.Text = "IW8 Version: 1.39.1.9739917";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.credit.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.credit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.credit.Location = new System.Drawing.Point(58, 32);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(150, 21);
            this.credit.TabIndex = 1;
            this.credit.Text = "Made by JaxonKEKW";
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkLabel1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(13, 55);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(239, 40);
            this.darkLabel1.TabIndex = 2;
            this.darkLabel1.Text = "I AM NOT RESPONSIBLE FOR ANY \r\nDAMAGE/BANS FROM THIS TOOL";
            this.darkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(264, 103);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.currentVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "About - PUBLIC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkLabel currentVersion;
        private DarkUI.Controls.DarkLabel credit;
        private DarkUI.Controls.DarkLabel darkLabel1;
    }
}