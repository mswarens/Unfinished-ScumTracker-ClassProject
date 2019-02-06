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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainFormMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprintTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbNextSprintEndDate = new System.Windows.Forms.Label();
            this.lbNextSprintBeginDate = new System.Windows.Forms.Label();
            this.lbNextSprintName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
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
            this.label11 = new System.Windows.Forms.Label();
            this.dgvCurrentSprintTasks = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoryPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskCompletionPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainFormMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentSprintTasks)).BeginInit();
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
            this.mainFormMenu.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mainFormMenu.Size = new System.Drawing.Size(1086, 24);
            this.mainFormMenu.TabIndex = 0;
            this.mainFormMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sprintTrackingToolStripMenuItem
            // 
            this.sprintTrackingToolStripMenuItem.Name = "sprintTrackingToolStripMenuItem";
            this.sprintTrackingToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.sprintTrackingToolStripMenuItem.Text = "Sprint Tracking";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.teamsToolStripMenuItem1,
            this.usersToolStripMenuItem1});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // teamsToolStripMenuItem1
            // 
            this.teamsToolStripMenuItem1.Name = "teamsToolStripMenuItem1";
            this.teamsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.teamsToolStripMenuItem1.Text = "Teams";
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.usersToolStripMenuItem1.Text = "Users";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(432, 294);
            this.panel1.MinimumSize = new System.Drawing.Size(432, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 294);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.Controls.Add(this.lbNextSprintEndDate);
            this.panel4.Controls.Add(this.lbNextSprintBeginDate);
            this.panel4.Controls.Add(this.lbNextSprintName);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(0, 216);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.MaximumSize = new System.Drawing.Size(431, 80);
            this.panel4.MinimumSize = new System.Drawing.Size(431, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 80);
            this.panel4.TabIndex = 1;
            // 
            // lbNextSprintEndDate
            // 
            this.lbNextSprintEndDate.AutoSize = true;
            this.lbNextSprintEndDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextSprintEndDate.Location = new System.Drawing.Point(353, 31);
            this.lbNextSprintEndDate.Name = "lbNextSprintEndDate";
            this.lbNextSprintEndDate.Size = new System.Drawing.Size(0, 14);
            this.lbNextSprintEndDate.TabIndex = 13;
            // 
            // lbNextSprintBeginDate
            // 
            this.lbNextSprintBeginDate.AutoSize = true;
            this.lbNextSprintBeginDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextSprintBeginDate.Location = new System.Drawing.Point(257, 29);
            this.lbNextSprintBeginDate.Name = "lbNextSprintBeginDate";
            this.lbNextSprintBeginDate.Size = new System.Drawing.Size(0, 14);
            this.lbNextSprintBeginDate.TabIndex = 12;
            // 
            // lbNextSprintName
            // 
            this.lbNextSprintName.AutoSize = true;
            this.lbNextSprintName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextSprintName.Location = new System.Drawing.Point(131, 29);
            this.lbNextSprintName.Name = "lbNextSprintName";
            this.lbNextSprintName.Size = new System.Drawing.Size(0, 14);
            this.lbNextSprintName.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(353, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 14);
            this.label14.TabIndex = 10;
            this.label14.Text = "End Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(257, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 14);
            this.label15.TabIndex = 9;
            this.label15.Text = "Begin Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(131, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 14);
            this.label16.TabIndex = 8;
            this.label16.Text = "Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Next Sprint";
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
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.MaximumSize = new System.Drawing.Size(431, 214);
            this.panel3.MinimumSize = new System.Drawing.Size(431, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 214);
            this.panel3.TabIndex = 0;
            // 
            // lbTeamStoryPoints
            // 
            this.lbTeamStoryPoints.AutoSize = true;
            this.lbTeamStoryPoints.Location = new System.Drawing.Point(384, 171);
            this.lbTeamStoryPoints.Name = "lbTeamStoryPoints";
            this.lbTeamStoryPoints.Size = new System.Drawing.Size(0, 13);
            this.lbTeamStoryPoints.TabIndex = 20;
            // 
            // lbTeamBacklogTasks
            // 
            this.lbTeamBacklogTasks.AutoSize = true;
            this.lbTeamBacklogTasks.Location = new System.Drawing.Point(384, 144);
            this.lbTeamBacklogTasks.Name = "lbTeamBacklogTasks";
            this.lbTeamBacklogTasks.Size = new System.Drawing.Size(0, 13);
            this.lbTeamBacklogTasks.TabIndex = 19;
            // 
            // lbMyStoryPoints
            // 
            this.lbMyStoryPoints.AutoSize = true;
            this.lbMyStoryPoints.Location = new System.Drawing.Point(384, 95);
            this.lbMyStoryPoints.Name = "lbMyStoryPoints";
            this.lbMyStoryPoints.Size = new System.Drawing.Size(0, 13);
            this.lbMyStoryPoints.TabIndex = 18;
            // 
            // lbMyBackLogTasks
            // 
            this.lbMyBackLogTasks.AutoSize = true;
            this.lbMyBackLogTasks.Location = new System.Drawing.Point(384, 68);
            this.lbMyBackLogTasks.Name = "lbMyBackLogTasks";
            this.lbMyBackLogTasks.Size = new System.Drawing.Size(0, 13);
            this.lbMyBackLogTasks.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sprint Status - Team Assignments";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Story Points";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(95, 168);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(283, 22);
            this.progressBar3.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Backlog Tasks";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(95, 140);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(283, 22);
            this.progressBar4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sprint Status - My Assignments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Story Points";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(95, 92);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(283, 22);
            this.progressBar2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Backlog Tasks";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(95, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(283, 22);
            this.progressBar1.TabIndex = 7;
            // 
            // lbSprintEndDate
            // 
            this.lbSprintEndDate.AutoSize = true;
            this.lbSprintEndDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSprintEndDate.Location = new System.Drawing.Point(353, 25);
            this.lbSprintEndDate.Name = "lbSprintEndDate";
            this.lbSprintEndDate.Size = new System.Drawing.Size(0, 14);
            this.lbSprintEndDate.TabIndex = 6;
            // 
            // lbSprintBeginDate
            // 
            this.lbSprintBeginDate.AutoSize = true;
            this.lbSprintBeginDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSprintBeginDate.Location = new System.Drawing.Point(257, 23);
            this.lbSprintBeginDate.Name = "lbSprintBeginDate";
            this.lbSprintBeginDate.Size = new System.Drawing.Size(0, 14);
            this.lbSprintBeginDate.TabIndex = 5;
            // 
            // lbSprintName
            // 
            this.lbSprintName.AutoSize = true;
            this.lbSprintName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSprintName.Location = new System.Drawing.Point(131, 23);
            this.lbSprintName.Name = "lbSprintName";
            this.lbSprintName.Size = new System.Drawing.Size(0, 14);
            this.lbSprintName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Begin Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Sprint";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dgvCurrentSprintTasks);
            this.panel2.Location = new System.Drawing.Point(430, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.MaximumSize = new System.Drawing.Size(654, 295);
            this.panel2.MinimumSize = new System.Drawing.Size(654, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 295);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "My Pending Sprint Tasks";
            // 
            // dgvCurrentSprintTasks
            // 
            this.dgvCurrentSprintTasks.AllowUserToAddRows = false;
            this.dgvCurrentSprintTasks.AllowUserToDeleteRows = false;
            this.dgvCurrentSprintTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCurrentSprintTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCurrentSprintTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentSprintTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.ProjectName,
            this.TaskName,
            this.StoryPoints,
            this.TaskCompletionPercent,
            this.EventTaskID});
            this.dgvCurrentSprintTasks.Location = new System.Drawing.Point(10, 32);
            this.dgvCurrentSprintTasks.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCurrentSprintTasks.MaximumSize = new System.Drawing.Size(638, 256);
            this.dgvCurrentSprintTasks.MinimumSize = new System.Drawing.Size(638, 256);
            this.dgvCurrentSprintTasks.MultiSelect = false;
            this.dgvCurrentSprintTasks.Name = "dgvCurrentSprintTasks";
            this.dgvCurrentSprintTasks.ReadOnly = true;
            this.dgvCurrentSprintTasks.RowHeadersVisible = false;
            this.dgvCurrentSprintTasks.RowTemplate.Height = 33;
            this.dgvCurrentSprintTasks.Size = new System.Drawing.Size(638, 256);
            this.dgvCurrentSprintTasks.TabIndex = 0;
            // 
            // View
            // 
            this.View.HeaderText = "";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 20;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "Project";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 230;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 240;
            // 
            // StoryPoints
            // 
            this.StoryPoints.DataPropertyName = "StoryPoints";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.StoryPoints.DefaultCellStyle = dataGridViewCellStyle1;
            this.StoryPoints.HeaderText = "Story Points";
            this.StoryPoints.Name = "StoryPoints";
            this.StoryPoints.ReadOnly = true;
            this.StoryPoints.Width = 85;
            // 
            // TaskCompletionPercent
            // 
            this.TaskCompletionPercent.DataPropertyName = "TaskCompletionPercent";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "#\\%";
            dataGridViewCellStyle2.NullValue = null;
            this.TaskCompletionPercent.DefaultCellStyle = dataGridViewCellStyle2;
            this.TaskCompletionPercent.HeaderText = "Completed";
            this.TaskCompletionPercent.Name = "TaskCompletionPercent";
            this.TaskCompletionPercent.ReadOnly = true;
            this.TaskCompletionPercent.Width = 60;
            // 
            // EventTaskID
            // 
            this.EventTaskID.DataPropertyName = "EventTaskID";
            this.EventTaskID.HeaderText = "";
            this.EventTaskID.MinimumWidth = 2;
            this.EventTaskID.Name = "EventTaskID";
            this.EventTaskID.ReadOnly = true;
            this.EventTaskID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EventTaskID.Visible = false;
            this.EventTaskID.Width = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1086, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainFormMenu);
            this.MainMenuStrip = this.mainFormMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1102, 360);
            this.MinimumSize = new System.Drawing.Size(1102, 360);
            this.Name = "Form_Main";
            this.Text = "Scrum Project Tracking System";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.mainFormMenu.ResumeLayout(false);
            this.mainFormMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentSprintTasks)).EndInit();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbNextSprintEndDate;
        private System.Windows.Forms.Label lbNextSprintBeginDate;
        private System.Windows.Forms.Label lbNextSprintName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvCurrentSprintTasks;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoryPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskCompletionPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTaskID;
    }
}