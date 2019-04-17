namespace ScrumProjectTracking.Sprints.SprintDetail
{
    partial class SprintDetail
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
            System.Windows.Forms.Label sprintNameLabel;
            System.Windows.Forms.Label beginDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label updatedDateTimeLabel;
            System.Windows.Forms.Label addedDateTimeLabel;
            System.Windows.Forms.Label updatedByLabel;
            System.Windows.Forms.Label addedByLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprintDetail));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sprintIDTextBox = new System.Windows.Forms.TextBox();
            this.sprintNameTextBox = new System.Windows.Forms.TextBox();
            this.beginDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.endDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.updatedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.addedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.updatedByTextBox = new System.Windows.Forms.TextBox();
            this.addedByTextBox = new System.Windows.Forms.TextBox();
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sprintIDLabel = new System.Windows.Forms.Label();
            sprintNameLabel = new System.Windows.Forms.Label();
            beginDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            updatedDateTimeLabel = new System.Windows.Forms.Label();
            addedDateTimeLabel = new System.Windows.Forms.Label();
            updatedByLabel = new System.Windows.Forms.Label();
            addedByLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sprintIDLabel
            // 
            sprintIDLabel.AutoSize = true;
            sprintIDLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sprintIDLabel.Location = new System.Drawing.Point(16, 39);
            sprintIDLabel.Name = "sprintIDLabel";
            sprintIDLabel.Size = new System.Drawing.Size(55, 15);
            sprintIDLabel.TabIndex = 25;
            sprintIDLabel.Text = "Sprint ID";
            // 
            // sprintNameLabel
            // 
            sprintNameLabel.AutoSize = true;
            sprintNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sprintNameLabel.Location = new System.Drawing.Point(184, 39);
            sprintNameLabel.Name = "sprintNameLabel";
            sprintNameLabel.Size = new System.Drawing.Size(74, 15);
            sprintNameLabel.TabIndex = 26;
            sprintNameLabel.Text = "Sprint Name";
            // 
            // beginDateLabel
            // 
            beginDateLabel.AutoSize = true;
            beginDateLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            beginDateLabel.Location = new System.Drawing.Point(16, 67);
            beginDateLabel.Name = "beginDateLabel";
            beginDateLabel.Size = new System.Drawing.Size(65, 15);
            beginDateLabel.TabIndex = 27;
            beginDateLabel.Text = "Begin Date";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endDateLabel.Location = new System.Drawing.Point(184, 67);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(55, 15);
            endDateLabel.TabIndex = 28;
            endDateLabel.Text = "End Date";
            // 
            // updatedDateTimeLabel
            // 
            updatedDateTimeLabel.AutoSize = true;
            updatedDateTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updatedDateTimeLabel.Location = new System.Drawing.Point(189, 127);
            updatedDateTimeLabel.Name = "updatedDateTimeLabel";
            updatedDateTimeLabel.Size = new System.Drawing.Size(115, 15);
            updatedDateTimeLabel.TabIndex = 35;
            updatedDateTimeLabel.Text = "Updated Date/Time:";
            // 
            // addedDateTimeLabel
            // 
            addedDateTimeLabel.AutoSize = true;
            addedDateTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addedDateTimeLabel.Location = new System.Drawing.Point(189, 107);
            addedDateTimeLabel.Name = "addedDateTimeLabel";
            addedDateTimeLabel.Size = new System.Drawing.Size(103, 15);
            addedDateTimeLabel.TabIndex = 33;
            addedDateTimeLabel.Text = "Added Date/Time:";
            // 
            // updatedByLabel
            // 
            updatedByLabel.AutoSize = true;
            updatedByLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updatedByLabel.Location = new System.Drawing.Point(12, 127);
            updatedByLabel.Name = "updatedByLabel";
            updatedByLabel.Size = new System.Drawing.Size(72, 15);
            updatedByLabel.TabIndex = 31;
            updatedByLabel.Text = "Updated By:";
            // 
            // addedByLabel
            // 
            addedByLabel.AutoSize = true;
            addedByLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addedByLabel.Location = new System.Drawing.Point(12, 107);
            addedByLabel.Name = "addedByLabel";
            addedByLabel.Size = new System.Drawing.Size(60, 15);
            addedByLabel.TabIndex = 30;
            addedByLabel.Text = "Added By:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(528, 25);
            this.toolStrip1.TabIndex = 24;
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
            // sprintIDTextBox
            // 
            this.sprintIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintBindingSource, "SprintID", true));
            this.sprintIDTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintIDTextBox.Location = new System.Drawing.Point(88, 36);
            this.sprintIDTextBox.MaxLength = 15;
            this.sprintIDTextBox.Name = "sprintIDTextBox";
            this.sprintIDTextBox.ReadOnly = true;
            this.sprintIDTextBox.Size = new System.Drawing.Size(43, 23);
            this.sprintIDTextBox.TabIndex = 26;
            this.sprintIDTextBox.TabStop = false;
            // 
            // sprintNameTextBox
            // 
            this.sprintNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintBindingSource, "SprintName", true));
            this.sprintNameTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintNameTextBox.Location = new System.Drawing.Point(264, 36);
            this.sprintNameTextBox.MaxLength = 20;
            this.sprintNameTextBox.Name = "sprintNameTextBox";
            this.sprintNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.sprintNameTextBox.TabIndex = 1;
            // 
            // beginDateMaskedTextBox
            // 
            this.beginDateMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintBindingSource, "BeginDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "MM/dd/yyyy"));
            this.beginDateMaskedTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginDateMaskedTextBox.Location = new System.Drawing.Point(88, 64);
            this.beginDateMaskedTextBox.Mask = "00/00/0000";
            this.beginDateMaskedTextBox.Name = "beginDateMaskedTextBox";
            this.beginDateMaskedTextBox.Size = new System.Drawing.Size(72, 23);
            this.beginDateMaskedTextBox.TabIndex = 2;
            this.beginDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // endDateMaskedTextBox
            // 
            this.endDateMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintBindingSource, "EndDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "MM/dd/yyyy"));
            this.endDateMaskedTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateMaskedTextBox.Location = new System.Drawing.Point(264, 64);
            this.endDateMaskedTextBox.Mask = "00/00/0000";
            this.endDateMaskedTextBox.Name = "endDateMaskedTextBox";
            this.endDateMaskedTextBox.Size = new System.Drawing.Size(72, 23);
            this.endDateMaskedTextBox.TabIndex = 3;
            this.endDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // updatedDateTimeTextBox
            // 
            this.updatedDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintBindingSource, "UpdatedDateTime", true));
            this.updatedDateTimeTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedDateTimeTextBox.Location = new System.Drawing.Point(310, 127);
            this.updatedDateTimeTextBox.Name = "updatedDateTimeTextBox";
            this.updatedDateTimeTextBox.ReadOnly = true;
            this.updatedDateTimeTextBox.Size = new System.Drawing.Size(150, 23);
            this.updatedDateTimeTextBox.TabIndex = 37;
            this.updatedDateTimeTextBox.TabStop = false;
            // 
            // addedDateTimeTextBox
            // 
            this.addedDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintBindingSource, "AddedDateTime", true));
            this.addedDateTimeTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedDateTimeTextBox.Location = new System.Drawing.Point(310, 104);
            this.addedDateTimeTextBox.Name = "addedDateTimeTextBox";
            this.addedDateTimeTextBox.ReadOnly = true;
            this.addedDateTimeTextBox.Size = new System.Drawing.Size(150, 23);
            this.addedDateTimeTextBox.TabIndex = 36;
            this.addedDateTimeTextBox.TabStop = false;
            // 
            // updatedByTextBox
            // 
            this.updatedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintBindingSource, "UpdatedBy", true));
            this.updatedByTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedByTextBox.Location = new System.Drawing.Point(88, 127);
            this.updatedByTextBox.Name = "updatedByTextBox";
            this.updatedByTextBox.ReadOnly = true;
            this.updatedByTextBox.Size = new System.Drawing.Size(89, 23);
            this.updatedByTextBox.TabIndex = 34;
            this.updatedByTextBox.TabStop = false;
            // 
            // addedByTextBox
            // 
            this.addedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sprintBindingSource, "AddedBy", true));
            this.addedByTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedByTextBox.Location = new System.Drawing.Point(88, 104);
            this.addedByTextBox.Name = "addedByTextBox";
            this.addedByTextBox.ReadOnly = true;
            this.addedByTextBox.Size = new System.Drawing.Size(89, 23);
            this.addedByTextBox.TabIndex = 32;
            this.addedByTextBox.TabStop = false;
            // 
            // sprintBindingSource
            // 
            this.sprintBindingSource.DataSource = typeof(ScrumProjectTracking.DataAccess.Sprint);
            // 
            // SprintDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(528, 205);
            this.ControlBox = false;
            this.Controls.Add(updatedDateTimeLabel);
            this.Controls.Add(this.updatedDateTimeTextBox);
            this.Controls.Add(addedDateTimeLabel);
            this.Controls.Add(this.addedDateTimeTextBox);
            this.Controls.Add(updatedByLabel);
            this.Controls.Add(this.updatedByTextBox);
            this.Controls.Add(addedByLabel);
            this.Controls.Add(this.addedByTextBox);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateMaskedTextBox);
            this.Controls.Add(beginDateLabel);
            this.Controls.Add(this.beginDateMaskedTextBox);
            this.Controls.Add(sprintNameLabel);
            this.Controls.Add(this.sprintNameTextBox);
            this.Controls.Add(sprintIDLabel);
            this.Controls.Add(this.sprintIDTextBox);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SprintDetail";
            this.Text = "Sprint-Detail";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.TextBox sprintIDTextBox;
        private System.Windows.Forms.TextBox sprintNameTextBox;
        private System.Windows.Forms.MaskedTextBox beginDateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox endDateMaskedTextBox;
        private System.Windows.Forms.TextBox updatedDateTimeTextBox;
        private System.Windows.Forms.TextBox addedDateTimeTextBox;
        private System.Windows.Forms.TextBox updatedByTextBox;
        private System.Windows.Forms.TextBox addedByTextBox;
    }
}