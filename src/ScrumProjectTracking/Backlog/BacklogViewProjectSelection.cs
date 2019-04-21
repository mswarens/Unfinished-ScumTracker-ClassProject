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
    public partial class BacklogViewProjectSelection : Form
    {
        FrmMain parent;
        BacklogData b = new BacklogData();
        public BacklogViewProjectSelection(FrmMain formParent)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
         
           dataGridView1.DataSource = b.getActiveProjectList();
          
            parent = formParent;
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         if (e.RowIndex > -1 && e.ColumnIndex == 0)
            {
                ProjectBacklog projectBacklog = new ProjectBacklog(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ProjectID"].Value.ToString()), parent);
                parent.LoadChildForm(projectBacklog);
            }
        }
    }
}
