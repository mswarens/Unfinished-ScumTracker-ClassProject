using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.FrmBacklog;

namespace ScrumProjectTracking.Main
{
    public partial class Backlog : Form
    {
        public Backlog()
        {
            InitializeComponent();
            loadDataInitial();
        }

        BacklogData b = new BacklogData();
        
        private void loadDataInitial()
        {
            comboBox1.DataSource = b.projectData();
            comboBox1.DisplayMember = "ProjectName";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

    }
}
