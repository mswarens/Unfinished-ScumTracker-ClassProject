using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Maintenance;

namespace ScrumProjectTracking.Forms

{
    public partial class FrmUsers : Form
    {

        public FrmUsers()
        {
            InitializeComponent();
            fillData();
        }

        MaintenanceData m = new MaintenanceData();

        private void FrmUsers_Load(object sender, EventArgs e)
        {

        }
        
        private void fillData()
        {
            dataGridView1.DataSource = m.userData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
