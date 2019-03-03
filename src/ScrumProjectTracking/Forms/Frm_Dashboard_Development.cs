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
        IFrmMainDataAccess dbSource = new FrmMainDBDataAccess();

        FrmMain parentForm;
        public Frm_Dashboard_Development(FrmMain parent)
        {
            InitializeComponent();
            parentForm = parent;
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

            SprintInfo currentSprint = dbSource.getCurrentSprintInfo();
            SprintInfo nextSprint = dbSource.getNextSprintInfo();
            if (currentSprint != null)
            {
                lbSprintName.Text = currentSprint.SprintName;
                lbSprintBeginDate.Text = currentSprint.BeginDate.ToShortDateString();
                lbSprintEndDate.Text = currentSprint.EndDate.ToShortDateString();
                dgvCurrentSprintTasks.Columns[0].Width = 35;
                dgvCurrentSprintTasks.AutoGenerateColumns = false;
                List<PendingSprintTask> pendingTasks = dbSource.getPendingTasks("SSHROUT", currentSprint.SprintID);
                dgvCurrentSprintTasks.DataSource = pendingTasks;
                int totalTasks = dbSource.getTotalTasks("SSHROUT", currentSprint.SprintID);
                int totalStoryPoints = dbSource.getTotalStoryPoints("SSHROUT", currentSprint.SprintID);
                pbMyBackLogTasks.setValue(((double)totalTasks - (double)pendingTasks.Count()) / (double)totalTasks);

                lbMyBackLogTasks.Text = (totalTasks - pendingTasks.Count()).ToString() + "/" + totalTasks.ToString();
                pbMyStoryPoints.setValue(((((double)totalStoryPoints - (double)pendingTasks.Sum(a => a.StoryPoints)) / (double)totalStoryPoints)));
                lbMyStoryPoints.Text = (totalStoryPoints - pendingTasks.Sum(a => a.StoryPoints)).ToString() + "/" + totalStoryPoints.ToString();
            }
            if (nextSprint != null)
            {
                lbNextSprintName.Text = nextSprint.SprintName;
                lbNextSprintBeginDate.Text = nextSprint.BeginDate.ToShortDateString();
                lbNextSprintEndDate.Text = nextSprint.EndDate.ToShortDateString();
            }

           
        }

        private void dgvCurrentSprintTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                TaskDetail newTask = new TaskDetail((int)dgvCurrentSprintTasks.Rows[e.RowIndex].Cells[5].Value);
                parentForm.LoadChildForm(newTask);
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
    }
}
