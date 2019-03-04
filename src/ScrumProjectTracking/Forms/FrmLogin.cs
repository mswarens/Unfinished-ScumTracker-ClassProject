using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypt = BCrypt.Net.BCrypt;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Forms;

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
            string userN = loginUsername.Text;
            IDataAccess dc = new ScrumDBSource();
            var userNFromTable = from u in dc.Users where u.UserID == userN select u.UserID;

            if (userNFromTable.FirstOrDefault() != null)
            {     
                string passW = loginPassword.Text;
                var hashTest = (from u in dc.Users where u.UserID == userN select u.PasswordHash).ToArray();
                if (Crypt.Verify(passW, hashTest[0]))
                {
                    Console.WriteLine("Test");
                    closedCorrectly = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: The provided password was incorrect. Passwords are case-sensitive.");
                }
            }
            else
            {
                MessageBox.Show("Error: The provided username was not found. Usernames are case-sensitive.");
            }


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
