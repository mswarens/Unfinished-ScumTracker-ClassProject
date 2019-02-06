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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            dgvCurrentSprintTasks.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dgvCurrentSprintTasks.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
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
