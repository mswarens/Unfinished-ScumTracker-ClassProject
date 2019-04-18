namespace ScrumProjectTracking.Sprints.SprintTaskDetail
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
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SprintTaskID = new System.Windows.Forms.TextBox();
            this.sprintTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.SprintID = new System.Windows.Forms.ComboBox();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.TeamID = new System.Windows.Forms.ComboBox();
            this.AssignedUserID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taskSubstatusComboBox = new System.Windows.Forms.ComboBox();
            this.taskStatusComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addedByTextBox = new System.Windows.Forms.TextBox();
            this.updatedByTextBox = new System.Windows.Forms.TextBox();
            this.addedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.updatedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbCompletionPercent = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NoteText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SprintTaskNoteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.storyPointsTextBox = new System.Windows.Forms.MaskedTextBox();
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
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sprintTaskBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // sprintIDLabel
            // 
            sprintIDLabel.AutoSize = true;
            sprintIDLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sprintIDLabel.Location = new System.Drawing.Point(3, 69);
            sprintIDLabel.Margin = new System.Windows.Forms.Padding(0);
            sprintIDLabel.Name = "sprintIDLabel";
            sprintIDLabel.Size = new System.Drawing.Size(40, 15);
            sprintIDLabel.TabIndex = 4;
            sprintIDLabel.Text = "Sprint";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(2, 94);
            label3.Margin = new System.Windows.Forms.Padding(0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Project";
            // 
            // Team
            // 
            Team.AutoSize = true;
            Team.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Team.Location = new System.Drawing.Point(2, 119);
            Team.Margin = new System.Windows.Forms.Padding(0);
            Team.Name = "Team";
            Team.Size = new System.Drawing.Size(35, 15);
            Team.TabIndex = 8;
            Team.Text = "Team";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(3, 144);
            label4.Margin = new System.Windows.Forms.Padding(0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Assignee";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(24, 60);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(73, 15);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Description:";
            // 
            // storyPointsLabel
            // 
            storyPointsLabel.AutoSize = true;
            storyPointsLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            storyPointsLabel.Location = new System.Drawing.Point(24, 173);
            storyPointsLabel.Name = "storyPointsLabel";
            storyPointsLabel.Size = new System.Drawing.Size(76, 15);
            storyPointsLabel.TabIndex = 13;
            storyPointsLabel.Text = "Story Points:";
            // 
            // taskStatusLabel
            // 
            taskStatusLabel.AutoSize = true;
            taskStatusLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            taskStatusLabel.Location = new System.Drawing.Point(3, 19);
            taskStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            taskStatusLabel.Name = "taskStatusLabel";
            taskStatusLabel.Size = new System.Drawing.Size(44, 15);
            taskStatusLabel.TabIndex = 14;
            taskStatusLabel.Text = "Status:";
            // 
            // addedByLabel
            // 
            addedByLabel.AutoSize = true;
            addedByLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addedByLabel.Location = new System.Drawing.Point(24, 228);
            addedByLabel.Name = "addedByLabel";
            addedByLabel.Size = new System.Drawing.Size(60, 15);
            addedByLabel.TabIndex = 14;
            addedByLabel.Text = "Added By:";
            // 
            // updatedByLabel
            // 
            updatedByLabel.AutoSize = true;
            updatedByLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updatedByLabel.Location = new System.Drawing.Point(24, 248);
            updatedByLabel.Name = "updatedByLabel";
            updatedByLabel.Size = new System.Drawing.Size(72, 15);
            updatedByLabel.TabIndex = 15;
            updatedByLabel.Text = "Updated By:";
            // 
            // addedDateTimeLabel
            // 
            addedDateTimeLabel.AutoSize = true;
            addedDateTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addedDateTimeLabel.Location = new System.Drawing.Point(201, 228);
            addedDateTimeLabel.Name = "addedDateTimeLabel";
            addedDateTimeLabel.Size = new System.Drawing.Size(103, 15);
            addedDateTimeLabel.TabIndex = 16;
            addedDateTimeLabel.Text = "Added Date/Time:";
            // 
            // updatedDateTimeLabel
            // 
            updatedDateTimeLabel.AutoSize = true;
            updatedDateTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updatedDateTimeLabel.Location = new System.Drawing.Point(201, 248);
            updatedDateTimeLabel.Name = "updatedDateTimeLabel";
            updatedDateTimeLabel.Size = new System.Drawing.Size(115, 15);
            updatedDateTimeLabel.TabIndex = 17;
            updatedDateTimeLabel.Text = "Updated Date/Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(164, 173);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(112, 15);
            label5.TabIndex = 21;
            label5.Text = "Percent Completed:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(3, 44);
            label6.Margin = new System.Windows.Forms.Padding(0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(64, 15);
            label6.TabIndex = 16;
            label6.Text = "Substatus:";
            // 
            // SprintTaskID
            // 
            this.SprintTaskID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SprintTaskID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "SprintTaskID", true));
            this.SprintTaskID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SprintTaskID.Location = new System.Drawing.Point(110, 32);
            this.SprintTaskID.Margin = new System.Windows.Forms.Padding(2);
            this.SprintTaskID.Name = "SprintTaskID";
            this.SprintTaskID.ReadOnly = true;
            this.SprintTaskID.Size = new System.Drawing.Size(55, 23);
            this.SprintTaskID.TabIndex = 0;
            this.SprintTaskID.TabStop = false;
            // 
            // sprintTaskBindingSource
            // 
            this.sprintTaskBindingSource.DataSource = typeof(ScrumProjectTracking.DataAccess.SprintTask);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sprint Task ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Name";
            // 
            // TaskName
            // 
            this.TaskName.BackColor = System.Drawing.SystemColors.Window;
            this.TaskName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "TaskName", true));
            this.TaskName.Location = new System.Drawing.Point(247, 34);
            this.TaskName.Margin = new System.Windows.Forms.Padding(2);
            this.TaskName.MaxLength = 100;
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(272, 20);
            this.TaskName.TabIndex = 2;
            this.TaskName.TabStop = false;
            // 
            // SprintID
            // 
            this.SprintID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "SprintID", true));
            this.SprintID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SprintID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SprintID.FormattingEnabled = true;
            this.SprintID.Location = new System.Drawing.Point(72, 66);
            this.SprintID.Margin = new System.Windows.Forms.Padding(0);
            this.SprintID.Name = "SprintID";
            this.SprintID.Size = new System.Drawing.Size(154, 23);
            this.SprintID.TabIndex = 8;
            // 
            // ProjectID
            // 
            this.ProjectID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "ProjectID", true));
            this.ProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(72, 91);
            this.ProjectID.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(154, 23);
            this.ProjectID.TabIndex = 9;
            // 
            // TeamID
            // 
            this.TeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "TeamID", true));
            this.TeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamID.FormattingEnabled = true;
            this.TeamID.Location = new System.Drawing.Point(72, 116);
            this.TeamID.Margin = new System.Windows.Forms.Padding(0);
            this.TeamID.Name = "TeamID";
            this.TeamID.Size = new System.Drawing.Size(154, 23);
            this.TeamID.TabIndex = 10;
            this.TeamID.SelectionChangeCommitted += new System.EventHandler(this.TeamID_SelectionChangeCommitted);
            // 
            // AssignedUserID
            // 
            this.AssignedUserID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "AssignedUserID", true));
            this.AssignedUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssignedUserID.Enabled = false;
            this.AssignedUserID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedUserID.FormattingEnabled = true;
            this.AssignedUserID.Location = new System.Drawing.Point(72, 141);
            this.AssignedUserID.Margin = new System.Windows.Forms.Padding(0);
            this.AssignedUserID.Name = "AssignedUserID";
            this.AssignedUserID.Size = new System.Drawing.Size(154, 23);
            this.AssignedUserID.TabIndex = 11;
            this.AssignedUserID.Tag = "Sprint Task Detail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(this.taskSubstatusComboBox);
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
            this.groupBox1.Location = new System.Drawing.Point(524, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(228, 171);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // taskSubstatusComboBox
            // 
            this.taskSubstatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.sprintTaskBindingSource, "TaskSubStatus", true));
            this.taskSubstatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskSubstatusComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskSubstatusComboBox.FormattingEnabled = true;
            this.taskSubstatusComboBox.Location = new System.Drawing.Point(72, 41);
            this.taskSubstatusComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.taskSubstatusComboBox.Name = "taskSubstatusComboBox";
            this.taskSubstatusComboBox.Size = new System.Drawing.Size(154, 23);
            this.taskSubstatusComboBox.TabIndex = 7;
            // 
            // taskStatusComboBox
            // 
            this.taskStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.sprintTaskBindingSource, "TaskStatus", true));
            this.taskStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskStatusComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskStatusComboBox.FormattingEnabled = true;
            this.taskStatusComboBox.Location = new System.Drawing.Point(72, 16);
            this.taskStatusComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.taskStatusComboBox.Name = "taskStatusComboBox";
            this.taskStatusComboBox.Size = new System.Drawing.Size(154, 23);
            this.taskStatusComboBox.TabIndex = 6;
            this.taskStatusComboBox.SelectionChangeCommitted += new System.EventHandler(this.taskStatusComboBox_SelectionChangeCommitted);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(110, 57);
            this.descriptionTextBox.MaxLength = 2000;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(409, 107);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // addedByTextBox
            // 
            this.addedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "AddedBy", true));
            this.addedByTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedByTextBox.Location = new System.Drawing.Point(100, 225);
            this.addedByTextBox.Name = "addedByTextBox";
            this.addedByTextBox.ReadOnly = true;
            this.addedByTextBox.Size = new System.Drawing.Size(89, 23);
            this.addedByTextBox.TabIndex = 15;
            this.addedByTextBox.TabStop = false;
            // 
            // updatedByTextBox
            // 
            this.updatedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "UpdatedBy", true));
            this.updatedByTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedByTextBox.Location = new System.Drawing.Point(100, 248);
            this.updatedByTextBox.Name = "updatedByTextBox";
            this.updatedByTextBox.ReadOnly = true;
            this.updatedByTextBox.Size = new System.Drawing.Size(89, 23);
            this.updatedByTextBox.TabIndex = 16;
            this.updatedByTextBox.TabStop = false;
            // 
            // addedDateTimeTextBox
            // 
            this.addedDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "AddedDateTime", true));
            this.addedDateTimeTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedDateTimeTextBox.Location = new System.Drawing.Point(322, 225);
            this.addedDateTimeTextBox.Name = "addedDateTimeTextBox";
            this.addedDateTimeTextBox.ReadOnly = true;
            this.addedDateTimeTextBox.Size = new System.Drawing.Size(150, 23);
            this.addedDateTimeTextBox.TabIndex = 17;
            this.addedDateTimeTextBox.TabStop = false;
            // 
            // updatedDateTimeTextBox
            // 
            this.updatedDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "UpdatedDateTime", true));
            this.updatedDateTimeTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedDateTimeTextBox.Location = new System.Drawing.Point(322, 248);
            this.updatedDateTimeTextBox.Name = "updatedDateTimeTextBox";
            this.updatedDateTimeTextBox.ReadOnly = true;
            this.updatedDateTimeTextBox.Size = new System.Drawing.Size(150, 23);
            this.updatedDateTimeTextBox.TabIndex = 18;
            this.updatedDateTimeTextBox.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sprintTaskBindingSource, "TaskCompletionPercent", true));
            this.trackBar1.Enabled = false;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(270, 170);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(212, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lbCompletionPercent
            // 
            this.lbCompletionPercent.AutoSize = true;
            this.lbCompletionPercent.Location = new System.Drawing.Point(488, 174);
            this.lbCompletionPercent.Name = "lbCompletionPercent";
            this.lbCompletionPercent.Size = new System.Drawing.Size(0, 13);
            this.lbCompletionPercent.TabIndex = 22;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.Delete,
            this.NoteText,
            this.AddedBy,
            this.AddedDateTime,
            this.SprintTaskNoteID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotes.Location = new System.Drawing.Point(12, 288);
            this.dgvNotes.MultiSelect = false;
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.RowHeadersVisible = false;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(759, 150);
            this.dgvNotes.TabIndex = 24;
            this.dgvNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellContentClick);
            // 
            // View
            // 
            this.View.FillWeight = 35F;
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 35F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // NoteText
            // 
            this.NoteText.DataPropertyName = "NoteText";
            this.NoteText.FillWeight = 180F;
            this.NoteText.HeaderText = "Note";
            this.NoteText.Name = "NoteText";
            this.NoteText.ReadOnly = true;
            // 
            // AddedBy
            // 
            this.AddedBy.DataPropertyName = "AddedBy";
            this.AddedBy.FillWeight = 65F;
            this.AddedBy.HeaderText = "Added By";
            this.AddedBy.Name = "AddedBy";
            this.AddedBy.ReadOnly = true;
            // 
            // AddedDateTime
            // 
            this.AddedDateTime.DataPropertyName = "AddedDateTime";
            dataGridViewCellStyle2.NullValue = null;
            this.AddedDateTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.AddedDateTime.FillWeight = 80F;
            this.AddedDateTime.HeaderText = "Added Date/Time";
            this.AddedDateTime.Name = "AddedDateTime";
            this.AddedDateTime.ReadOnly = true;
            // 
            // SprintTaskNoteID
            // 
            this.SprintTaskNoteID.DataPropertyName = "SprintTaskNoteID";
            this.SprintTaskNoteID.HeaderText = "SprintTaskNoteID";
            this.SprintTaskNoteID.Name = "SprintTaskNoteID";
            this.SprintTaskNoteID.ReadOnly = true;
            this.SprintTaskNoteID.Visible = false;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Enabled = false;
            this.btnAddNote.Location = new System.Drawing.Point(12, 444);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 25;
            this.btnAddNote.Text = "&Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // storyPointsTextBox
            // 
            this.storyPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "StoryPoints", true));
            this.storyPointsTextBox.Location = new System.Drawing.Point(110, 170);
            this.storyPointsTextBox.Mask = "999";
            this.storyPointsTextBox.Name = "storyPointsTextBox";
            this.storyPointsTextBox.PromptChar = ' ';
            this.storyPointsTextBox.Size = new System.Drawing.Size(40, 20);
            this.storyPointsTextBox.TabIndex = 4;
            // 
            // TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(794, 475);
            this.Controls.Add(this.storyPointsTextBox);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbCompletionPercent);
            this.Controls.Add(label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(updatedDateTimeLabel);
            this.Controls.Add(this.updatedDateTimeTextBox);
            this.Controls.Add(addedDateTimeLabel);
            this.Controls.Add(this.addedDateTimeTextBox);
            this.Controls.Add(updatedByLabel);
            this.Controls.Add(this.updatedByTextBox);
            this.Controls.Add(addedByLabel);
            this.Controls.Add(this.addedByTextBox);
            this.Controls.Add(storyPointsLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SprintTaskID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sprint Task-Detail";
            this.Load += new System.EventHandler(this.TaskDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sprintTaskBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
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
        private System.Windows.Forms.TextBox addedByTextBox;
        private System.Windows.Forms.TextBox updatedByTextBox;
        private System.Windows.Forms.TextBox addedDateTimeTextBox;
        private System.Windows.Forms.TextBox updatedDateTimeTextBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbCompletionPercent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ComboBox taskSubstatusComboBox;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteText;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SprintTaskNoteID;
        private System.Windows.Forms.MaskedTextBox storyPointsTextBox;
    }
}