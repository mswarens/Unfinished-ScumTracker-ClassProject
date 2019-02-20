namespace ScrumProjectTracking.Forms
{
    partial class TaskDetail
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
            System.Windows.Forms.Label sprintIDLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label Team;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label storyPointsLabel;
            System.Windows.Forms.Label taskStatusLabel;
            System.Windows.Forms.Label addedByLabel;
            System.Windows.Forms.Label updatedByLabel;
            System.Windows.Forms.Label addedDateTimeLabel;
            System.Windows.Forms.Label updatedDateTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetail));
            this.SprintTaskID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.SprintID = new System.Windows.Forms.ComboBox();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.TeamID = new System.Windows.Forms.ComboBox();
            this.AssignedUserID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taskStatusComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.storyPointsTextBox = new System.Windows.Forms.TextBox();
            this.addedByTextBox = new System.Windows.Forms.TextBox();
            this.updatedByTextBox = new System.Windows.Forms.TextBox();
            this.addedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.updatedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sprintTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sprintIDLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            Team = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            storyPointsLabel = new System.Windows.Forms.Label();
            taskStatusLabel = new System.Windows.Forms.Label();
            addedByLabel = new System.Windows.Forms.Label();
            updatedByLabel = new System.Windows.Forms.Label();
            addedDateTimeLabel = new System.Windows.Forms.Label();
            updatedDateTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprintTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sprintIDLabel
            // 
            sprintIDLabel.AutoSize = true;
            sprintIDLabel.Location = new System.Drawing.Point(2, 41);
            sprintIDLabel.Margin = new System.Windows.Forms.Padding(0);
            sprintIDLabel.Name = "sprintIDLabel";
            sprintIDLabel.Size = new System.Drawing.Size(34, 13);
            sprintIDLabel.TabIndex = 4;
            sprintIDLabel.Text = "Sprint";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(2, 65);
            label3.Margin = new System.Windows.Forms.Padding(0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 13);
            label3.TabIndex = 6;
            label3.Text = "Project";
            // 
            // Team
            // 
            Team.AutoSize = true;
            Team.Location = new System.Drawing.Point(2, 89);
            Team.Margin = new System.Windows.Forms.Padding(0);
            Team.Name = "Team";
            Team.Size = new System.Drawing.Size(34, 13);
            Team.TabIndex = 8;
            Team.Text = "Team";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(2, 112);
            label4.Margin = new System.Windows.Forms.Padding(0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 13);
            label4.TabIndex = 10;
            label4.Text = "Assignee";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(24, 60);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Description:";
            // 
            // storyPointsLabel
            // 
            storyPointsLabel.AutoSize = true;
            storyPointsLabel.Location = new System.Drawing.Point(24, 173);
            storyPointsLabel.Name = "storyPointsLabel";
            storyPointsLabel.Size = new System.Drawing.Size(66, 13);
            storyPointsLabel.TabIndex = 13;
            storyPointsLabel.Text = "Story Points:";
            // 
            // taskStatusLabel
            // 
            taskStatusLabel.AutoSize = true;
            taskStatusLabel.Location = new System.Drawing.Point(3, 16);
            taskStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            taskStatusLabel.Name = "taskStatusLabel";
            taskStatusLabel.Size = new System.Drawing.Size(40, 13);
            taskStatusLabel.TabIndex = 14;
            taskStatusLabel.Text = "Status:";
            // 
            // SprintTaskID
            // 
            this.SprintTaskID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SprintTaskID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "SprintTaskID", true));
            this.SprintTaskID.Location = new System.Drawing.Point(100, 32);
            this.SprintTaskID.Margin = new System.Windows.Forms.Padding(2);
            this.SprintTaskID.Name = "SprintTaskID";
            this.SprintTaskID.ReadOnly = true;
            this.SprintTaskID.Size = new System.Drawing.Size(65, 20);
            this.SprintTaskID.TabIndex = 0;
            this.SprintTaskID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sprint Task ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(178, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Name";
            // 
            // TaskName
            // 
            this.TaskName.BackColor = System.Drawing.SystemColors.Window;
            this.TaskName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "TaskName", true));
            this.TaskName.Location = new System.Drawing.Point(242, 34);
            this.TaskName.Margin = new System.Windows.Forms.Padding(2);
            this.TaskName.MaxLength = 100;
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(288, 20);
            this.TaskName.TabIndex = 2;
            this.TaskName.TabStop = false;
            // 
            // SprintID
            // 
            this.SprintID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "SprintID", true));
            this.SprintID.FormattingEnabled = true;
            this.SprintID.Location = new System.Drawing.Point(61, 39);
            this.SprintID.Margin = new System.Windows.Forms.Padding(0);
            this.SprintID.Name = "SprintID";
            this.SprintID.Size = new System.Drawing.Size(126, 21);
            this.SprintID.TabIndex = 5;
            // 
            // ProjectID
            // 
            this.ProjectID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "ProjectID", true));
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(61, 63);
            this.ProjectID.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(126, 21);
            this.ProjectID.TabIndex = 7;
            // 
            // TeamID
            // 
            this.TeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "TeamID", true));
            this.TeamID.FormattingEnabled = true;
            this.TeamID.Location = new System.Drawing.Point(61, 88);
            this.TeamID.Margin = new System.Windows.Forms.Padding(0);
            this.TeamID.Name = "TeamID";
            this.TeamID.Size = new System.Drawing.Size(126, 21);
            this.TeamID.TabIndex = 9;
            this.TeamID.ValueMemberChanged += new System.EventHandler(this.TeamID_ValueMemberChanged);
            // 
            // AssignedUserID
            // 
            this.AssignedUserID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "TeamID", true));
            this.AssignedUserID.Enabled = false;
            this.AssignedUserID.FormattingEnabled = true;
            this.AssignedUserID.Location = new System.Drawing.Point(61, 110);
            this.AssignedUserID.Margin = new System.Windows.Forms.Padding(0);
            this.AssignedUserID.Name = "AssignedUserID";
            this.AssignedUserID.Size = new System.Drawing.Size(126, 21);
            this.AssignedUserID.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(taskStatusLabel);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.taskStatusComboBox);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.SprintID);
            this.groupBox1.Controls.Add(this.AssignedUserID);
            this.groupBox1.Controls.Add(sprintIDLabel);
            this.groupBox1.Controls.Add(Team);
            this.groupBox1.Controls.Add(this.ProjectID);
            this.groupBox1.Controls.Add(this.TeamID);
            this.groupBox1.Location = new System.Drawing.Point(535, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(198, 140);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // taskStatusComboBox
            // 
            this.taskStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "TaskStatus", true));
            this.taskStatusComboBox.FormattingEnabled = true;
            this.taskStatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Completed"});
            this.taskStatusComboBox.Location = new System.Drawing.Point(61, 13);
            this.taskStatusComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.taskStatusComboBox.Name = "taskStatusComboBox";
            this.taskStatusComboBox.Size = new System.Drawing.Size(126, 21);
            this.taskStatusComboBox.TabIndex = 15;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(100, 57);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(430, 107);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // storyPointsTextBox
            // 
            this.storyPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "StoryPoints", true));
            this.storyPointsTextBox.Location = new System.Drawing.Point(100, 170);
            this.storyPointsTextBox.Name = "storyPointsTextBox";
            this.storyPointsTextBox.Size = new System.Drawing.Size(49, 20);
            this.storyPointsTextBox.TabIndex = 14;
            // 
            // addedByLabel
            // 
            addedByLabel.AutoSize = true;
            addedByLabel.Location = new System.Drawing.Point(24, 208);
            addedByLabel.Name = "addedByLabel";
            addedByLabel.Size = new System.Drawing.Size(56, 13);
            addedByLabel.TabIndex = 14;
            addedByLabel.Text = "Added By:";
            // 
            // addedByTextBox
            // 
            this.addedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "AddedBy", true));
            this.addedByTextBox.Location = new System.Drawing.Point(96, 205);
            this.addedByTextBox.Name = "addedByTextBox";
            this.addedByTextBox.ReadOnly = true;
            this.addedByTextBox.Size = new System.Drawing.Size(89, 20);
            this.addedByTextBox.TabIndex = 15;
            this.addedByTextBox.TabStop = false;
            // 
            // updatedByLabel
            // 
            updatedByLabel.AutoSize = true;
            updatedByLabel.Location = new System.Drawing.Point(24, 228);
            updatedByLabel.Name = "updatedByLabel";
            updatedByLabel.Size = new System.Drawing.Size(66, 13);
            updatedByLabel.TabIndex = 15;
            updatedByLabel.Text = "Updated By:";
            // 
            // updatedByTextBox
            // 
            this.updatedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "UpdatedBy", true));
            this.updatedByTextBox.Location = new System.Drawing.Point(96, 228);
            this.updatedByTextBox.Name = "updatedByTextBox";
            this.updatedByTextBox.ReadOnly = true;
            this.updatedByTextBox.Size = new System.Drawing.Size(89, 20);
            this.updatedByTextBox.TabIndex = 16;
            this.updatedByTextBox.TabStop = false;
            // 
            // addedDateTimeLabel
            // 
            addedDateTimeLabel.AutoSize = true;
            addedDateTimeLabel.Location = new System.Drawing.Point(201, 208);
            addedDateTimeLabel.Name = "addedDateTimeLabel";
            addedDateTimeLabel.Size = new System.Drawing.Size(95, 13);
            addedDateTimeLabel.TabIndex = 16;
            addedDateTimeLabel.Text = "Added Date/Time:";
            // 
            // addedDateTimeTextBox
            // 
            this.addedDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "AddedDateTime", true));
            this.addedDateTimeTextBox.Location = new System.Drawing.Point(310, 205);
            this.addedDateTimeTextBox.Name = "addedDateTimeTextBox";
            this.addedDateTimeTextBox.ReadOnly = true;
            this.addedDateTimeTextBox.Size = new System.Drawing.Size(150, 20);
            this.addedDateTimeTextBox.TabIndex = 17;
            this.addedDateTimeTextBox.TabStop = false;
            // 
            // updatedDateTimeLabel
            // 
            updatedDateTimeLabel.AutoSize = true;
            updatedDateTimeLabel.Location = new System.Drawing.Point(201, 228);
            updatedDateTimeLabel.Name = "updatedDateTimeLabel";
            updatedDateTimeLabel.Size = new System.Drawing.Size(105, 13);
            updatedDateTimeLabel.TabIndex = 17;
            updatedDateTimeLabel.Text = "Updated Date/Time:";
            // 
            // updatedDateTimeTextBox
            // 
            this.updatedDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "UpdatedDateTime", true));
            this.updatedDateTimeTextBox.Location = new System.Drawing.Point(310, 228);
            this.updatedDateTimeTextBox.Name = "updatedDateTimeTextBox";
            this.updatedDateTimeTextBox.ReadOnly = true;
            this.updatedDateTimeTextBox.Size = new System.Drawing.Size(150, 20);
            this.updatedDateTimeTextBox.TabIndex = 18;
            this.updatedDateTimeTextBox.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // sprintTaskBindingSource
            // 
            this.sprintTaskBindingSource.DataSource = typeof(ScrumProjectTracking.DataModels.SprintTask);
            // 
            // TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 294);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(updatedDateTimeLabel);
            this.Controls.Add(this.updatedDateTimeTextBox);
            this.Controls.Add(addedDateTimeLabel);
            this.Controls.Add(this.addedDateTimeTextBox);
            this.Controls.Add(updatedByLabel);
            this.Controls.Add(this.updatedByTextBox);
            this.Controls.Add(addedByLabel);
            this.Controls.Add(this.addedByTextBox);
            this.Controls.Add(storyPointsLabel);
            this.Controls.Add(this.storyPointsTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SprintTaskID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sprint Task Detail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprintTaskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SprintTaskID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.BindingSource sprintTaskBindingSource;
        private System.Windows.Forms.ComboBox SprintID;
        private System.Windows.Forms.ComboBox ProjectID;
        private System.Windows.Forms.ComboBox TeamID;
        private System.Windows.Forms.ComboBox AssignedUserID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox taskStatusComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox storyPointsTextBox;
        private System.Windows.Forms.TextBox addedByTextBox;
        private System.Windows.Forms.TextBox updatedByTextBox;
        private System.Windows.Forms.TextBox addedDateTimeTextBox;
        private System.Windows.Forms.TextBox updatedDateTimeTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
    }
}