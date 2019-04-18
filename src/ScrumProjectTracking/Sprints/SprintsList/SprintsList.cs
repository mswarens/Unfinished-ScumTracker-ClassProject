using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.Forms;
using ScrumProjectTracking.Sprints.SprintTaskList;
using ScrumProjectTracking.Main;
namespace ScrumProjectTracking.Sprints.SprintsList
{
    public partial class SprintsList : Form
    {
        SprintsListDBAccess context;
        FrmMain parent;
        public SprintsList(FrmMain parentForm)
        {
            InitializeComponent();
            parent = parentForm;
        }

        private void SprintsList_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.Menu;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridView1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridView1.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;

            tbEndDate.Text = DateTime.Today.AddMonths(-3).ToString("MM/dd/yyyy");
            refreshData();
        }

        private void refreshData()
        {
            using (context = new SprintsListDBAccess())
            {
                dataGridView1.DataSource = context.getResults(tbSprintName.Text, DateTime.Parse(tbEndDate.Text));
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            refreshData();
            btnSearch.Enabled = true;
        }

        private void tbEndDate_Validated(object sender, EventArgs e)
        {
            DateTime output;
            if(DateTime.TryParse(tbEndDate.Text,out output) == false)
                tbEndDate.Text = DateTime.Today.AddMonths(-3).ToString("MM/dd/yyyy");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    SprintDetail.SprintDetail sprintDetail = new SprintDetail.SprintDetail(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ProjectID"].Value.ToString()));
                    ((FrmMain)parent).LoadChildForm(sprintDetail);
                    break;
                case 1:
                    SprintTaskList.SprintTaskList sprintTaskList = new SprintTaskList.SprintTaskList(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ProjectID"].Value.ToString()), parent);
                    ((FrmMain)parent).LoadChildForm(sprintTaskList);
                    break;
                    

            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            SprintDetail.SprintDetail sprintDetail = new SprintDetail.SprintDetail();
            ((FrmMain)parent).LoadChildForm(sprintDetail);
        }
    }
}
