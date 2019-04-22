using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.Sprints.SprintTaskDetail;
using ScrumProjectTracking.Main;
using Microsoft.Reporting.WinForms;
using System.IO;
using ScrumProjectTracking.DataExports;
namespace ScrumProjectTracking.Sprints.SprintTaskList
{
    public partial class SprintTaskList : Form
    {
        FrmMain parent;
        ISprintTaskListDataAccess DBSource = new SprintTaskListDBDataAccess();
        ISprintTaskDetailDataAccess SprintTaskDetailDBSource;
        List<SprintTaskListItem> results;
        public SprintTaskList(FrmMain parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            FillDropDownSelections();
            dgvTaskList.AutoGenerateColumns = false;
            dgvTaskList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dgvTaskList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }


        public SprintTaskList (int sprintID, FrmMain parentForm) : this(parentForm)
        {
            SprintID.SelectedValue = sprintID;
            lbTaskStatus.SetSelected(0, true);
            lbTaskStatus.SetSelected(1, true);
            applySearch();



        }








        private void FillDropDownSelections()
        {

            using (SprintTaskDetailDBSource = new SprintTaskDetailDBAccess())
            {

                SprintID.DataSource = SprintTaskDetailDBSource.getSprintList();
                SprintID.DisplayMember = "SprintName";
                SprintID.ValueMember = "SprintID";
                

                ProjectID.DataSource = SprintTaskDetailDBSource.getProjectList();
                ProjectID.DisplayMember = "ProjectName";
                ProjectID.ValueMember = "ProjectID";


                TeamID.DataSource = SprintTaskDetailDBSource.getTeamList();
                TeamID.DisplayMember = "TeamName";
                TeamID.ValueMember = "TeamID";

            }




        }





        private void TeamID_SelectionChangeCommitted(object sender, EventArgs e)
        {
              if (TeamID.SelectedValue != null)
            {
                using (SprintTaskDetailDBSource = new SprintTaskDetailDBAccess())
                {
                    AssignedUserID.DataSource = SprintTaskDetailDBSource.getUserList((int)TeamID.SelectedValue).ToList();
                    AssignedUserID.DisplayMember = "DisplayName";
                    AssignedUserID.ValueMember = "UserID";
                    AssignedUserID.Enabled = true;
                    AssignedUserID.SelectedIndex = -1;
                }

            }
            else
            {

                AssignedUserID.Enabled = false;
                AssignedUserID.SelectedIndex = -1;

            }
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {

            applySearch();      }

        private void applySearch()
        {

            if (tbSprintTaskID.Text == "")
                results = DBSource.getResults(tbTaskName.Text == String.Empty ? null : tbTaskName.Text, int.Parse(SprintID.SelectedValue.ToString()), int.Parse(ProjectID.SelectedValue.ToString()), int.Parse(TeamID.SelectedValue.ToString()), AssignedUserID.SelectedValue == null ? null : AssignedUserID.SelectedValue.ToString(), lbTaskStatus.SelectedItems.Cast<String>().ToList());
            else
                results = DBSource.getResultsByID(tbSprintTaskID.Text.ToString() == "" ? 0 : int.Parse(tbSprintTaskID.Text.ToString()));



                dgvTaskList.DataSource = results;
        }

        private void dgvTaskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                TaskDetail existingSprintTask = new TaskDetail(int.Parse(dgvTaskList.Rows[e.RowIndex].Cells["SprintTaskID"].Value.ToString()));
                ((FrmMain)parent).LoadChildForm(existingSprintTask);
            }
        }

   

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            TaskDetail newSprintTask = new TaskDetail();
            ((FrmMain)parent).LoadChildForm(newSprintTask);
        }

 

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvTaskList.RowCount > 0 && (cbExportFormat.SelectedItem ?? "").ToString() != "")
            {
                btnExport.Text = "Generating...";
                btnExport.Enabled = false;
                SaveFileDialog sfd = new SaveFileDialog();
                IExportDocument exportDocument;
                sfd.FilterIndex = 0;
                sfd.RestoreDirectory = true;
                switch (cbExportFormat.Text)
                {
                    case "PDF":
                        sfd.Filter = "PDF (*.pdf)|*.pdf";
                        break;
                    case "Excel":
                        sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                        break;
                }
               
                

                sfd.ShowDialog();
                if (sfd.FileName != "")
                {
                    exportDocument = ExportDocumentFactory.getExportDocument(cbExportFormat.Text, sfd.FileName);
                    string exportResponse = exportDocument.exportData(results);
                    if (exportResponse == "Success")
                        System.Diagnostics.Process.Start(sfd.FileName);
                    else
                        MessageBox.Show(exportResponse, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                btnExport.Text = "Export";
                btnExport.Enabled = true;
            }
        }

        private void tbSprintTaskID_TextChanged(object sender, EventArgs e)
        {
            if (tbSprintTaskID.Text.ToString() != "")
            {
                tbTaskName.Enabled = false;
                lbTaskStatus.Enabled = false;
                SprintID.Enabled = false;
                ProjectID.Enabled = false;
                TeamID.Enabled = false;
                AssignedUserID.Enabled = false;
            }
            else
            {
                tbTaskName.Enabled = true;
                lbTaskStatus.Enabled = true;
                SprintID.Enabled = true;
                ProjectID.Enabled = true;
                TeamID.Enabled = true;
                AssignedUserID.Enabled = true;

            }
        }
    }
}
