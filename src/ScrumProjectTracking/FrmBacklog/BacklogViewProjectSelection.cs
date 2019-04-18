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
    public partial class BacklogViewProjectSelection : Form
    {
        FrmMain parent;
        public BacklogViewProjectSelection(FrmMain formParent)
        {
            InitializeComponent();
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = (from u in b.projectData() orderby u.ProjectID ascending select u);
            dataGridView1.DataSource = bindingSource1;
            parent = formParent;
        }
        BacklogData b = new BacklogData();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var correctSender = (DataGridView)sender;
            if (correctSender.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                ProjectBacklog pb = new ProjectBacklog(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ProjectID"].Value.ToString()), parent);
                parent.LoadChildForm(pb);
            }
        }
    }
}
