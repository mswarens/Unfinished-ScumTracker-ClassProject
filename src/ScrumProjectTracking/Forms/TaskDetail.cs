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
namespace ScrumProjectTracking.Forms
{
    public partial class TaskDetail : Form
    {
        ScrumContext context;
        SprintTask currentTask;
        public TaskDetail(int taskID)
        {
            InitializeComponent();
            context = new ScrumContext();
            FillDropDownSelections();
            this.TeamID.SelectedIndexChanged += new System.EventHandler(this.TeamID_SelectedIndexChanged);
            currentTask = context.SprintTasks.Where(t => t.SprintTaskID == taskID).First();
            sprintTaskBindingSource.DataSource = currentTask;
            lbCompletionPercent.Text = trackBar1.Value.ToString(@"#\%");

        }

        public TaskDetail()
        {
            
            InitializeComponent();
            context = new ScrumContext();
            FillDropDownSelections();
            currentTask = new SprintTask();
            sprintTaskBindingSource.DataSource = currentTask;
            this.TeamID.SelectedIndexChanged += new System.EventHandler(this.TeamID_SelectedIndexChanged);

        }



        private void FillDropDownSelections()
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

        private void TeamID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TeamID.SelectedValue == null)
            {
                AssignedUserID.Enabled = false;
               
            }
            else
            {
               
                    var UserData = from u in context.Users
                                   where u.TeamID == int.Parse(TeamID.SelectedValue.ToString())
                                   select new { u.UserID, UsersName = u.LastName + ',' + u.FirstName };
                    AssignedUserID.DataSource = UserData.ToList();
                    AssignedUserID.DisplayMember = "UsersName";
                    AssignedUserID.ValueMember = "UserID";
                    AssignedUserID.Enabled = true;
               
                
            }
            

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lbCompletionPercent.Text = trackBar1.Value.ToString(@"#\%");

        }

        private void ValidateData()
        {


        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            this.Validate();
            currentTask.UpdatedBy = "CURRUSER";
            currentTask.UpdatedDateTime = DateTime.Now;

         
            if (currentTask.SprintTaskID == 0)
            {
                currentTask.AddedBy = "CURRUSER";
                currentTask.AddedDateTime = DateTime.Now;
                context.SprintTasks.Add(currentTask);
                context.SaveChanges();
                sprintTaskBindingSource.ResetBindings(false);
             
    
            }
            else
            {
                
                context.SaveChanges();
                                                         
            }
         
          
                  
                      
        }

 

      
    }
}
