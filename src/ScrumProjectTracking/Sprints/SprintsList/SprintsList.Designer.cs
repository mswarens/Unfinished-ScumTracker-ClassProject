namespace ScrumProjectTracking.Sprints.SprintsList
{
    partial class SprintsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Tasks = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SprintName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalStoryPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedTasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedStoryPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PendingTasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PendingStoryPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SprintID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEndDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSprintName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Tasks,
            this.SprintName,
            this.BeginDate,
            this.EndDate,
            this.TotalTasks,
            this.TotalStoryPoints,
            this.CompletedTasks,
            this.CompletedStoryPoints,
            this.PendingTasks,
            this.PendingStoryPoints,
            this.SprintID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(944, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 23.88449F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Tasks
            // 
            this.Tasks.FillWeight = 23.46454F;
            this.Tasks.HeaderText = "Tasks";
            this.Tasks.Name = "Tasks";
            this.Tasks.ReadOnly = true;
            // 
            // SprintName
            // 
            this.SprintName.DataPropertyName = "SprintName";
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SprintName.DefaultCellStyle = dataGridViewCellStyle41;
            this.SprintName.HeaderText = "Sprint Name";
            this.SprintName.MinimumWidth = 35;
            this.SprintName.Name = "SprintName";
            this.SprintName.ReadOnly = true;
            this.SprintName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BeginDate
            // 
            this.BeginDate.DataPropertyName = "BeginDate";
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginDate.DefaultCellStyle = dataGridViewCellStyle42;
            this.BeginDate.FillWeight = 28.97984F;
            this.BeginDate.HeaderText = "Begin Date";
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.ReadOnly = true;
            this.BeginDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.DefaultCellStyle = dataGridViewCellStyle43;
            this.EndDate.FillWeight = 28.97984F;
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalTasks
            // 
            this.TotalTasks.DataPropertyName = "TotalTasks";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTasks.DefaultCellStyle = dataGridViewCellStyle44;
            this.TotalTasks.FillWeight = 28.97984F;
            this.TotalTasks.HeaderText = "Total Tasks";
            this.TotalTasks.Name = "TotalTasks";
            this.TotalTasks.ReadOnly = true;
            this.TotalTasks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalStoryPoints
            // 
            this.TotalStoryPoints.DataPropertyName = "TotalStoryPoints";
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStoryPoints.DefaultCellStyle = dataGridViewCellStyle45;
            this.TotalStoryPoints.FillWeight = 28.97984F;
            this.TotalStoryPoints.HeaderText = "Total Story Points";
            this.TotalStoryPoints.Name = "TotalStoryPoints";
            this.TotalStoryPoints.ReadOnly = true;
            this.TotalStoryPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CompletedTasks
            // 
            this.CompletedTasks.DataPropertyName = "CompletedTasks";
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedTasks.DefaultCellStyle = dataGridViewCellStyle46;
            this.CompletedTasks.FillWeight = 28.97984F;
            this.CompletedTasks.HeaderText = "Completed Tasks";
            this.CompletedTasks.Name = "CompletedTasks";
            this.CompletedTasks.ReadOnly = true;
            this.CompletedTasks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CompletedStoryPoints
            // 
            this.CompletedStoryPoints.DataPropertyName = "CompletedStoryPoints";
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedStoryPoints.DefaultCellStyle = dataGridViewCellStyle47;
            this.CompletedStoryPoints.FillWeight = 28.97984F;
            this.CompletedStoryPoints.HeaderText = "Completed Story Points";
            this.CompletedStoryPoints.Name = "CompletedStoryPoints";
            this.CompletedStoryPoints.ReadOnly = true;
            this.CompletedStoryPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PendingTasks
            // 
            this.PendingTasks.DataPropertyName = "PendingTasks";
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingTasks.DefaultCellStyle = dataGridViewCellStyle48;
            this.PendingTasks.FillWeight = 28.97984F;
            this.PendingTasks.HeaderText = "Pending Tasks";
            this.PendingTasks.Name = "PendingTasks";
            this.PendingTasks.ReadOnly = true;
            this.PendingTasks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PendingStoryPoints
            // 
            this.PendingStoryPoints.DataPropertyName = "PendingStoryPoints";
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingStoryPoints.DefaultCellStyle = dataGridViewCellStyle49;
            this.PendingStoryPoints.FillWeight = 28.97984F;
            this.PendingStoryPoints.HeaderText = "Pending Story Points";
            this.PendingStoryPoints.Name = "PendingStoryPoints";
            this.PendingStoryPoints.ReadOnly = true;
            this.PendingStoryPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SprintID
            // 
            this.SprintID.DataPropertyName = "SprintID";
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SprintID.DefaultCellStyle = dataGridViewCellStyle50;
            this.SprintID.HeaderText = "SprintID";
            this.SprintID.Name = "SprintID";
            this.SprintID.ReadOnly = true;
            this.SprintID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSprintName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEndDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // tbEndDate
            // 
            this.tbEndDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndDate.Location = new System.Drawing.Point(87, 45);
            this.tbEndDate.Mask = "00/00/0000";
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(72, 23);
            this.tbEndDate.TabIndex = 0;
            this.tbEndDate.ValidatingType = typeof(System.DateTime);
            this.tbEndDate.Validated += new System.EventHandler(this.tbEndDate_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "End Date >=";
            // 
            // tbSprintName
            // 
            this.tbSprintName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSprintName.Location = new System.Drawing.Point(87, 19);
            this.tbSprintName.Name = "tbSprintName";
            this.tbSprintName.Size = new System.Drawing.Size(161, 23);
            this.tbSprintName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sprint Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(254, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SprintsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(944, 402);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SprintsList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sprints";
            this.Load += new System.EventHandler(this.SprintsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn SprintName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalStoryPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletedTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletedStoryPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn PendingTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn PendingStoryPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn SprintID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSprintName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbEndDate;
    }
}