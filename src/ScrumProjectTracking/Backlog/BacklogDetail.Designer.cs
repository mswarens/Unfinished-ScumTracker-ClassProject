namespace ScrumProjectTracking.Backlog
{
    partial class BacklogDetail
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
            System.Windows.Forms.Label updatedDateTimeLabel;
            System.Windows.Forms.Label addedDateTimeLabel;
            System.Windows.Forms.Label updatedByLabel;
            System.Windows.Forms.Label addedByLabel;
            System.Windows.Forms.Label storyNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BacklogDetail));
            System.Windows.Forms.Label storyIDLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cbProjectID = new System.Windows.Forms.ComboBox();
            this.storyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.lbCompletionPercent = new System.Windows.Forms.Label();
            this.updatedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.addedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.updatedByTextBox = new System.Windows.Forms.TextBox();
            this.addedByTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.userStoryTextBox = new System.Windows.Forms.RichTextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.storyNameTextBox = new System.Windows.Forms.TextBox();
            this.storyIDTextBox = new System.Windows.Forms.TextBox();
            updatedDateTimeLabel = new System.Windows.Forms.Label();
            addedDateTimeLabel = new System.Windows.Forms.Label();
            updatedByLabel = new System.Windows.Forms.Label();
            addedByLabel = new System.Windows.Forms.Label();
            storyNameLabel = new System.Windows.Forms.Label();
            storyIDLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updatedDateTimeLabel
            // 
            updatedDateTimeLabel.AutoSize = true;
            updatedDateTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updatedDateTimeLabel.Location = new System.Drawing.Point(186, 331);
            updatedDateTimeLabel.Name = "updatedDateTimeLabel";
            updatedDateTimeLabel.Size = new System.Drawing.Size(115, 15);
            updatedDateTimeLabel.TabIndex = 52;
            updatedDateTimeLabel.Text = "Updated Date/Time:";
            // 
            // addedDateTimeLabel
            // 
            addedDateTimeLabel.AutoSize = true;
            addedDateTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addedDateTimeLabel.Location = new System.Drawing.Point(186, 309);
            addedDateTimeLabel.Name = "addedDateTimeLabel";
            addedDateTimeLabel.Size = new System.Drawing.Size(103, 15);
            addedDateTimeLabel.TabIndex = 50;
            addedDateTimeLabel.Text = "Added Date/Time:";
            // 
            // updatedByLabel
            // 
            updatedByLabel.AutoSize = true;
            updatedByLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updatedByLabel.Location = new System.Drawing.Point(9, 331);
            updatedByLabel.Name = "updatedByLabel";
            updatedByLabel.Size = new System.Drawing.Size(72, 15);
            updatedByLabel.TabIndex = 48;
            updatedByLabel.Text = "Updated By:";
            // 
            // addedByLabel
            // 
            addedByLabel.AutoSize = true;
            addedByLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addedByLabel.Location = new System.Drawing.Point(9, 309);
            addedByLabel.Name = "addedByLabel";
            addedByLabel.Size = new System.Drawing.Size(60, 15);
            addedByLabel.TabIndex = 46;
            addedByLabel.Text = "Added By:";
            // 
            // storyNameLabel
            // 
            storyNameLabel.AutoSize = true;
            storyNameLabel.Location = new System.Drawing.Point(152, 35);
            storyNameLabel.Name = "storyNameLabel";
            storyNameLabel.Size = new System.Drawing.Size(69, 15);
            storyNameLabel.TabIndex = 57;
            storyNameLabel.Text = "Story Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label2.Location = new System.Drawing.Point(9, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Story Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label6.Location = new System.Drawing.Point(197, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Est. Story Points";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label7.Location = new System.Drawing.Point(9, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Priority";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 25);
            this.toolStrip1.TabIndex = 42;
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
            // cbProjectID
            // 
            this.cbProjectID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.storyBindingSource, "ProjectID", true));
            this.cbProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectID.FormattingEnabled = true;
            this.cbProjectID.Location = new System.Drawing.Point(64, 221);
            this.cbProjectID.Name = "cbProjectID";
            this.cbProjectID.Size = new System.Drawing.Size(121, 22);
            this.cbProjectID.TabIndex = 3;
            // 
            // storyBindingSource
            // 
            this.storyBindingSource.DataSource = typeof(ScrumProjectTracking.DataAccess.Story);
            // 
            // cbPriority
            // 
            this.cbPriority.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.storyBindingSource, "Priority", true));
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High",
            "Critical"});
            this.cbPriority.Location = new System.Drawing.Point(64, 252);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(121, 22);
            this.cbPriority.TabIndex = 6;
            // 
            // lbCompletionPercent
            // 
            this.lbCompletionPercent.AutoSize = true;
            this.lbCompletionPercent.Location = new System.Drawing.Point(427, 307);
            this.lbCompletionPercent.Name = "lbCompletionPercent";
            this.lbCompletionPercent.Size = new System.Drawing.Size(0, 15);
            this.lbCompletionPercent.TabIndex = 54;
            // 
            // updatedDateTimeTextBox
            // 
            this.updatedDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storyBindingSource, "UpdatedDateTime", true));
            this.updatedDateTimeTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedDateTimeTextBox.Location = new System.Drawing.Point(307, 331);
            this.updatedDateTimeTextBox.Name = "updatedDateTimeTextBox";
            this.updatedDateTimeTextBox.ReadOnly = true;
            this.updatedDateTimeTextBox.Size = new System.Drawing.Size(150, 23);
            this.updatedDateTimeTextBox.TabIndex = 53;
            this.updatedDateTimeTextBox.TabStop = false;
            // 
            // addedDateTimeTextBox
            // 
            this.addedDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storyBindingSource, "AddedDateTime", true));
            this.addedDateTimeTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedDateTimeTextBox.Location = new System.Drawing.Point(307, 306);
            this.addedDateTimeTextBox.Name = "addedDateTimeTextBox";
            this.addedDateTimeTextBox.ReadOnly = true;
            this.addedDateTimeTextBox.Size = new System.Drawing.Size(150, 23);
            this.addedDateTimeTextBox.TabIndex = 51;
            this.addedDateTimeTextBox.TabStop = false;
            // 
            // updatedByTextBox
            // 
            this.updatedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storyBindingSource, "UpdatedBy", true));
            this.updatedByTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedByTextBox.Location = new System.Drawing.Point(85, 331);
            this.updatedByTextBox.Name = "updatedByTextBox";
            this.updatedByTextBox.ReadOnly = true;
            this.updatedByTextBox.Size = new System.Drawing.Size(89, 23);
            this.updatedByTextBox.TabIndex = 49;
            this.updatedByTextBox.TabStop = false;
            // 
            // addedByTextBox
            // 
            this.addedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storyBindingSource, "AddedBy", true));
            this.addedByTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedByTextBox.Location = new System.Drawing.Point(85, 306);
            this.addedByTextBox.Name = "addedByTextBox";
            this.addedByTextBox.ReadOnly = true;
            this.addedByTextBox.Size = new System.Drawing.Size(89, 23);
            this.addedByTextBox.TabIndex = 47;
            this.addedByTextBox.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storyBindingSource, "StoryPoints", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(298, 221);
            this.maskedTextBox1.Mask = "999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(29, 23);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // userStoryTextBox
            // 
            this.userStoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storyBindingSource, "UserStory", true));
            this.userStoryTextBox.Location = new System.Drawing.Point(12, 93);
            this.userStoryTextBox.MaxLength = 1000;
            this.userStoryTextBox.Name = "userStoryTextBox";
            this.userStoryTextBox.Size = new System.Drawing.Size(582, 122);
            this.userStoryTextBox.TabIndex = 2;
            this.userStoryTextBox.Text = "";
            // 
            // cbStatus
            // 
            this.cbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.storyBindingSource, "Status", true));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "New",
            "In Review",
            "Sprint Task Created",
            "Cancelled"});
            this.cbStatus.Location = new System.Drawing.Point(397, 221);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(160, 22);
            this.cbStatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label1.Location = new System.Drawing.Point(342, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "Status";
            // 
            // storyNameTextBox
            // 
            this.storyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storyBindingSource, "StoryName", true));
            this.storyNameTextBox.Location = new System.Drawing.Point(230, 32);
            this.storyNameTextBox.Name = "storyNameTextBox";
            this.storyNameTextBox.Size = new System.Drawing.Size(293, 23);
            this.storyNameTextBox.TabIndex = 1;
            // 
            // storyIDLabel
            // 
            storyIDLabel.AutoSize = true;
            storyIDLabel.Location = new System.Drawing.Point(12, 35);
            storyIDLabel.Name = "storyIDLabel";
            storyIDLabel.Size = new System.Drawing.Size(53, 15);
            storyIDLabel.TabIndex = 57;
            storyIDLabel.Text = "Story ID:";
            // 
            // storyIDTextBox
            // 
            this.storyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storyBindingSource, "StoryID", true));
            this.storyIDTextBox.Location = new System.Drawing.Point(71, 32);
            this.storyIDTextBox.Name = "storyIDTextBox";
            this.storyIDTextBox.ReadOnly = true;
            this.storyIDTextBox.Size = new System.Drawing.Size(61, 23);
            this.storyIDTextBox.TabIndex = 58;
            this.storyIDTextBox.TabStop = false;
            // 
            // BacklogDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(651, 375);
            this.ControlBox = false;
            this.Controls.Add(storyIDLabel);
            this.Controls.Add(this.storyIDTextBox);
            this.Controls.Add(storyNameLabel);
            this.Controls.Add(this.storyNameTextBox);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lbCompletionPercent);
            this.Controls.Add(updatedDateTimeLabel);
            this.Controls.Add(this.updatedDateTimeTextBox);
            this.Controls.Add(addedDateTimeLabel);
            this.Controls.Add(this.addedDateTimeTextBox);
            this.Controls.Add(updatedByLabel);
            this.Controls.Add(this.updatedByTextBox);
            this.Controls.Add(addedByLabel);
            this.Controls.Add(this.addedByTextBox);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.cbProjectID);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.userStoryTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BacklogDetail";
            this.Text = "Backlog-Detail";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ComboBox cbProjectID;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label lbCompletionPercent;
        private System.Windows.Forms.TextBox updatedDateTimeTextBox;
        private System.Windows.Forms.TextBox addedDateTimeTextBox;
        private System.Windows.Forms.TextBox updatedByTextBox;
        private System.Windows.Forms.TextBox addedByTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RichTextBox userStoryTextBox;
        private System.Windows.Forms.BindingSource storyBindingSource;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox storyNameTextBox;
        private System.Windows.Forms.TextBox storyIDTextBox;
    }
}