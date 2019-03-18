using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Forms;

namespace ScrumProjectTracking.Sprints.SprintTaskDetail
{
    class FrmSprintTaskDetailDBAccess : IFrmSprintTaskDetailDataAccess
    {

        ScrumDBSource dc = new ScrumDBSource();
        List<ValidationError> validationErrors = new List<ValidationError>();

        public List<ValidationError> getValidationErrors() => validationErrors;


      //  public ScrumDBSource getDBContext => dc;

        


        public void Dispose()
        {
            dc.Dispose();
            
        }

        public SprintTask getNewSprintTask()
        {
            SprintTask st = new SprintTask();
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Requirements gathering";
            return st;

        }

        public List<ProjectListItem> getProjectList()
        {
            var p = (from t in dc.Projects
                     orderby t.ProjectName
                     select new ProjectListItem { ProjectID = t.ProjectID, ProjectName = t.ProjectName }).ToList();
            p.Insert(0, new ProjectListItem { ProjectID = 0, ProjectName = String.Empty });
            return p;
        }

        public  List<SprintListItem> getSprintList()
        {
            var s = (from t in dc.Sprints
                     orderby t.SprintName
                     select new SprintListItem { SprintID = t.SprintID, SprintName = t.SprintName }).ToList();
            s.Insert(0, new SprintListItem { SprintID = 0, SprintName = String.Empty });
            return s;
                    
        }

        public SprintTask getSprintTask( int sprintTaskID) => dc.SprintTasks.Where(a => a.SprintTaskID == sprintTaskID).FirstOrDefault();

        public List<TeamListItem> getTeamList()
        {
            var s = (from t in dc.Teams
                     orderby t.TeamName
                     select new TeamListItem { TeamID = t.TeamID, TeamName = t.TeamName }).ToList();
            s.Insert(0, new TeamListItem { TeamID = 0, TeamName = String.Empty });
            return s;
        }

        public List<UserListItem> getUserList(int? teamID)
        {
            var u = (from a in dc.Users
                     where a.TeamID == teamID
                     orderby a.LastName + ", " + a.FirstName
                     select new UserListItem { UserID = a.UserID, DisplayName = a.LastName + ", " + a.FirstName }).ToList();
            u.Insert(0, new UserListItem { UserID = String.Empty, DisplayName = String.Empty });
            return u;



        }

        public void saveSprintTask()
        {
            
            dc.SaveChanges();
        }

        public bool validateRecord(SprintTask st)
        {
            validationErrors.Clear();
            if ((st.TaskName ?? "").Trim() == "")
                addValidationError("Task Name", "The value must not be blank.");
            if ((st.TaskStatus ?? "").Trim() == "")
                addValidationError("Status", "The value must not be blank.");
            if ((st.TaskSubStatus ?? "").Trim() == "")
                addValidationError("Substatus", "The value must not be blank.");
            if (st.TeamID == 0)
                addValidationError("Team", "The value must not be blank.");
            if (st.SprintID == 0)
                addValidationError("Sprint", "The value must not be blank.");
            if (st.ProjectID == 0)
                addValidationError("Project", "The value must not be blank.");
            if ((st.Description ?? "").Trim() == "")
                addValidationError("Description", "The value must not be blank.");
            return (validationErrors.Count() > 0) ? true: false;
        }

        private void addValidationError(string fieldName, string validationError) => validationErrors.Add(new ValidationError { ErrorMessage = validationError, FieldName = fieldName });

        public void addSprintTask(SprintTask newSprintTask)
        {
            dc.getContext.Add(newSprintTask);
        }

        public bool sprintTaskChanged(SprintTask sprintTask)
        {
            return dc.getContext.Entry(sprintTask).State != Microsoft.EntityFrameworkCore.EntityState.Unchanged;
        }
    }
}
