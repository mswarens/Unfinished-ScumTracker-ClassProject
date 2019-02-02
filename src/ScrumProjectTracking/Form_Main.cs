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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            fillSprintData();

        }

       private void fillSprintData ()
        {
            using (ScrumEntities scrumEntity = new ScrumEntities())
            {
                var results = from s in scrumEntity.Tbl_Sprints
                              where s.BeginDate <= DateTime.Today && s.EndDate >= DateTime.Today
                              select new { s.SprintName, s.BeginDate, s.EndDate };
                if (results.Count() > 0)
                {
                    lbSprintName.Text = results.First().SprintName;
                    lbSprintBeginDate.Text = results.First().BeginDate.ToShortDateString();
                    lbSprintEndDate.Text = results.First().EndDate.ToShortDateString();
                }
                
            }
        }
    }
}
