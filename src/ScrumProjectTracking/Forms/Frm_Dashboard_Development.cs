using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.Main;
using ScrumProjectTracking.Sprints.SprintTaskDetail;
namespace ScrumProjectTracking
{
    public partial class Frm_Dashboard_Development : Form
    {
        IFrmMainDataAccess dbSource;
        FrmMain parentForm;
        public Frm_Dashboard_Development(FrmMain parent)
        {
            InitializeComponent();
            parentForm = parent;
            
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
           
            dgvCurrentSprintTasks.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dgvCurrentSprintTasks.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dgvCurrentSprintTasks.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            dgvCurrentSprintTasks.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.Menu;
            
           
            fillSprintData();
            resizeWindow();
        }


        public void resizeWindow ()
        {
           
            panel2.Size = new Size(parentForm.Width - panel2.Location.X - 25, panel2.Height);
            dgvCurrentSprintTasks.Size = new Size(panel2.Width - dgvCurrentSprintTasks.Location.X - 5, dgvCurrentSprintTasks.Height);
            // dgvCurrentSprintTasks.PerformLayout();
            dgvCurrentSprintTasks.AutoResizeColumns();
        }



        


       public void fillSprintData ()
        {
            using (dbSource = new FrmMainDBDataAccess()) {
                SprintInfo currentSprint = dbSource.getCurrentSprintInfo();
                SprintInfo nextSprint = dbSource.getNextSprintInfo();
                if (currentSprint != null)
                {
                    lbSprintName.Text = currentSprint.SprintName;
                    lbSprintBeginDate.Text = currentSprint.BeginDate.ToShortDateString();
                    lbSprintEndDate.Text = currentSprint.EndDate.ToShortDateString();
                    dgvCurrentSprintTasks.Columns[0].Width = 35;
                    dgvCurrentSprintTasks.AutoGenerateColumns = false;
                    List<PendingSprintTask> pendingTasks = dbSource.getPendingTasks(CurrentUser.UserID, currentSprint.SprintID);
                    dgvCurrentSprintTasks.DataSource = pendingTasks;
                    int totalTasks = dbSource.getTotalTasksUser(CurrentUser.UserID, currentSprint.SprintID);
                    int totalStoryPoints = dbSource.getTotalStoryPointsUser(CurrentUser.UserID, currentSprint.SprintID);
                    pbMyBackLogTasks.setValue(((double)totalTasks - (double)pendingTasks.Count()) / (double)totalTasks);

                    lbMyBackLogTasks.Text = (totalTasks - pendingTasks.Count()).ToString() + "/" + totalTasks.ToString();
                    pbMyStoryPoints.setValue(((((double)totalStoryPoints - (double)pendingTasks.Sum(a => a.StoryPoints)) / (double)totalStoryPoints)));
                    lbMyStoryPoints.Text = (totalStoryPoints - pendingTasks.Sum(a => a.StoryPoints)).ToString() + "/" + totalStoryPoints.ToString();

                    int totalTasksTeam = dbSource.getTotalTasksTeam(CurrentUser.TeamID, currentSprint.SprintID);
                    int pendingTasksTeam = dbSource.getPendingTasksTeam(CurrentUser.TeamID, currentSprint.SprintID);
                    int totalStoryPointsTeam = dbSource.getTotalStoryPointsTeam(CurrentUser.TeamID, currentSprint.SprintID);
                    int pendingStoryPointsTeam = dbSource.getPendingStoryPointsTeam(CurrentUser.TeamID, currentSprint.SprintID);
                    pbTeamBacklogTasks.setValue(((double)totalTasksTeam - (double)pendingTasksTeam) / (double)totalTasksTeam);
                    pbTeamStoryPoints.setValue(((double)totalStoryPointsTeam - (double)pendingStoryPointsTeam) / (double)totalStoryPointsTeam);
                    lbTeamBacklogTasks.Text = (totalTasksTeam - pendingTasksTeam).ToString() + "/" + totalTasksTeam.ToString();
                    lbTeamStoryPoints.Text = (totalStoryPointsTeam - pendingStoryPointsTeam).ToString() + "/" + totalStoryPointsTeam.ToString();

                }
                if (nextSprint != null)
                {
                    lbNextSprintName.Text = nextSprint.SprintName;
                    lbNextSprintBeginDate.Text = nextSprint.BeginDate.ToShortDateString();
                    lbNextSprintEndDate.Text = nextSprint.EndDate.ToShortDateString();
                }
            }
           
        }

        private void dgvCurrentSprintTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                TaskDetail openTask = new TaskDetail((int)dgvCurrentSprintTasks.CurrentRow.Cells[6].Value);
                parentForm.LoadChildForm(openTask);
            }
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            TaskDetail newTask = new TaskDetail();
            parentForm.LoadChildForm(newTask); 
        }

        private void Frm_Dashboard_Development_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbSource.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
