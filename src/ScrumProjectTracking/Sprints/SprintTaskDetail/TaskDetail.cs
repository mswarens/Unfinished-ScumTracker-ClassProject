using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Forms;
using ScrumProjectTracking.Main;

namespace ScrumProjectTracking.Sprints.SprintTaskDetail
{
    public partial class TaskDetail : Form
    {
        SprintTaskDetailDBAccess DBSource = new SprintTaskDetailDBAccess();
        SprintTask currentTask;
        public TaskDetail(int taskID)
        {
            InitializeComponent();
            FillDropDownSelections();
            currentTask = DBSource.getSprintTask(taskID);
            sprintTaskBindingSource.DataSource = currentTask;
            lbCompletionPercent.Text = trackBar1.Value.ToString(@"#\%");
         
                AssignedUserID.DataSource = DBSource.getUserList(currentTask.TeamID).ToList();
                AssignedUserID.DisplayMember = "DisplayName";
                AssignedUserID.ValueMember = "UserID";
                AssignedUserID.Enabled = true;
         
            if (currentTask.TaskStatus != "Cancelled")
                trackBar1.Enabled = true;

            dgvNotes.DataSource = DBSource.getSprintTaskNotes(currentTask.SprintTaskID);
            btnAddNote.Enabled = true;
        }

        public TaskDetail()
        {
            
            InitializeComponent();
            currentTask = DBSource.getNewSprintTask();
            FillDropDownSelections();
            sprintTaskBindingSource.DataSource = currentTask;
            trackBar1.Enabled = true;

        }



        private void FillDropDownSelections()
        {
            dgvNotes.AutoGenerateColumns = false;

            taskStatusComboBox.Items.Add(String.Empty);
            taskStatusComboBox.Items.Add("Pending");
            taskStatusComboBox.Items.Add("Completed");
            taskStatusComboBox.Items.Add("Cancelled");

            taskSubstatusComboBox.Items.Add(String.Empty);
            taskSubstatusComboBox.Items.Add("Requirements gathering");
            taskSubstatusComboBox.Items.Add("Design analysis");
            taskSubstatusComboBox.Items.Add("Coding");
            taskSubstatusComboBox.Items.Add("Unit testing");
            taskSubstatusComboBox.Items.Add("Integration testing");
            taskSubstatusComboBox.Items.Add("User acceptance testing");
            taskSubstatusComboBox.Items.Add("Release pending");
            taskSubstatusComboBox.Items.Add("Release completed");


            SprintID.DataSource = DBSource.getSprintList();
                SprintID.DisplayMember = "SprintName";
                SprintID.ValueMember = "SprintID";


            ProjectID.DataSource = DBSource.getProjectList();
            ProjectID.DisplayMember = "ProjectName";
            ProjectID.ValueMember = "ProjectID";


            TeamID.DataSource = DBSource.getTeamList();
            TeamID.DisplayMember = "TeamName";
            TeamID.ValueMember = "TeamID";






        }

   

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lbCompletionPercent.Text = trackBar1.Value.ToString(@"#\%");
            if (trackBar1.Value == trackBar1.Maximum)
                currentTask.TaskStatus = "Completed";
            else
                currentTask.TaskStatus = "Pending";
        }

     

   

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (DBSource.sprintTaskChanged(currentTask))
            {
                if(DBSource.validateRecord(currentTask))
                {
                    string errorMessage = "This record cannot be saved due to the following validation errors:\n";
                    errorMessage += String.Join("\n", DBSource.getValidationErrors().Select(a => a.FieldName + " - " + a.ErrorMessage));
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    if (currentTask.AddedBy == null)
                    {
                        currentTask.AddedBy = CurrentUser.UserID;
                        currentTask.AddedDateTime = DateTime.Now;
                        DBSource.addSprintTask(currentTask);

                    }
                    currentTask.UpdatedBy = CurrentUser.UserID;
                    currentTask.UpdatedDateTime = DateTime.Now;

                    DBSource.saveSprintTask();
                    sprintTaskBindingSource.ResetBindings(false);
                    btnAddNote.Enabled = true;
                    ((ScrumProjectTracking.Main.FrmMain)this.ParentForm).refreshDashboard();
                }
            }
        }

    

        private void TeamID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (TeamID.SelectedValue != null)
            {
                AssignedUserID.DataSource = DBSource.getUserList((int)TeamID.SelectedValue).ToList();
                AssignedUserID.DisplayMember = "DisplayName";
                AssignedUserID.ValueMember = "UserID";
                AssignedUserID.Enabled = true;
                AssignedUserID.SelectedIndex = -1;

            }
            else
            {

                AssignedUserID.Enabled = false;
                AssignedUserID.SelectedIndex = -1;

            }
        }

        private void taskStatusComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (taskStatusComboBox.SelectedItem.ToString() == "Cancelled")
            {
                trackBar1.Enabled = false;
                currentTask.TaskCompletionPercent = 0;

            }
            else
                trackBar1.Enabled = true;
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            NoteDetail noteDetail = new NoteDetail(currentTask.SprintTaskID);
            noteDetail.ShowDialog();
            dgvNotes.DataSource = DBSource.getSprintTaskNotes(currentTask.SprintTaskID);

        }

        private void dgvNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                NoteDetail noteDetail = new NoteDetail(dgvNotes.Rows[e.RowIndex].Cells[2].Value.ToString());
                noteDetail.ShowDialog();
                
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure wish to delete the selected note?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBSource.deleteSprintTaskNote((int)dgvNotes.Rows[e.RowIndex].Cells[5].Value);
                    dgvNotes.DataSource = DBSource.getSprintTaskNotes(currentTask.SprintTaskID);
                }
            }
        }
    }
}
