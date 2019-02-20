using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.DataModels;
namespace ScrumProjectTracking.Forms
{
    public partial class TaskDetail : Form
    {
        public TaskDetail(int taskID)
        {
            InitializeComponent();
            FillDropDownSelections();
            fillData(taskID);
        }

        public TaskDetail()
        {
            InitializeComponent();
            FillDropDownSelections();
        }

        private void fillData(int taskID)
        {

            using (ScrumContext context = new ScrumContext())
            {
                var taskDetail = from t in context.SprintTasks
                                 where t.SprintTaskID == taskID
                                 select t;
                sprintTaskBindingSource.DataSource = taskDetail.ToList();

               



            }




        }

        private void FillDropDownSelections()
        {
            using (ScrumContext context = new ScrumContext())
            {
                var sprintData = from s in context.Sprints
                                 select new { s.SprintID, s.SprintName };

                SprintID.DataSource = sprintData.ToList();
                SprintID.DisplayMember = "SprintName";
                SprintID.ValueMember = "SprintID";

                var projectData = from p in context.Projects
                                select new { p.ProjectName, p.ProjectID };
                ProjectID.DataSource = projectData.ToList();
                ProjectID.DisplayMember = "ProjectName";
                ProjectID.ValueMember = "ProjectID";

                var teamData = from t in context.Teams
                                select new { t.TeamName, t.TeamID };
                TeamID.DataSource = teamData.ToList();
                TeamID.DisplayMember = "TeamName";
                TeamID.ValueMember = "TeamID";



            }


        }

        private void TeamID_ValueMemberChanged(object sender, EventArgs e)
        {
            if (TeamID.Text == null)
            {
                AssignedUserID.Enabled = false;
                AssignedUserID.SelectedIndex = -1;
            }
            else
            {
                using (ScrumContext context = new ScrumContext())
                {
                    var UserData = from u in context.Users
                                   where u.TeamID == int.Parse(TeamID.SelectedValue.ToString())
                                   select new { u.UserID, UsersName = u.LastName + ',' + u.FirstName };
                    AssignedUserID.DataSource = UserData.ToList();
                    AssignedUserID.DisplayMember = "UsersName";
                    AssignedUserID.ValueMember = "UserID";

                }
                
            }
            

        }
    }
}
