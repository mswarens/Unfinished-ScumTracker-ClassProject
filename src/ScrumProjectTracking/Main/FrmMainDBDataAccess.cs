using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess;
namespace ScrumProjectTracking.Main
{
    class FrmMainDBDataAccess : IFrmMainDataAccess
    {
        IDataAccess dc = new ScrumDBSource();

        public IDataAccess dataContext => dc;

        public SprintInfo getCurrentSprintInfo()
        {
            var currentSprint = from s in dc.Sprints
                                where s.BeginDate <= DateTime.Today && s.EndDate >= DateTime.Today
                                select new SprintInfo { SprintName = s.SprintName, BeginDate = s.BeginDate, EndDate = s.EndDate, SprintID = s.SprintID };

            return currentSprint.FirstOrDefault();
        }

        public SprintInfo getNextSprintInfo()
        {
            var nextSprintInfo = (from s in dc.Sprints
                                  where s.BeginDate > DateTime.Today
                                  orderby s.BeginDate
                                  select new SprintInfo { SprintName = s.SprintName, BeginDate = s.BeginDate, EndDate = s.EndDate });
            return nextSprintInfo.FirstOrDefault();
        }


        public List<PendingSprintTask> getPendingTasks(string userName, int sprintID)
        {
            var pendingTasks = (from s in dc.SprintTasks
                                join p in dc.Projects on s.ProjectID equals p.ProjectID
                                where s.TaskStatus == "Pending" && s.SprintID == sprintID
                                && s.AssignedUserID == userName
                                orderby p.ProjectName, s.TaskName
                                select new PendingSprintTask { TaskName = s.TaskName, TaskCompletionPercent = s.TaskCompletionPercent, StoryPoints = s.StoryPoints, ProjectName = p.ProjectName, SprintTaskID = s.SprintTaskID, TaskSubStatus = s.TaskSubStatus } );
            return pendingTasks.ToList<PendingSprintTask>();

        }

        public int getTotalTasksUser(string userName, int sprintID) => (from s in dc.SprintTasks
                                                                    where s.SprintID == sprintID && s.TaskStatus != "Cancelled"
                                                                    && s.AssignedUserID == userName
                                                                    select s).Count();
        

        public int getTotalStoryPointsUser(string username, int sprintID) => (from s in dc.SprintTasks
                                                                          where s.SprintID == sprintID && s.TaskStatus != "Cancelled"
                                                                          && s.AssignedUserID == username
                                                                          select s.StoryPoints).Sum();

        public void Dispose()
        {
            dc.Dispose();
        }

        public int getTotalStoryPointsTeam(int teamID, int sprintID) => (from s in dc.SprintTasks where s.SprintID == sprintID && s.TeamID == teamID && s.TaskStatus != "Cancelled" select s.StoryPoints).Sum();

        public int getTotalTasksTeam(int teamID, int sprintID) => (from s in dc.SprintTasks where s.SprintID == sprintID && s.TeamID == teamID && s.TaskStatus != "Cancelled" select s).Count();

        public int getPendingTasksTeam(int teamID, int sprintID) => (from s in dc.SprintTasks where s.SprintID == sprintID && s.TeamID == teamID && s.TaskStatus == "Pending" select s).Count();

        public int getPendingStoryPointsTeam(int teamID, int sprintID) => (from s in dc.SprintTasks where s.SprintID == sprintID && s.TeamID == teamID && s.TaskStatus == "Pending" select s.StoryPoints).Sum();

    }
}
