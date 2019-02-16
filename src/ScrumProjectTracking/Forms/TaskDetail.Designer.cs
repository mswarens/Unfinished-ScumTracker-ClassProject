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
            this.SprintTaskID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.sprintTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SprintID = new System.Windows.Forms.ComboBox();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            sprintIDLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            Team = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sprintTaskBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SprintTaskID
            // 
            this.SprintTaskID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SprintTaskID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "SprintTaskID", true));
            this.SprintTaskID.Location = new System.Drawing.Point(208, 23);
            this.SprintTaskID.Name = "SprintTaskID";
            this.SprintTaskID.ReadOnly = true;
            this.SprintTaskID.Size = new System.Drawing.Size(126, 31);
            this.SprintTaskID.TabIndex = 0;
            this.SprintTaskID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sprint Task ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(364, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Name";
            // 
            // TaskName
            // 
            this.TaskName.BackColor = System.Drawing.SystemColors.Window;
            this.TaskName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintTaskBindingSource, "TaskName", true));
            this.TaskName.Location = new System.Drawing.Point(491, 26);
            this.TaskName.MaxLength = 100;
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(342, 31);
            this.TaskName.TabIndex = 2;
            this.TaskName.TabStop = false;
            // 
            // sprintTaskBindingSource
            // 
            this.sprintTaskBindingSource.DataSource = typeof(ScrumProjectTracking.DataModels.SprintTask);
            // 
            // sprintIDLabel
            // 
            sprintIDLabel.AutoSize = true;
            sprintIDLabel.Location = new System.Drawing.Point(6, 36);
            sprintIDLabel.Name = "sprintIDLabel";
            sprintIDLabel.Size = new System.Drawing.Size(68, 25);
            sprintIDLabel.TabIndex = 4;
            sprintIDLabel.Text = "Sprint";
            // 
            // SprintID
            // 
            this.SprintID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "SprintID", true));
            this.SprintID.FormattingEnabled = true;
            this.SprintID.Location = new System.Drawing.Point(125, 33);
            this.SprintID.Name = "SprintID";
            this.SprintID.Size = new System.Drawing.Size(249, 33);
            this.SprintID.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 75);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 25);
            label3.TabIndex = 6;
            label3.Text = "Project";
            // 
            // ProjectID
            // 
            this.ProjectID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "ProjectID", true));
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(125, 72);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(249, 33);
            this.ProjectID.TabIndex = 7;
            // 
            // Team
            // 
            Team.AutoSize = true;
            Team.Location = new System.Drawing.Point(6, 114);
            Team.Name = "Team";
            Team.Size = new System.Drawing.Size(66, 25);
            Team.TabIndex = 8;
            Team.Text = "Team";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "TeamID", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 153);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 25);
            label4.TabIndex = 10;
            label4.Text = "Assignee";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sprintTaskBindingSource, "TeamID", true));
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 150);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(249, 33);
            this.comboBox2.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.SprintID);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(sprintIDLabel);
            this.groupBox1.Controls.Add(Team);
            this.groupBox1.Controls.Add(this.ProjectID);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(926, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 212);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 464);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SprintTaskID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sprint Task Detail";
            ((System.ComponentModel.ISupportInitialize)(this.sprintTaskBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}