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
namespace ScrumProjectTracking.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            Frm_Dashboard_Development Dashboard = new Frm_Dashboard_Development();
            Dashboard.MdiParent = this;
            Dashboard.Dock = DockStyle.Fill;
            Dashboard.Size = new Size(this.Width, Dashboard.Height);
            Dashboard.Show();
        }
    }
}
