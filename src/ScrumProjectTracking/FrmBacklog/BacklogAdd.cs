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
using System.ComponentModel.DataAnnotations.Schema;
namespace ScrumProjectTracking.FrmBacklog
{
    public partial class BacklogAdd : Form
    {
        public BacklogAdd()
        {
            InitializeComponent();
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = (from u in b.projectData() orderby u.ProjectID ascending select u.ProjectName);
            projectNameTextBox.DataSource = bindingSource1;
        }

        BacklogData b = new BacklogData();

        private void BacklogAdd_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int pid = (from u in b.projectData() where u.ProjectName == projectNameTextBox.Text select u.ProjectID).First();
            b.newBacklogRow(pid, CurrentUser.TeamID, projectNameTextBox.Text, userStoryTextBox.Text, int.Parse(storyPointsTextBox.Text), int.Parse(priorityTextBox.Text), CurrentUser.UserID, dateTime);
            userStoryTextBox.Clear();
            priorityTextBox.Clear();
            projectNameTextBox.SelectedIndex = 0;
            storyPointsTextBox.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
