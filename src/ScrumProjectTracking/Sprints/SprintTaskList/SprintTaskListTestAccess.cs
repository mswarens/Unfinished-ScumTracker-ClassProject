using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess;
using System.Data.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace ScrumProjectTracking.Sprints.SprintTaskList
{
    public class SprintTaskListTestAccess : ISprintTaskListDataAccess
    {
        public ScrumTestSource DBSource = new ScrumTestSource();



        public List<SprintTaskListItem> getResults(string taskName, int sprintID, int projectID, int teamID, string assignedUserID, List<string> taskStatus)
        {

            
                var a = from s in DBSource.SprintTasks
                        join p in DBSource.Projects on s.ProjectID equals p.ProjectID
                        join t in DBSource.Teams on s.TeamID equals t.TeamID
                        join u in DBSource.Users on s.AssignedUserID equals u.UserID
                        join sp in DBSource.Sprints on s.SprintID equals sp.SprintID
                        select new SprintTaskListItem { SprintTaskID = s.SprintTaskID, AssignedToName = u.LastName + ", " + u.FirstName, ProjectName = p.ProjectName, TaskName = s.TaskName, TaskStatus = s.TaskStatus, TeamName = t.TeamName, AssignedToUserID = s.AssignedUserID, ProjectID = s.ProjectID, SprintID = s.SprintID, TeamID = s.TeamID, SprintName = sp.SprintName };

           
            
                if (taskName != null)
                    a = a.Where(x => x.TaskName.Contains(taskName));

                if (sprintID != 0)
                    a = a.Where(x => x.SprintID == sprintID);

                if (projectID != 0)
                    a = a.Where(x => x.ProjectID == projectID);

                if (teamID != 0)
                    a = a.Where(x => x.TeamID == teamID);

                if (assignedUserID != null)
                    a = a.Where(x => x.AssignedToUserID == assignedUserID);


                a = a.Where(x => taskStatus.Contains(x.TaskStatus));

                return a.ToList();





            

        }
        public List<SprintTaskListItem> getResultsByID(int sprintTaskID)
        {

            
                var a = from s in DBSource.SprintTasks
                        join p in DBSource.Projects on s.ProjectID equals p.ProjectID
                        join t in DBSource.Teams on s.TeamID equals t.TeamID
                        join u in DBSource.Users on s.AssignedUserID equals u.UserID
                        join sp in DBSource.Sprints on s.SprintID equals sp.SprintID
                        where s.SprintTaskID == sprintTaskID
                        select new SprintTaskListItem { SprintTaskID = s.SprintTaskID, AssignedToName = u.LastName + ", " + u.FirstName, ProjectName = p.ProjectName, TaskName = s.TaskName, TaskStatus = s.TaskStatus, TeamName = t.TeamName, AssignedToUserID = s.AssignedUserID, ProjectID = s.ProjectID, SprintID = s.SprintID, TeamID = s.TeamID, SprintName = sp.SprintName, TaskCompletionPercent = s.TaskCompletionPercent, StoryPoints = s.StoryPoints, TaskSubstatus = s.TaskSubStatus };
                return a.ToList();
           

        }
    }
}
