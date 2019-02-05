using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.DataModels;
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
            using (ScrumContext scrumContext = new ScrumContext())
            {
                var sprintInfo = from s in scrumContext.Sprints
                              where s.BeginDate <= DateTime.Today && s.EndDate >= DateTime.Today
                              select new { s.SprintName, s.BeginDate, s.EndDate, };
                if (sprintInfo.Count() > 0)
                {
                    lbSprintName.Text = sprintInfo.First().SprintName;
                    lbSprintBeginDate.Text = sprintInfo.First().BeginDate.ToShortDateString();
                    lbSprintEndDate.Text = sprintInfo.First().EndDate.ToShortDateString();







                }
                
                
                
                
            }
        }









    }
}
