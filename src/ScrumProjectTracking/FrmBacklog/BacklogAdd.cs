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

namespace ScrumProjectTracking.FrmBacklog
{
    public partial class BacklogAdd : Form
    {
        public BacklogAdd()
        {
            InitializeComponent();
        }

        BacklogData b = new BacklogData();

        private void BacklogAdd_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            b.newBacklogRow(int.Parse(projectIDTextBox.Text), CurrentUser.TeamID, userStoryTextBox.Text, int.Parse(storyPointsTextBox.Text), int.Parse(priorityTextBox.Text), CurrentUser.UserID, dateTime);
            userStoryTextBox.Clear();
            priorityTextBox.Clear();
            projectIDTextBox.Clear();
            storyPointsTextBox.Clear();
        }
    }
}
