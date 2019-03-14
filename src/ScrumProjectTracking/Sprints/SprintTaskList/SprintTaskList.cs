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
namespace ScrumProjectTracking.Sprints.SprintTaskList
{
    public partial class SprintTaskList : Form
    {
        ISprintTaskListDataAccess DBSource = new SprintTaskListDBDataAccess();
        IFrmSprintTaskDetailDataAccess SprintTaskDetailDBSource;
        public SprintTaskList()
        {
            InitializeComponent();
            FillDropDownSelections();
            dgvTaskList.AutoGenerateColumns = false;
        }


        public SprintTaskList (int sprintID) : this()
        {
            SprintID.SelectedValue = sprintID;




        }








        private void FillDropDownSelections()
        {

            using (SprintTaskDetailDBSource = new FrmSprintTaskDetailDBAccess())
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
                using (SprintTaskDetailDBSource = new FrmSprintTaskDetailDBAccess())
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
    }
}
