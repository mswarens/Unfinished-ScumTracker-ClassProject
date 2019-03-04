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

namespace ScrumProjectTracking.Sprints.SprintsList
{
    public partial class SprintsList : Form
    {
        SprintsListDBAccess context;
        public SprintsList()
        {
            InitializeComponent();
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
    }
}
