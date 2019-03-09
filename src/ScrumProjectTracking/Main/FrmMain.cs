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
using ScrumProjectTracking.DataAccess;
using System.Resources;
namespace ScrumProjectTracking.Main
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

            this.Hide();
            Form login = new FrmLogin();
            login.ShowDialog();
            if (CurrentUser.authenticated) {
                this.Show();


                Dashboard.MdiParent = this;
                Dashboard.Dock = DockStyle.Bottom;


                tabControl1.Dock = DockStyle.Top;
                Dashboard.Show();
                tabControl1.Size = new Size(this.Width, Dashboard.Location.Y);

            }
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
            {
                tabControl1.Show();
               

            }
            form.Show();
        }

     

        private void sprintTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScrumProjectTracking.Sprints.SprintsList.SprintsList sprintList = new Sprints.SprintsList.SprintsList();
            LoadChildForm(sprintList);
        }

        public void refreshDashboard()
        {
            Dashboard.fillSprintData();
        }

      

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle r = e.Bounds;
            r.Offset(2, 2);
            Brush titleBrush = new SolidBrush(Color.Black);
                      
            
            e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, this.Font, titleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(ScrumProjectTracking.Properties.Resources.btnClose, r.X + tabControl1.GetTabRect(e.Index).Width - 17,4,10,10);
        }

       

        private void tabControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rectangle r = tabControl1.GetTabRect(tabControl1.SelectedIndex);
                Rectangle s = new Rectangle(r.Right - 17, 4, 10, 10);
                if (s.Contains(e.Location)) {
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                }

            }
        }
    }
}
