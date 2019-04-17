using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Main;

namespace ScrumProjectTracking.Sprints.SprintDetail
{
    public partial class SprintDetail : Form
    {
        SprintDetailDBAccess DBSource = new SprintDetailDBAccess();
        Sprint currentSprint;
        public SprintDetail()
        {
            InitializeComponent();
            currentSprint = DBSource.getNewSprint();
            sprintBindingSource.DataSource = currentSprint;
        }

        public SprintDetail(int sprintID)
        {
            InitializeComponent();
            currentSprint = DBSource.getSprint(sprintID);
            sprintBindingSource.DataSource = currentSprint;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (DBSource.sprintChanged(currentSprint))
            {
                if (DBSource.validateRecord(currentSprint))
                {
                    string errorMessage = "This record cannot be saved due to the following validation errors:\n";
                    errorMessage += String.Join("\n", DBSource.getValidationErrors().Select(a => a.FieldName + " - " + a.ErrorMessage));
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (currentSprint.AddedBy == null)
                    {
                        currentSprint.AddedBy = CurrentUser.UserID;
                        currentSprint.AddedDateTime = DateTime.Now;
                        DBSource.addSprint(currentSprint);

                    }
                    currentSprint.UpdatedBy = CurrentUser.UserID;
                    currentSprint.UpdatedDateTime = DateTime.Now;

                    DBSource.saveSprint();
                    sprintBindingSource.ResetBindings(false);
                     ((ScrumProjectTracking.Main.FrmMain)this.ParentForm).refreshDashboard();
                }
            }
        }
    }
}
