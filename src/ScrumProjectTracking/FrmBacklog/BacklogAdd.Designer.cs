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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userStoryTextBox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.projectIDTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.storyPointsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ProjectID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "User Story - 200 Chars Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Story Points";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Priority";
            // 
            // userStoryTextBox
            // 
            this.userStoryTextBox.Location = new System.Drawing.Point(119, 221);
            this.userStoryTextBox.Name = "userStoryTextBox";
            this.userStoryTextBox.Size = new System.Drawing.Size(564, 56);
            this.userStoryTextBox.TabIndex = 22;
            this.userStoryTextBox.Text = "";
            this.userStoryTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(100, 401);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(623, 23);
            this.submitButton.TabIndex = 28;
            this.submitButton.Text = "Submit New Backlog User Story";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(246, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Add New Backlog User Stories Here";
            // 
            // projectIDTextBox
            // 
            this.projectIDTextBox.Location = new System.Drawing.Point(184, 308);
            this.projectIDTextBox.Name = "projectIDTextBox";
            this.projectIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.projectIDTextBox.TabIndex = 30;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.Location = new System.Drawing.Point(552, 309);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(100, 20);
            this.priorityTextBox.TabIndex = 31;
            // 
            // storyPointsTextBox
            // 
            this.storyPointsTextBox.Location = new System.Drawing.Point(374, 309);
            this.storyPointsTextBox.Name = "storyPointsTextBox";
            this.storyPointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.storyPointsTextBox.TabIndex = 32;
            // 
            // BacklogAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.storyPointsTextBox);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(this.projectIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.userStoryTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "BacklogAdd";
            this.Text = "BacklogAdd";
            this.Load += new System.EventHandler(this.BacklogAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox userStoryTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox projectIDTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox storyPointsTextBox;
    }
}