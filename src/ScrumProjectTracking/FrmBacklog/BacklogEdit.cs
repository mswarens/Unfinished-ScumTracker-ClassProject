using ScrumProjectTracking.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumProjectTracking.FrmBacklog
{
    public partial class EditBacklog : Form
    {
        public EditBacklog(int i)
        {
            InitializeComponent();
            k = i;
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = (from u in b.projectData() orderby u.ProjectID ascending select u.ProjectName);
            ProjectName.DataSource = bindingSource1;
            //initial state from source
            var row = (from u in b.backlogData() where u.BacklogID == i select u).First();
            BacklogIDInput.Text = row.BacklogID.ToString();
            storyPointsTextBox.Text = row.StoryPoints.ToString();
            Priority.Text = row.Priority.ToString();
            TeamIDTextBox.Text = row.TeamID.ToString();
            ProjectName.Text = row.ProjectName.ToString();
            UserStoryTextBox.Text = row.UserStory.ToString();
            addedByTextBox.Text = row.AddedBy.ToString();
            addedDateTimeTextBox.Text = row.AddedDateTime.ToString();
            if (row.UpdatedBy != null)
            {

                updatedByTextBox.Text = row.UpdatedBy.ToString();
                updatedDateTimeTextBox.Text = row.UpdatedDateTime.ToString();
            }
        }
        private int k;
        BacklogData b = new BacklogData();

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            var row = (from u in b.backlogData() where u.BacklogID == k select u).First();
            int pid = (from u in b.projectData() where u.ProjectName == ProjectName.Text select u.ProjectID).First();
            b.editBacklogRow(pid, int.Parse(TeamIDTextBox.Text), ProjectName.Text, UserStoryTextBox.Text, int.Parse(storyPointsTextBox.Text), int.Parse(Priority.Text), CurrentUser.UserID, dateTime, row);
            UserStoryTextBox.Clear();
            Priority.Clear();
            ProjectName.SelectedIndex = 0;
            storyPointsTextBox.Clear();
        }
    }
}
