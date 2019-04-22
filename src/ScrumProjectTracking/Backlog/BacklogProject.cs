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
namespace ScrumProjectTracking.Backlog
{
    public partial class ProjectBacklog : Form
    {
        FrmMain parent;
        BacklogData b = new BacklogData();
        int projectID;
        public ProjectBacklog(int i, FrmMain formParent)
        {
            InitializeComponent();
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            dataGridView1.AutoGenerateColumns = false;
            cbStoryStatus.SelectedIndex = 0;
            dataGridView1.DataSource = b.getStoryList(i, cbStoryStatus.SelectedItem.ToString());
            parent = formParent;
            projectID = i;
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.RowIndex > -1 && e.ColumnIndex == 0)
            {
                BacklogDetail backlogDetail = new BacklogDetail(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["StoryID"].Value.ToString()));
                parent.LoadChildForm(backlogDetail);

            }
        }

        private void cbStoryStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {

            dataGridView1.DataSource = b.getStoryList(projectID, cbStoryStatus.SelectedItem.ToString());

        }
    }
}
