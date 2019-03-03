using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumProjectTracking
{
    public partial class FrmLogin : Form
    {
        bool closedCorrectly = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            closedCorrectly = true;
            this.Close();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closedCorrectly)
            {
                Application.Exit();
            }
        }
    }
}
