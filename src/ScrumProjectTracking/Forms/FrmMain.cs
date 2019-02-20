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
          
           
            tabControl1.Dock = DockStyle.Top;
            Dashboard.Show();
            tabControl1.Size = new Size(this.Width, Dashboard.Location.Y);

            TaskDetail frm = new TaskDetail();
            LoadChildForm(frm);

        }

    private void LoadChildForm(Form form)
        {
            form.MdiParent = this;
            TabPage newtab = new TabPage(nameof(form));
            newtab.Controls.Add(form);
            tabControl1.Controls.Add(newtab);

            if (tabControl1.TabCount == 1)
                tabControl1.Show();
            form.Show();
        }

     

      
    }
}
