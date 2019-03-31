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
namespace ScrumProjectTracking.Sprints.SprintTaskList
{
    public partial class SprintTaskList : Form
    {
        FrmMain parent;
        ISprintTaskListDataAccess DBSource = new SprintTaskListDBDataAccess();
        ISprintTaskDetailDataAccess SprintTaskDetailDBSource;
        public SprintTaskList(FrmMain parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            FillDropDownSelections();
            dgvTaskList.AutoGenerateColumns = false;
        }


        public SprintTaskList (int sprintID, FrmMain parentForm) : this(parentForm)
        {
            SprintID.SelectedValue = sprintID;




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
            
            
                dgvTaskList.DataSource = DBSource.getResults(tbTaskName.Text == String.Empty ? null : tbTaskName.Text, int.Parse(SprintID.SelectedValue.ToString()), int.Parse(ProjectID.SelectedValue.ToString()), int.Parse(TeamID.SelectedValue.ToString()), AssignedUserID.SelectedValue == null ? null : AssignedUserID.SelectedValue.ToString(), lbTaskStatus.SelectedItems.Cast<String>().ToList());
                            
        }

        private void dgvTaskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
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
    }
}
