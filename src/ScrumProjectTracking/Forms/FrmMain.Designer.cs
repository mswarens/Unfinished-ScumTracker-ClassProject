﻿namespace ScrumProjectTracking.Forms
{
    partial class FrmMain
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
            this.mainFormMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprintTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenu
            // 
            this.mainFormMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sprintTrackingToolStripMenuItem,
            this.maintenanceToolStripMenuItem});
            this.mainFormMenu.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenu.Name = "mainFormMenu";
            this.mainFormMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainFormMenu.Size = new System.Drawing.Size(1672, 40);
            this.mainFormMenu.TabIndex = 1;
            this.mainFormMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sprintTrackingToolStripMenuItem
            // 
            this.sprintTrackingToolStripMenuItem.Name = "sprintTrackingToolStripMenuItem";
            this.sprintTrackingToolStripMenuItem.Size = new System.Drawing.Size(185, 36);
            this.sprintTrackingToolStripMenuItem.Text = "Sprint Tracking";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.teamsToolStripMenuItem1,
            this.usersToolStripMenuItem1});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(166, 36);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(197, 38);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // teamsToolStripMenuItem1
            // 
            this.teamsToolStripMenuItem1.Name = "teamsToolStripMenuItem1";
            this.teamsToolStripMenuItem1.Size = new System.Drawing.Size(197, 38);
            this.teamsToolStripMenuItem1.Text = "Teams";
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(197, 38);
            this.usersToolStripMenuItem1.Text = "Users";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 866);
            this.Controls.Add(this.mainFormMenu);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Scrum Project Tracking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mainFormMenu.ResumeLayout(false);
            this.mainFormMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprintTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
    }
}