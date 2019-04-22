using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Forms;

namespace ScrumProjectTracking.Backlog
{
    public class BacklogData
    {
        ScrumDBSource data = new ScrumDBSource();

        List<ValidationError> validationErrors = new List<ValidationError>();
        public List<Team> getTeamList()
        {
            return data.Teams.Where(a => a.Disabled == false).ToList();
        }
        public List<Project> getProjectData(int ProjectID)
        {
            return data.Projects.Where(a => a.ProjectID == ProjectID).ToList();
        }

        public List<ProjectListItem> getActiveProjectList ()
        {
            return (from a in data.Projects
                    where a.ProjectEndDate >= DateTime.Now.Date
                    let b = (from c in data.Stories where c.ProjectID == a.ProjectID select c.ProjectID)
                    select new ProjectListItem { ProjectID = a.ProjectID, ProjectName = a.ProjectName, ProjectEndDate = a.ProjectEndDate, PendingStoryCount = b.Count(), ProjectBeginDate = a.ProjectBeginDate }).ToList();
     
             

        }

        public List<Story> getStoryList(int projectID, string status)
        {
            return data.Stories.Where(a => a.ProjectID == projectID && a.Status == status).ToList();
        }
       
       
        public Story getStory (int storyID)
        {
            return data.Stories.Where(a => a.StoryID == storyID).FirstOrDefault();
        }


        public Story getNewStory()
        {
            Story newStory = new Story();
            newStory.Status = "New";
            return newStory;
        }

        public bool validateRecord(Story st)
        {
            validationErrors.Clear();
            if ((st.StoryName ?? "").Trim() == "")
                addValidationError("Story Name", "The value must not be blank.");
            if ((st.UserStory ?? "").Trim() == "")
                addValidationError("Story Description", "The value must not be blank.");
            if ((st.Priority ?? "").Trim() == "")
                addValidationError("Priority", "The value must not be blank.");
            if (st.ProjectID == 0)
                addValidationError("Project", "The value must not be blank.");
            if ((st.Status ?? "").Trim() == "")
                addValidationError("Status", "The value must not be blank.");
            return (validationErrors.Count() > 0) ? true : false;
        }

        private void addValidationError(string fieldName, string validationError) => validationErrors.Add(new ValidationError { ErrorMessage = validationError, FieldName = fieldName });

        public void addStory(Story newStory)
        {
            data.getContext.Add(newStory);
        }

        public bool storyChanged(Story story)
        {
            return data.getContext.Entry(story).State != Microsoft.EntityFrameworkCore.EntityState.Unchanged;
        }

        public void saveStory()
        {

            data.SaveChanges();
        }

        public List<ValidationError> getValidationErrors() => validationErrors;
    }
}
