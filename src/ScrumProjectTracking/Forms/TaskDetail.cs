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
namespace ScrumProjectTracking.Forms
{
    public partial class TaskDetail : Form
    {
        public TaskDetail(int taskID)
        {
            InitializeComponent();
            fillData(taskID);
        }

        private void fillData(int taskID)
        {

            using (ScrumContext context = new ScrumContext())
            {
                var taskDetail = from t in context.SprintTasks
                                 where t.SprintTaskID == taskID
                                 select t;
                bindingSource1.DataSource = taskDetail.ToList();

            }
        }




    }
}
