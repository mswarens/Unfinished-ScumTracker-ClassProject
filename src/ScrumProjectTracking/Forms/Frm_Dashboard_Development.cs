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
namespace ScrumProjectTracking
{
    public partial class Frm_Dashboard_Development : Form
    {
        public Frm_Dashboard_Development()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            panel2.Size = new Size(this.Width - panel2.Location.X, panel2.Height);
            dgvCurrentSprintTasks.Size = new Size(panel2.Width - dgvCurrentSprintTasks.Location.X - 5, dgvCurrentSprintTasks.Height);
            dgvCurrentSprintTasks.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dgvCurrentSprintTasks.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            fillSprintData();

        }

       private void fillSprintData ()
        {
            using (ScrumContext scrumContext = new ScrumContext())
            {
                var sprintInfo = from s in scrumContext.Sprints
                              where s.BeginDate <= DateTime.Today && s.EndDate >= DateTime.Today
                              select new { s.SprintName, s.BeginDate, s.EndDate, s.SprintID };
                if (sprintInfo.Count() > 0)
                {
                    lbSprintName.Text = sprintInfo.First().SprintName;
                    lbSprintBeginDate.Text = sprintInfo.First().BeginDate.ToShortDateString();
                    lbSprintEndDate.Text = sprintInfo.First().EndDate.ToShortDateString();

                    var pendingTasks = (from s in scrumContext.SprintTasks
                                        join p in scrumContext.Projects on s.ProjectID equals p.ProjectID
                                        where s.TaskStatus == "Pending" && s.SprintID == sprintInfo.First().SprintID
                                        orderby p.ProjectName, s.TaskName
                                        select new { s.TaskName, s.SprintTaskID, p.ProjectName, s.TaskCompletionPercent, s.StoryPoints}
                                        );
                    dgvCurrentSprintTasks.AutoGenerateColumns = false;
                    dgvCurrentSprintTasks.DataSource = pendingTasks.ToList();

                    var totalTasks = (from s in scrumContext.SprintTasks
                                      where s.SprintID == sprintInfo.First().SprintID
                                      select s).Count();

                    var totalStoryPoints = (from s in scrumContext.SprintTasks
                                            where s.SprintID == sprintInfo.First().SprintID
                                            select s.StoryPoints).Sum();



                    pbMyBackLogTasks.setValue(((double)totalTasks - (double)pendingTasks.Count()) / (double)totalTasks);
                    
                    lbMyBackLogTasks.Text = (totalTasks - pendingTasks.Count()).ToString() + "/" + totalTasks.ToString();
                    pbMyStoryPoints.setValue (((((double)totalStoryPoints - (double)pendingTasks.Sum(a => a.StoryPoints)) / (double)totalStoryPoints)));
                    lbMyStoryPoints.Text = (totalStoryPoints - pendingTasks.Sum(a => a.StoryPoints)).ToString() + "/" +  totalStoryPoints.ToString();
                  

                }

                var nextSprintInfo = (from s in scrumContext.Sprints
                                      where s.BeginDate > DateTime.Today
                                      orderby s.BeginDate
                                      select new { s.SprintName, s.BeginDate, s.EndDate }).Take(1);
                if (nextSprintInfo.Count() > 0)
                {
                    lbNextSprintName.Text = nextSprintInfo.First().SprintName;
                    lbNextSprintBeginDate.Text = nextSprintInfo.First().BeginDate.ToShortDateString();
                    lbNextSprintEndDate.Text = nextSprintInfo.First().EndDate.ToShortDateString();
                }
                
                
            }
        }









    }
}
