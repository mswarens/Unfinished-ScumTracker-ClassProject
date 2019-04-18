namespace ScrumProjectTracking.FrmBacklog
{
    partial class EditBacklog
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
            System.Windows.Forms.Label updatedDateTimeLabel;
            System.Windows.Forms.Label addedDateTimeLabel;
            System.Windows.Forms.Label updatedByLabel;
            System.Windows.Forms.Label addedByLabel;
            System.Windows.Forms.Label storyPointsLabel;
            System.Windows.Forms.Label storyLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label Team;
            System.Windows.Forms.Label PriorityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBacklog));
            this.storyPointsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lbCompletionPercent = new System.Windows.Forms.Label();
            this.updatedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.addedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.updatedByTextBox = new System.Windows.Forms.TextBox();
            this.addedByTextBox = new System.Windows.Forms.TextBox();
            this.UserStoryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProjectName = new System.Windows.Forms.ComboBox();
            this.BacklogIDLabel = new System.Windows.Forms.Label();
            this.BacklogIDInput = new System.Windows.Forms.TextBox();
            this.Priority = new System.Windows.Forms.MaskedTextBox();
            this.TeamIDTextBox = new System.Windows.Forms.MaskedTextBox();
            updatedDateTimeLabel = new System.Windows.Forms.Label();
            addedDateTimeLabel = new System.Windows.Forms.Label();
            updatedByLabel = new System.Windows.Forms.Label();
            addedByLabel = new System.Windows.Forms.Label();
            storyPointsLabel = new System.Windows.Forms.Label();
            storyLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            Team = new System.Windows.Forms.Label();
            PriorityLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updatedDateTimeLabel
            // 
            updatedDateTimeLabel.AutoSize = true;
            updatedDateTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updatedDateTimeLabel.Location = new System.Drawing.Point(248, 215);
            updatedDateTimeLabel.Name = "updatedDateTimeLabel";
            updatedDateTimeLabel.Size = new System.Drawing.Size(115, 15);
            updatedDateTimeLabel.TabIndex = 42;
            updatedDateTimeLabel.Text = "Updated Date/Time:";
            // 
            // addedDateTimeLabel
            // 
            addedDateTimeLabel.AutoSize = true;
            addedDateTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addedDateTimeLabel.Location = new System.Drawing.Point(248, 193);
            addedDateTimeLabel.Name = "addedDateTimeLabel";
            addedDateTimeLabel.Size = new System.Drawing.Size(103, 15);
            addedDateTimeLabel.TabIndex = 40;
            addedDateTimeLabel.Text = "Added Date/Time:";
            // 
            // updatedByLabel
            // 
            updatedByLabel.AutoSize = true;
            updatedByLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updatedByLabel.Location = new System.Drawing.Point(71, 215);
            updatedByLabel.Name = "updatedByLabel";
            updatedByLabel.Size = new System.Drawing.Size(72, 15);
            updatedByLabel.TabIndex = 38;
            updatedByLabel.Text = "Updated By:";
            // 
            // addedByLabel
            // 
            addedByLabel.AutoSize = true;
            addedByLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addedByLabel.Location = new System.Drawing.Point(71, 193);
            addedByLabel.Name = "addedByLabel";
            addedByLabel.Size = new System.Drawing.Size(60, 15);
            addedByLabel.TabIndex = 36;
            addedByLabel.Text = "Added By:";
            // 
            // storyPointsLabel
            // 
            storyPointsLabel.AutoSize = true;
            storyPointsLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            storyPointsLabel.Location = new System.Drawing.Point(181, 41);
            storyPointsLabel.Name = "storyPointsLabel";
            storyPointsLabel.Size = new System.Drawing.Size(76, 15);
            storyPointsLabel.TabIndex = 35;
            storyPointsLabel.Text = "Story Points:";
            // 
            // storyLabel
            // 
            storyLabel.AutoSize = true;
            storyLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            storyLabel.Location = new System.Drawing.Point(25, 68);
            storyLabel.Name = "storyLabel";
            storyLabel.Size = new System.Drawing.Size(66, 15);
            storyLabel.TabIndex = 34;
            storyLabel.Text = "User Story:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(2, 21);
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
            Team.Location = new System.Drawing.Point(418, 40);
            Team.Margin = new System.Windows.Forms.Padding(0);
            Team.Name = "Team";
            Team.Size = new System.Drawing.Size(53, 15);
            Team.TabIndex = 8;
            Team.Text = "Team ID:";
            // 
            // PriorityLabel
            // 
            PriorityLabel.AutoSize = true;
            PriorityLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PriorityLabel.Location = new System.Drawing.Point(311, 41);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.Size = new System.Drawing.Size(52, 15);
            PriorityLabel.TabIndex = 48;
            PriorityLabel.Text = "Priority:";
            // 
            // storyPointsTextBox
            // 
            this.storyPointsTextBox.Location = new System.Drawing.Point(263, 38);
            this.storyPointsTextBox.Mask = "999";
            this.storyPointsTextBox.Name = "storyPointsTextBox";
            this.storyPointsTextBox.PromptChar = ' ';
            this.storyPointsTextBox.Size = new System.Drawing.Size(40, 23);
            this.storyPointsTextBox.TabIndex = 31;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 25);
            this.toolStrip1.TabIndex = 46;
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
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // lbCompletionPercent
            // 
            this.lbCompletionPercent.AutoSize = true;
            this.lbCompletionPercent.Location = new System.Drawing.Point(489, 191);
            this.lbCompletionPercent.Name = "lbCompletionPercent";
            this.lbCompletionPercent.Size = new System.Drawing.Size(0, 15);
            this.lbCompletionPercent.TabIndex = 45;
            // 
            // updatedDateTimeTextBox
            // 
            this.updatedDateTimeTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedDateTimeTextBox.Location = new System.Drawing.Point(369, 215);
            this.updatedDateTimeTextBox.Name = "updatedDateTimeTextBox";
            this.updatedDateTimeTextBox.ReadOnly = true;
            this.updatedDateTimeTextBox.Size = new System.Drawing.Size(150, 23);
            this.updatedDateTimeTextBox.TabIndex = 43;
            this.updatedDateTimeTextBox.TabStop = false;
            // 
            // addedDateTimeTextBox
            // 
            this.addedDateTimeTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedDateTimeTextBox.Location = new System.Drawing.Point(369, 190);
            this.addedDateTimeTextBox.Name = "addedDateTimeTextBox";
            this.addedDateTimeTextBox.ReadOnly = true;
            this.addedDateTimeTextBox.Size = new System.Drawing.Size(150, 23);
            this.addedDateTimeTextBox.TabIndex = 41;
            this.addedDateTimeTextBox.TabStop = false;
            // 
            // updatedByTextBox
            // 
            this.updatedByTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedByTextBox.Location = new System.Drawing.Point(147, 215);
            this.updatedByTextBox.Name = "updatedByTextBox";
            this.updatedByTextBox.ReadOnly = true;
            this.updatedByTextBox.Size = new System.Drawing.Size(89, 23);
            this.updatedByTextBox.TabIndex = 39;
            this.updatedByTextBox.TabStop = false;
            // 
            // addedByTextBox
            // 
            this.addedByTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedByTextBox.Location = new System.Drawing.Point(147, 190);
            this.addedByTextBox.Name = "addedByTextBox";
            this.addedByTextBox.ReadOnly = true;
            this.addedByTextBox.Size = new System.Drawing.Size(89, 23);
            this.addedByTextBox.TabIndex = 37;
            this.addedByTextBox.TabStop = false;
            // 
            // UserStoryTextBox
            // 
            this.UserStoryTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserStoryTextBox.Location = new System.Drawing.Point(111, 65);
            this.UserStoryTextBox.MaxLength = 2000;
            this.UserStoryTextBox.Multiline = true;
            this.UserStoryTextBox.Name = "UserStoryTextBox";
            this.UserStoryTextBox.Size = new System.Drawing.Size(409, 115);
            this.UserStoryTextBox.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.ProjectName);
            this.groupBox1.Location = new System.Drawing.Point(536, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(241, 54);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // ProjectName
            // 
            this.ProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.FormattingEnabled = true;
            this.ProjectName.Location = new System.Drawing.Point(72, 18);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(154, 23);
            this.ProjectName.TabIndex = 9;
            // 
            // BacklogIDLabel
            // 
            this.BacklogIDLabel.AutoSize = true;
            this.BacklogIDLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklogIDLabel.Location = new System.Drawing.Point(25, 41);
            this.BacklogIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BacklogIDLabel.Name = "BacklogIDLabel";
            this.BacklogIDLabel.Size = new System.Drawing.Size(65, 15);
            this.BacklogIDLabel.TabIndex = 27;
            this.BacklogIDLabel.Text = "Backlog ID";
            // 
            // BacklogIDInput
            // 
            this.BacklogIDInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BacklogIDInput.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklogIDInput.Location = new System.Drawing.Point(111, 38);
            this.BacklogIDInput.Margin = new System.Windows.Forms.Padding(2);
            this.BacklogIDInput.Name = "BacklogIDInput";
            this.BacklogIDInput.ReadOnly = true;
            this.BacklogIDInput.Size = new System.Drawing.Size(55, 23);
            this.BacklogIDInput.TabIndex = 26;
            this.BacklogIDInput.TabStop = false;
            // 
            // Priority
            // 
            this.Priority.Location = new System.Drawing.Point(369, 38);
            this.Priority.Mask = "999";
            this.Priority.Name = "Priority";
            this.Priority.PromptChar = ' ';
            this.Priority.Size = new System.Drawing.Size(40, 23);
            this.Priority.TabIndex = 47;
            // 
            // TeamIDTextBox
            // 
            this.TeamIDTextBox.Location = new System.Drawing.Point(474, 38);
            this.TeamIDTextBox.Mask = "999";
            this.TeamIDTextBox.Name = "TeamIDTextBox";
            this.TeamIDTextBox.PromptChar = ' ';
            this.TeamIDTextBox.Size = new System.Drawing.Size(40, 23);
            this.TeamIDTextBox.TabIndex = 49;
            // 
            // EditBacklog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 312);
            this.Controls.Add(this.TeamIDTextBox);
            this.Controls.Add(this.Priority);
            this.Controls.Add(PriorityLabel);
            this.Controls.Add(this.storyPointsTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(Team);
            this.Controls.Add(this.lbCompletionPercent);
            this.Controls.Add(updatedDateTimeLabel);
            this.Controls.Add(this.updatedDateTimeTextBox);
            this.Controls.Add(addedDateTimeLabel);
            this.Controls.Add(this.addedDateTimeTextBox);
            this.Controls.Add(updatedByLabel);
            this.Controls.Add(this.updatedByTextBox);
            this.Controls.Add(addedByLabel);
            this.Controls.Add(this.addedByTextBox);
            this.Controls.Add(storyPointsLabel);
            this.Controls.Add(storyLabel);
            this.Controls.Add(this.UserStoryTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BacklogIDLabel);
            this.Controls.Add(this.BacklogIDInput);
            this.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditBacklog";
            this.Text = "Edit Backlog Item";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox storyPointsTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.Label lbCompletionPercent;
        private System.Windows.Forms.TextBox updatedDateTimeTextBox;
        private System.Windows.Forms.TextBox addedDateTimeTextBox;
        private System.Windows.Forms.TextBox updatedByTextBox;
        private System.Windows.Forms.TextBox addedByTextBox;
        private System.Windows.Forms.TextBox UserStoryTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ProjectName;
        private System.Windows.Forms.Label BacklogIDLabel;
        private System.Windows.Forms.TextBox BacklogIDInput;
        private System.Windows.Forms.MaskedTextBox Priority;
        private System.Windows.Forms.MaskedTextBox TeamIDTextBox;
    }
}