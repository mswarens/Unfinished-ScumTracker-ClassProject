﻿namespace ScrumProjectTracking.Sprints.SprintTaskList
{
    partial class SprintTaskList
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
            System.Windows.Forms.Label sprintIDLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label Team;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprintTaskList));
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sprint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SprintTaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assignee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSprintTaskID = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.AssignedUserID = new System.Windows.Forms.ComboBox();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.TeamID = new System.Windows.Forms.ComboBox();
            this.SprintID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTaskStatus = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbExportFormat = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            sprintIDLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            Team = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sprintIDLabel
            // 
            sprintIDLabel.AutoSize = true;
            sprintIDLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sprintIDLabel.Location = new System.Drawing.Point(313, 25);
            sprintIDLabel.Margin = new System.Windows.Forms.Padding(0);
            sprintIDLabel.Name = "sprintIDLabel";
            sprintIDLabel.Size = new System.Drawing.Size(40, 15);
            sprintIDLabel.TabIndex = 8;
            sprintIDLabel.Text = "Sprint";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(313, 48);
            label3.Margin = new System.Windows.Forms.Padding(0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 15);
            label3.TabIndex = 11;
            label3.Text = "Project";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(313, 95);
            label4.Margin = new System.Windows.Forms.Padding(0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 15;
            label4.Text = "Assignee";
            // 
            // Team
            // 
            Team.AutoSize = true;
            Team.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Team.Location = new System.Drawing.Point(313, 72);
            Team.Margin = new System.Windows.Forms.Padding(0);
            Team.Name = "Team";
            Team.Size = new System.Drawing.Size(35, 15);
            Team.TabIndex = 12;
            Team.Text = "Team";
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.AllowUserToAddRows = false;
            this.dgvTaskList.AllowUserToDeleteRows = false;
            this.dgvTaskList.AllowUserToResizeRows = false;
            this.dgvTaskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Sprint,
            this.Project,
            this.SprintTaskID,
            this.TaskName,
            this.TeamName,
            this.Assignee,
            this.TaskStatus});
            this.dgvTaskList.Location = new System.Drawing.Point(0, 27);
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.ReadOnly = true;
            this.dgvTaskList.RowHeadersVisible = false;
            this.dgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaskList.Size = new System.Drawing.Size(892, 302);
            this.dgvTaskList.TabIndex = 0;
            this.dgvTaskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaskList_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Sprint
            // 
            this.Sprint.DataPropertyName = "SprintName";
            this.Sprint.HeaderText = "Sprint";
            this.Sprint.Name = "Sprint";
            this.Sprint.ReadOnly = true;
            // 
            // Project
            // 
            this.Project.DataPropertyName = "ProjectName";
            this.Project.HeaderText = "Project";
            this.Project.Name = "Project";
            this.Project.ReadOnly = true;
            // 
            // SprintTaskID
            // 
            this.SprintTaskID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SprintTaskID.DataPropertyName = "SprintTaskID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.SprintTaskID.DefaultCellStyle = dataGridViewCellStyle1;
            this.SprintTaskID.FillWeight = 55F;
            this.SprintTaskID.HeaderText = "Sprint Task ID";
            this.SprintTaskID.Name = "SprintTaskID";
            this.SprintTaskID.ReadOnly = true;
            this.SprintTaskID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.FillWeight = 200F;
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.MinimumWidth = 250;
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // TeamName
            // 
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "Team";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            // 
            // Assignee
            // 
            this.Assignee.DataPropertyName = "AssignedtoName";
            this.Assignee.HeaderText = "Assignee";
            this.Assignee.Name = "Assignee";
            this.Assignee.ReadOnly = true;
            // 
            // TaskStatus
            // 
            this.TaskStatus.DataPropertyName = "TaskStatus";
            this.TaskStatus.HeaderText = "Task Status";
            this.TaskStatus.Name = "TaskStatus";
            this.TaskStatus.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSprintTaskID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.AssignedUserID);
            this.groupBox1.Controls.Add(Team);
            this.groupBox1.Controls.Add(this.ProjectID);
            this.groupBox1.Controls.Add(this.TeamID);
            this.groupBox1.Controls.Add(this.SprintID);
            this.groupBox1.Controls.Add(sprintIDLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbTaskStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTaskName);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // tbSprintTaskID
            // 
            this.tbSprintTaskID.Location = new System.Drawing.Point(99, 22);
            this.tbSprintTaskID.Mask = "000000";
            this.tbSprintTaskID.Name = "tbSprintTaskID";
            this.tbSprintTaskID.PromptChar = ' ';
            this.tbSprintTaskID.Size = new System.Drawing.Size(48, 23);
            this.tbSprintTaskID.TabIndex = 0;
            this.tbSprintTaskID.ValidatingType = typeof(int);
            this.tbSprintTaskID.TextChanged += new System.EventHandler(this.tbSprintTaskID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sprint Task ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(501, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AssignedUserID
            // 
            this.AssignedUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssignedUserID.Enabled = false;
            this.AssignedUserID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedUserID.FormattingEnabled = true;
            this.AssignedUserID.Location = new System.Drawing.Point(372, 93);
            this.AssignedUserID.Margin = new System.Windows.Forms.Padding(0);
            this.AssignedUserID.Name = "AssignedUserID";
            this.AssignedUserID.Size = new System.Drawing.Size(126, 23);
            this.AssignedUserID.TabIndex = 16;
            this.AssignedUserID.Tag = "Sprint Task Detail";
            // 
            // ProjectID
            // 
            this.ProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(372, 46);
            this.ProjectID.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(126, 23);
            this.ProjectID.TabIndex = 13;
            // 
            // TeamID
            // 
            this.TeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamID.FormattingEnabled = true;
            this.TeamID.Location = new System.Drawing.Point(372, 71);
            this.TeamID.Margin = new System.Windows.Forms.Padding(0);
            this.TeamID.Name = "TeamID";
            this.TeamID.Size = new System.Drawing.Size(126, 23);
            this.TeamID.TabIndex = 14;
            this.TeamID.SelectionChangeCommitted += new System.EventHandler(this.TeamID_SelectionChangeCommitted);
            // 
            // SprintID
            // 
            this.SprintID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SprintID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SprintID.FormattingEnabled = true;
            this.SprintID.Location = new System.Drawing.Point(372, 22);
            this.SprintID.Margin = new System.Windows.Forms.Padding(0);
            this.SprintID.Name = "SprintID";
            this.SprintID.Size = new System.Drawing.Size(126, 23);
            this.SprintID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Status";
            // 
            // lbTaskStatus
            // 
            this.lbTaskStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaskStatus.FormattingEnabled = true;
            this.lbTaskStatus.ItemHeight = 15;
            this.lbTaskStatus.Items.AddRange(new object[] {
            "Pending",
            "Completed",
            "Cancelled"});
            this.lbTaskStatus.Location = new System.Drawing.Point(99, 72);
            this.lbTaskStatus.Name = "lbTaskStatus";
            this.lbTaskStatus.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTaskStatus.Size = new System.Drawing.Size(83, 49);
            this.lbTaskStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Name";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaskName.Location = new System.Drawing.Point(99, 46);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(204, 23);
            this.tbTaskName.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(889, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbExportFormat);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Location = new System.Drawing.Point(631, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export Results";
            // 
            // cbExportFormat
            // 
            this.cbExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExportFormat.FormattingEnabled = true;
            this.cbExportFormat.Items.AddRange(new object[] {
            "Excel",
            "PDF"});
            this.cbExportFormat.Location = new System.Drawing.Point(17, 24);
            this.cbExportFormat.Name = "cbExportFormat";
            this.cbExportFormat.Size = new System.Drawing.Size(124, 21);
            this.cbExportFormat.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(147, 22);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(93, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // SprintTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(889, 512);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTaskList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SprintTaskList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sprint Tasks-Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaskList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTaskStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.ComboBox SprintID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox AssignedUserID;
        private System.Windows.Forms.ComboBox ProjectID;
        private System.Windows.Forms.ComboBox TeamID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cbExportFormat;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn SprintTaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignee;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStatus;
        private System.Windows.Forms.MaskedTextBox tbSprintTaskID;
        private System.Windows.Forms.Label label5;
    }
}