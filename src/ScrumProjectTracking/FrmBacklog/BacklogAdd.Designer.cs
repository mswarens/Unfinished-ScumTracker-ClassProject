namespace ScrumProjectTracking.FrmBacklog
{
    partial class BacklogAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BacklogAdd));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userStoryTextBox = new System.Windows.Forms.RichTextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.storyPointsTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.projectNameTextBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label2.Location = new System.Drawing.Point(1, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Project Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label3.Location = new System.Drawing.Point(198, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "User Story - 200 Chars Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label6.Location = new System.Drawing.Point(217, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Story Points";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label7.Location = new System.Drawing.Point(419, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Priority";
            // 
            // userStoryTextBox
            // 
            this.userStoryTextBox.Location = new System.Drawing.Point(12, 50);
            this.userStoryTextBox.Name = "userStoryTextBox";
            this.userStoryTextBox.Size = new System.Drawing.Size(564, 60);
            this.userStoryTextBox.TabIndex = 22;
            this.userStoryTextBox.Text = "";
            this.userStoryTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.Location = new System.Drawing.Point(474, 144);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(100, 23);
            this.priorityTextBox.TabIndex = 31;
            // 
            // storyPointsTextBox
            // 
            this.storyPointsTextBox.Location = new System.Drawing.Point(296, 144);
            this.storyPointsTextBox.Name = "storyPointsTextBox";
            this.storyPointsTextBox.Size = new System.Drawing.Size(100, 23);
            this.storyPointsTextBox.TabIndex = 32;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 25);
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
            // projectNameTextBox
            // 
            this.projectNameTextBox.FormattingEnabled = true;
            this.projectNameTextBox.Location = new System.Drawing.Point(90, 143);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.projectNameTextBox.TabIndex = 43;
            this.projectNameTextBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BacklogAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(633, 242);
            this.ControlBox = false;
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.storyPointsTextBox);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(this.userStoryTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BacklogAdd";
            this.Text = "Backlog Add";
            this.Load += new System.EventHandler(this.BacklogAdd_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox userStoryTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox storyPointsTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ComboBox projectNameTextBox;
    }
}