namespace ScrumProjectTracking
{
    partial class Form_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTeamStoryPoints = new System.Windows.Forms.Label();
            this.lbTeamBacklogTasks = new System.Windows.Forms.Label();
            this.lbMyStoryPoints = new System.Windows.Forms.Label();
            this.lbMyBackLogTasks = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbSprintEndDate = new System.Windows.Forms.Label();
            this.lbSprintBeginDate = new System.Windows.Forms.Label();
            this.lbSprintName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainFormMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.mainFormMenu.Size = new System.Drawing.Size(1720, 40);
            this.mainFormMenu.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 602);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.lbTeamStoryPoints);
            this.panel3.Controls.Add(this.lbTeamBacklogTasks);
            this.panel3.Controls.Add(this.lbMyStoryPoints);
            this.panel3.Controls.Add(this.lbMyBackLogTasks);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.progressBar3);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.progressBar4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.progressBar2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.lbSprintEndDate);
            this.panel3.Controls.Add(this.lbSprintBeginDate);
            this.panel3.Controls.Add(this.lbSprintName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(862, 429);
            this.panel3.TabIndex = 0;
            // 
            // lbTeamStoryPoints
            // 
            this.lbTeamStoryPoints.AutoSize = true;
            this.lbTeamStoryPoints.Location = new System.Drawing.Point(768, 342);
            this.lbTeamStoryPoints.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTeamStoryPoints.Name = "lbTeamStoryPoints";
            this.lbTeamStoryPoints.Size = new System.Drawing.Size(0, 25);
            this.lbTeamStoryPoints.TabIndex = 20;
            // 
            // lbTeamBacklogTasks
            // 
            this.lbTeamBacklogTasks.AutoSize = true;
            this.lbTeamBacklogTasks.Location = new System.Drawing.Point(768, 287);
            this.lbTeamBacklogTasks.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTeamBacklogTasks.Name = "lbTeamBacklogTasks";
            this.lbTeamBacklogTasks.Size = new System.Drawing.Size(0, 25);
            this.lbTeamBacklogTasks.TabIndex = 19;
            // 
            // lbMyStoryPoints
            // 
            this.lbMyStoryPoints.AutoSize = true;
            this.lbMyStoryPoints.Location = new System.Drawing.Point(768, 190);
            this.lbMyStoryPoints.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMyStoryPoints.Name = "lbMyStoryPoints";
            this.lbMyStoryPoints.Size = new System.Drawing.Size(0, 25);
            this.lbMyStoryPoints.TabIndex = 18;
            // 
            // lbMyBackLogTasks
            // 
            this.lbMyBackLogTasks.AutoSize = true;
            this.lbMyBackLogTasks.Location = new System.Drawing.Point(768, 135);
            this.lbMyBackLogTasks.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMyBackLogTasks.Name = "lbMyBackLogTasks";
            this.lbMyBackLogTasks.Size = new System.Drawing.Size(0, 25);
            this.lbMyBackLogTasks.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sprint Status - Team Assignments";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 342);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Story Points";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(190, 337);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(566, 44);
            this.progressBar3.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 26);
            this.label10.TabIndex = 13;
            this.label10.Text = "Backlog Tasks";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(190, 281);
            this.progressBar4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(566, 44);
            this.progressBar4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sprint Status - My Assignments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Story Points";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(190, 183);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(566, 44);
            this.progressBar2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Backlog Tasks";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(190, 127);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(566, 44);
            this.progressBar1.TabIndex = 7;
            // 
            // lbSprintEndDate
            // 
            this.lbSprintEndDate.AutoSize = true;
            this.lbSprintEndDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSprintEndDate.Location = new System.Drawing.Point(706, 50);
            this.lbSprintEndDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSprintEndDate.Name = "lbSprintEndDate";
            this.lbSprintEndDate.Size = new System.Drawing.Size(0, 29);
            this.lbSprintEndDate.TabIndex = 6;
            // 
            // lbSprintBeginDate
            // 
            this.lbSprintBeginDate.AutoSize = true;
            this.lbSprintBeginDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSprintBeginDate.Location = new System.Drawing.Point(514, 46);
            this.lbSprintBeginDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSprintBeginDate.Name = "lbSprintBeginDate";
            this.lbSprintBeginDate.Size = new System.Drawing.Size(0, 29);
            this.lbSprintBeginDate.TabIndex = 5;
            // 
            // lbSprintName
            // 
            this.lbSprintName.AutoSize = true;
            this.lbSprintName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSprintName.Location = new System.Drawing.Point(262, 46);
            this.lbSprintName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSprintName.Name = "lbSprintName";
            this.lbSprintName.Size = new System.Drawing.Size(0, 29);
            this.lbSprintName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(706, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Begin Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Sprint";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(872, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 602);
            this.panel2.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainFormMenu);
            this.MainMenuStrip = this.mainFormMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1746, 723);
            this.MinimumSize = new System.Drawing.Size(1746, 723);
            this.Name = "Form_Main";
            this.Text = "Scrum Project Tracking System";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.mainFormMenu.ResumeLayout(false);
            this.mainFormMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprintTrackingToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSprintEndDate;
        private System.Windows.Forms.Label lbSprintBeginDate;
        private System.Windows.Forms.Label lbSprintName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTeamStoryPoints;
        private System.Windows.Forms.Label lbTeamBacklogTasks;
        private System.Windows.Forms.Label lbMyStoryPoints;
        private System.Windows.Forms.Label lbMyBackLogTasks;
    }
}