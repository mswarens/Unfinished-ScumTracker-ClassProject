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
        Frm_Dashboard_Development Dashboard;
        public FrmMain()
        {
            InitializeComponent();
            Dashboard = new Frm_Dashboard_Development(this);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            
            Dashboard.MdiParent = this;
            Dashboard.Dock = DockStyle.Bottom;
          
           
            tabControl1.Dock = DockStyle.Top;
            Dashboard.Show();
            tabControl1.Size = new Size(this.Width, Dashboard.Location.Y);

     
        }

    public void LoadChildForm(Form form)
        {
            if (tabControl1.TabCount > 10)
            {
                MessageBox.Show("Additional windows cannot be opened.  Please close an existing window and try the operation again");
                return;
            }
            form.MdiParent = this;
            TabPage newtab = new TabPage(form.Text);
            newtab.Controls.Add(form);
            tabControl1.Controls.Add(newtab);
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;
            if (tabControl1.TabCount == 1)
                tabControl1.Show();
            form.Show();
        }
        
     

      
    }
}
