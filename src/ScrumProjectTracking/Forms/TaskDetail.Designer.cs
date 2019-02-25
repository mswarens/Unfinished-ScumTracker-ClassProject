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
            System.Windows.Forms.Label label5;
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbCompletionPercent = new System.Windows.Forms.Label();
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
            label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sprintIDLabel
            // 
            sprintIDLabel.AutoSize = true;
            sprintIDLabel.Location = new System.Drawing.Point(4, 79);
            sprintIDLabel.Margin = new System.Windows.Forms.Padding(0);
            sprintIDLabel.Name = "sprintIDLabel";
            sprintIDLabel.Size = new System.Drawing.Size(68, 25);
            sprintIDLabel.TabIndex = 4;
            sprintIDLabel.Text = "Sprint";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 125);
            label3.Margin = new System.Windows.Forms.Padding(0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 25);
            label3.TabIndex = 6;
            label3.Text = "Project";
            // 
            // Team
            // 
            Team.AutoSize = true;
            Team.Location = new System.Drawing.Point(4, 171);
            Team.Margin = new System.Windows.Forms.Padding(0);
            Team.Name = "Team";
            Team.Size = new System.Drawing.Size(66, 25);
            Team.TabIndex = 8;
            Team.Text = "Team";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 215);
            label4.Margin = new System.Windows.Forms.Padding(0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 25);
            label4.TabIndex = 10;
            label4.Text = "Assignee";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(48, 115);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(126, 25);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Description:";
            // 
            // storyPointsLabel
            // 
            storyPointsLabel.AutoSize = true;
            storyPointsLabel.Location = new System.Drawing.Point(48, 333);
            storyPointsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            storyPointsLabel.Name = "storyPointsLabel";
            storyPointsLabel.Size = new System.Drawing.Size(134, 25);
            storyPointsLabel.TabIndex = 13;
            storyPointsLabel.Text = "Story Points:";
            // 
            // taskStatusLabel
            // 
            taskStatusLabel.AutoSize = true;
            taskStatusLabel.Location = new System.Drawing.Point(6, 31);
            taskStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            taskStatusLabel.Name = "taskStatusLabel";
            taskStatusLabel.Size = new System.Drawing.Size(79, 25);
            taskStatusLabel.TabIndex = 14;
            taskStatusLabel.Text = "Status:";
            // 
            // addedByLabel
            // 
            addedByLabel.AutoSize = true;
            addedByLabel.Location = new System.Drawing.Point(48, 438);
            addedByLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            addedByLabel.Name = "addedByLabel";
            addedByLabel.Size = new System.Drawing.Size(111, 25);
            addedByLabel.TabIndex = 14;
            addedByLabel.Text = "Added By:";
            // 
            // updatedByLabel
            // 
            updatedByLabel.AutoSize = true;
            updatedByLabel.Location = new System.Drawing.Point(48, 477);
            updatedByLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            updatedByLabel.Name = "updatedByLabel";
            updatedByLabel.Size = new System.Drawing.Size(130, 25);
            updatedByLabel.TabIndex = 15;
            updatedByLabel.Text = "Updated By:";
            // 
            // addedDateTimeLabel
            // 
            addedDateTimeLabel.AutoSize = true;
            addedDateTimeLabel.Location = new System.Drawing.Point(402, 438);
            addedDateTimeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            addedDateTimeLabel.Name = "addedDateTimeLabel";
            addedDateTimeLabel.Size = new System.Drawing.Size(184, 25);
            addedDateTimeLabel.TabIndex = 16;
            addedDateTimeLabel.Text = "Added Date/Time:";
            // 
            // updatedDateTimeLabel
            // 
            updatedDateTimeLabel.AutoSize = true;
            updatedDateTimeLabel.Location = new System.Drawing.Point(402, 477);
            updatedDateTimeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            updatedDateTimeLabel.Name = "updatedDateTimeLabel";
            updatedDateTimeLabel.Size = new System.Drawing.Size(203, 25);
            updatedDateTimeLabel.TabIndex = 17;
            updatedDateTimeLabel.Text = "Updated Date/Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(340, 333);
            label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(218, 25);
            label5.TabIndex = 21;
            label5.Text = "Completion Progress:";
            // 
            // SprintTaskID
            // 
            this.SprintTaskID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SprintTaskID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "SprintTaskID", true));
            this.SprintTaskID.Location = new System.Drawing.Point(200, 62);
            this.SprintTaskID.Margin = new System.Windows.Forms.Padding(4);
            this.SprintTaskID.Name = "SprintTaskID";
            this.SprintTaskID.ReadOnly = true;
            this.SprintTaskID.Size = new System.Drawing.Size(126, 31);
            this.SprintTaskID.TabIndex = 0;
            this.SprintTaskID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sprint Task ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(356, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Name";
            // 
            // TaskName
            // 
            this.TaskName.BackColor = System.Drawing.SystemColors.Window;
            this.TaskName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "TaskName", true));
            this.TaskName.Location = new System.Drawing.Point(484, 65);
            this.TaskName.Margin = new System.Windows.Forms.Padding(4);
            this.TaskName.MaxLength = 100;
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(572, 31);
            this.TaskName.TabIndex = 2;
            this.TaskName.TabStop = false;
            // 
            // SprintID
            // 
            this.SprintID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "SprintID", true));
            this.SprintID.FormattingEnabled = true;
            this.SprintID.Location = new System.Drawing.Point(122, 75);
            this.SprintID.Margin = new System.Windows.Forms.Padding(0);
            this.SprintID.Name = "SprintID";
            this.SprintID.Size = new System.Drawing.Size(248, 33);
            this.SprintID.TabIndex = 5;
            // 
            // ProjectID
            // 
            this.ProjectID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "ProjectID", true));
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(122, 121);
            this.ProjectID.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(248, 33);
            this.ProjectID.TabIndex = 7;
            // 
            // TeamID
            // 
            this.TeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "TeamID", true));
            this.TeamID.FormattingEnabled = true;
            this.TeamID.Location = new System.Drawing.Point(122, 169);
            this.TeamID.Margin = new System.Windows.Forms.Padding(0);
            this.TeamID.Name = "TeamID";
            this.TeamID.Size = new System.Drawing.Size(248, 33);
            this.TeamID.TabIndex = 9;
            this.TeamID.Validated += new System.EventHandler(this.TeamID_Validated);
            // 
            // AssignedUserID
            // 
            this.AssignedUserID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "AssignedUserID", true));
            this.AssignedUserID.FormattingEnabled = true;
            this.AssignedUserID.Location = new System.Drawing.Point(122, 212);
            this.AssignedUserID.Margin = new System.Windows.Forms.Padding(0);
            this.AssignedUserID.Name = "AssignedUserID";
            this.AssignedUserID.Size = new System.Drawing.Size(248, 33);
            this.AssignedUserID.TabIndex = 11;
            this.AssignedUserID.Tag = "";
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
            this.groupBox1.Location = new System.Drawing.Point(1070, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(396, 269);
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
            this.taskStatusComboBox.Location = new System.Drawing.Point(122, 25);
            this.taskStatusComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.taskStatusComboBox.Name = "taskStatusComboBox";
            this.taskStatusComboBox.Size = new System.Drawing.Size(248, 33);
            this.taskStatusComboBox.TabIndex = 15;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(200, 110);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(856, 202);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // storyPointsTextBox
            // 
            this.storyPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "StoryPoints", true));
            this.storyPointsTextBox.Location = new System.Drawing.Point(200, 327);
            this.storyPointsTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.storyPointsTextBox.Name = "storyPointsTextBox";
            this.storyPointsTextBox.Size = new System.Drawing.Size(94, 31);
            this.storyPointsTextBox.TabIndex = 14;
            // 
            // addedByTextBox
            // 
            this.addedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "AddedBy", true));
            this.addedByTextBox.Location = new System.Drawing.Point(192, 433);
            this.addedByTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addedByTextBox.Name = "addedByTextBox";
            this.addedByTextBox.ReadOnly = true;
            this.addedByTextBox.Size = new System.Drawing.Size(174, 31);
            this.addedByTextBox.TabIndex = 15;
            this.addedByTextBox.TabStop = false;
            // 
            // updatedByTextBox
            // 
            this.updatedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "UpdatedBy", true));
            this.updatedByTextBox.Location = new System.Drawing.Point(192, 477);
            this.updatedByTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.updatedByTextBox.Name = "updatedByTextBox";
            this.updatedByTextBox.ReadOnly = true;
            this.updatedByTextBox.Size = new System.Drawing.Size(174, 31);
            this.updatedByTextBox.TabIndex = 16;
            this.updatedByTextBox.TabStop = false;
            // 
            // addedDateTimeTextBox
            // 
            this.addedDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "AddedDateTime", true));
            this.addedDateTimeTextBox.Location = new System.Drawing.Point(620, 433);
            this.addedDateTimeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addedDateTimeTextBox.Name = "addedDateTimeTextBox";
            this.addedDateTimeTextBox.ReadOnly = true;
            this.addedDateTimeTextBox.Size = new System.Drawing.Size(296, 31);
            this.addedDateTimeTextBox.TabIndex = 17;
            this.addedDateTimeTextBox.TabStop = false;
            // 
            // updatedDateTimeTextBox
            // 
            this.updatedDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "UpdatedDateTime", true));
            this.updatedDateTimeTextBox.Location = new System.Drawing.Point(620, 477);
            this.updatedDateTimeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.updatedDateTimeTextBox.Name = "updatedDateTimeTextBox";
            this.updatedDateTimeTextBox.ReadOnly = true;
            this.updatedDateTimeTextBox.Size = new System.Drawing.Size(296, 31);
            this.updatedDateTimeTextBox.TabIndex = 18;
            this.updatedDateTimeTextBox.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1528, 39);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sprintTaskBindingSource, "TaskCompletionPercent", true));
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(564, 327);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(526, 90);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 20;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lbCompletionPercent
            // 
            this.lbCompletionPercent.AutoSize = true;
            this.lbCompletionPercent.Location = new System.Drawing.Point(1086, 340);
            this.lbCompletionPercent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCompletionPercent.Name = "lbCompletionPercent";
            this.lbCompletionPercent.Size = new System.Drawing.Size(0, 25);
            this.lbCompletionPercent.TabIndex = 22;
            // 
            // sprintTaskBindingSource
            // 
            this.sprintTaskBindingSource.DataSource = typeof(ScrumProjectTracking.DataModels.SprintTask);
            // 
            // TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 565);
            this.ControlBox = false;
            this.Controls.Add(this.lbCompletionPercent);
            this.Controls.Add(label5);
            this.Controls.Add(this.trackBar1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sprint Task Detail";
            this.Load += new System.EventHandler(this.TaskDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbCompletionPercent;
    }
}