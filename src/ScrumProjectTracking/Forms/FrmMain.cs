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
        Frm_Dashboard_Development Dashboard = new Frm_Dashboard_Development();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            
            Dashboard.MdiParent = this;
            Dashboard.Dock = DockStyle.Bottom;
              //  Dashboard.Size = new Size(this.Width, this.Height - mainFormMenu.Height - tabControl.Height - 50);
           
           


            // tabControl.Dock = DockStyle.Top;
            // tabControl.Size = new Size(this.Width, Dashboard.Location.Y);

            //// tabControl.Location = new Point(0, mainFormMenu.Height);
            // tabControl.Margin = new Padding(0);

           
            tabControl1.Dock = DockStyle.Top;
            Dashboard.Show();
            tabControl1.Size = new Size(this.Width, Dashboard.Location.Y);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dashboard.Location.Y.ToString());
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            tabControl1.Size = new Size(this.Width, Dashboard.Location.Y);
        }

       
    }
}
