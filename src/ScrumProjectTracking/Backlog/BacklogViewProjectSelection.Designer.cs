namespace ScrumProjectTracking.Backlog
{
    partial class BacklogViewProjectSelection
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectBeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PendingStoryCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectItem,
            this.ProjectName,
            this.ProjectBeginDate,
            this.ProjectEndDate,
            this.PendingStoryCount,
            this.ProjectID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 392);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SelectItem
            // 
            this.SelectItem.FillWeight = 30F;
            this.SelectItem.HeaderText = "Select";
            this.SelectItem.MinimumWidth = 15;
            this.SelectItem.Name = "SelectItem";
            this.SelectItem.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.FillWeight = 130F;
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // ProjectBeginDate
            // 
            this.ProjectBeginDate.DataPropertyName = "ProjectBeginDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.ProjectBeginDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProjectBeginDate.HeaderText = "Project Begin Date";
            this.ProjectBeginDate.Name = "ProjectBeginDate";
            this.ProjectBeginDate.ReadOnly = true;
            // 
            // ProjectEndDate
            // 
            this.ProjectEndDate.DataPropertyName = "ProjectEndDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ProjectEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectEndDate.HeaderText = "Project End Date";
            this.ProjectEndDate.Name = "ProjectEndDate";
            this.ProjectEndDate.ReadOnly = true;
            // 
            // PendingStoryCount
            // 
            this.PendingStoryCount.DataPropertyName = "PendingStoryCount";
            this.PendingStoryCount.FillWeight = 50F;
            this.PendingStoryCount.HeaderText = "Pending Story Count";
            this.PendingStoryCount.Name = "PendingStoryCount";
            this.PendingStoryCount.ReadOnly = true;
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "ProjectID";
            this.ProjectID.HeaderText = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            this.ProjectID.Visible = false;
            // 
            // BacklogViewProjectSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 392);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BacklogViewProjectSelection";
            this.Text = "Backlog-Project List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn SelectItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectBeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PendingStoryCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
    }
}