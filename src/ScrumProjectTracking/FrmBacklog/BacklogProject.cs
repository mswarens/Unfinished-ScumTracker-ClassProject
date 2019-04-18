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
    public partial class ProjectBacklog : Form
    {
        FrmMain parent;
        BacklogData b = new BacklogData();
        public ProjectBacklog(int i, FrmMain formParent)
        {
            InitializeComponent();
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = (from u in b.backlogData() where u.ProjectID == i orderby u.BacklogID ascending select u);
            dataGridView1.DataSource = bindingSource1;
            parent = formParent;
        }

        private void ProjectBacklog_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var correctSender = (DataGridView)sender;
            if (correctSender.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                EditBacklog pb = new EditBacklog(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["BacklogID"].Value.ToString()));
                parent.LoadChildForm(pb);
            }
        }
    }
}
