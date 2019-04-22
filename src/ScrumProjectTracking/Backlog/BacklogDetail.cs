using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.Main;
using System.ComponentModel.DataAnnotations.Schema;
using ScrumProjectTracking.DataAccess;
namespace ScrumProjectTracking.Backlog
{
    public partial class BacklogDetail : Form
    {
        BacklogData backlogData = new BacklogData();
        Story currentStory;
        public BacklogDetail()
        {
            InitializeComponent();
            currentStory = backlogData.getNewStory();
            fillDropDownSelections();
            storyBindingSource.DataSource = currentStory;

        }

        public BacklogDetail(int storyID)
        {
            InitializeComponent();
            currentStory = backlogData.getStory(storyID);
            fillDropDownSelections();
            storyBindingSource.DataSource = currentStory;
        }

        private void fillDropDownSelections()
        {
            var l = backlogData.getActiveProjectList();
            l.Insert(0, new ProjectListItem { ProjectID = 0, ProjectName = "" });
            cbProjectID.DataSource = l;
            cbProjectID.DisplayMember = "ProjectName";
            cbProjectID.ValueMember = "ProjectID";
        }




        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (backlogData.storyChanged(currentStory))
            {
                if (backlogData.validateRecord(currentStory))
                {
                    string errorMessage = "This record cannot be saved due to the following validation errors:\n";
                    errorMessage += String.Join("\n", backlogData.getValidationErrors().Select(a => a.FieldName + " - " + a.ErrorMessage));
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (currentStory.AddedBy == null)
                    {
                        currentStory.AddedBy = CurrentUser.UserID;
                        currentStory.AddedDateTime = DateTime.Now;
                        backlogData.addStory(currentStory);

                    }
                    currentStory.UpdatedBy = CurrentUser.UserID;
                    currentStory.UpdatedDateTime = DateTime.Now;

                    backlogData.saveStory();
                    storyBindingSource.ResetBindings(false);
                    ((ScrumProjectTracking.Main.FrmMain)this.ParentForm).refreshDashboard();
                }
            }


        }
    }
}
