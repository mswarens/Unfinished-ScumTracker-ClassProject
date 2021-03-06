﻿namespace ScrumProjectTracking.Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mainFormMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprintTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprintTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSprintToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backlogMenuStripItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.backlogMenuStripItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenu
            // 
            this.mainFormMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sprintTrackingToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.backlogToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainFormMenu.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenu.Name = "mainFormMenu";
            this.mainFormMenu.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.mainFormMenu.Size = new System.Drawing.Size(836, 24);
            this.mainFormMenu.TabIndex = 1;
            this.mainFormMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sprintTrackingToolStripMenuItem
            // 
            this.sprintTrackingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addNewSprintToolStripMenuItem,
            this.sprintTasksToolStripMenuItem});
            this.sprintTrackingToolStripMenuItem.Name = "sprintTrackingToolStripMenuItem";
            this.sprintTrackingToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.sprintTrackingToolStripMenuItem.Text = "Sprints";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // addNewSprintToolStripMenuItem
            // 
            this.addNewSprintToolStripMenuItem.Name = "addNewSprintToolStripMenuItem";
            this.addNewSprintToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addNewSprintToolStripMenuItem.Text = "&Add New Sprint";
            this.addNewSprintToolStripMenuItem.Click += new System.EventHandler(this.addNewSprintToolStripMenuItem_Click);
            // 
            // sprintTasksToolStripMenuItem
            // 
            this.sprintTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.addNewSprintToolStripMenuItem1});
            this.sprintTasksToolStripMenuItem.Name = "sprintTasksToolStripMenuItem";
            this.sprintTasksToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sprintTasksToolStripMenuItem.Text = "Sprint Tasks";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.searchToolStripMenuItem1.Text = "&Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // addNewSprintToolStripMenuItem1
            // 
            this.addNewSprintToolStripMenuItem1.Name = "addNewSprintToolStripMenuItem1";
            this.addNewSprintToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.addNewSprintToolStripMenuItem1.Text = "&Add New Sprint Task";
            this.addNewSprintToolStripMenuItem1.Click += new System.EventHandler(this.addNewSprintToolStripMenuItem1_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem3,
            this.teamsToolStripMenuItem2,
            this.usersToolStripMenuItem1});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // projectsToolStripMenuItem3
            // 
            this.projectsToolStripMenuItem3.Name = "projectsToolStripMenuItem3";
            this.projectsToolStripMenuItem3.Size = new System.Drawing.Size(116, 22);
            this.projectsToolStripMenuItem3.Text = "Projects";
            this.projectsToolStripMenuItem3.Click += new System.EventHandler(this.projectsToolStripMenuItem3_Click);
            // 
            // teamsToolStripMenuItem2
            // 
            this.teamsToolStripMenuItem2.Name = "teamsToolStripMenuItem2";
            this.teamsToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.teamsToolStripMenuItem2.Text = "Teams";
            this.teamsToolStripMenuItem2.Click += new System.EventHandler(this.teamsToolStripMenuItem2_Click);
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.usersToolStripMenuItem1.Text = "Users";
            this.usersToolStripMenuItem1.Click += new System.EventHandler(this.usersToolStripMenuItem1_Click);
            // 
            // backlogToolStripMenuItem
            // 
            this.backlogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backlogMenuStripItemView,
            this.backlogMenuStripItemAdd});
            this.backlogToolStripMenuItem.Name = "backlogToolStripMenuItem";
            this.backlogToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.backlogToolStripMenuItem.Text = "Backlog";
            this.backlogToolStripMenuItem.Click += new System.EventHandler(this.backlogToolStripMenuItem_Click);
            // 
            // backlogMenuStripItemView
            // 
            this.backlogMenuStripItemView.Name = "backlogMenuStripItemView";
            this.backlogMenuStripItemView.Size = new System.Drawing.Size(205, 22);
            this.backlogMenuStripItemView.Text = "Edit/View Existing Stories";
            this.backlogMenuStripItemView.Click += new System.EventHandler(this.backlogMenuStripItemView_Click);
            // 
            // backlogMenuStripItemAdd
            // 
            this.backlogMenuStripItemAdd.Name = "backlogMenuStripItemAdd";
            this.backlogMenuStripItemAdd.Size = new System.Drawing.Size(205, 22);
            this.backlogMenuStripItemAdd.Text = "Add New Story";
            this.backlogMenuStripItemAdd.Click += new System.EventHandler(this.backlogMenuStripItemAdd_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(100, 52);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Visible = false;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "closeTab");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainFormMenu);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Scrum Project Tracking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
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
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem backlogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backlogMenuStripItemView;
        private System.Windows.Forms.ToolStripMenuItem backlogMenuStripItemAdd;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprintTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewSprintToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}