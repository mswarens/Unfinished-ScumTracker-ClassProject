using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess;
using System.Linq.Expressions;
namespace ScrumProjectTracking.Sprints.SprintsList
{
    class SprintsListDBAccess : ISprintsListDataAccess, IDisposable
    {
        ScrumDBSource context = new ScrumDBSource();

        public void Dispose()
        {
            context.Dispose();
        }

        public List<SprintsListItem> getResults(string sprintName, DateTime endDate)
        {
            
            var r = from s in context.Sprints where s.EndDate >= endDate
                     let totalTasksCount = (from t in context.SprintTasks where t.SprintID == s.SprintID && t.TaskStatus != "Cancelled" select t.SprintTaskID)
                    let totalStoryPointsCount = (from t in context.SprintTasks where t.SprintID == s.SprintID && t.TaskStatus != "Cancelled" select t.StoryPoints)
                    let completedTasksCount = (from t in context.SprintTasks where t.SprintID == s.SprintID && t.TaskStatus == "Completed" select t.SprintTaskID)
                    let completedStoryPointsCount = (from t in context.SprintTasks where t.SprintID == s.SprintID && t.TaskStatus == "Completed" select t.StoryPoints)
                    let pendingTasksCount = (from t in context.SprintTasks where t.SprintID == s.SprintID && t.TaskStatus == "Pending" select t.SprintTaskID)
                    let pendingStoryPointsCount = (from t in context.SprintTasks where t.SprintID == s.SprintID && t.TaskStatus == "Pending" select t.StoryPoints)
                    orderby s.BeginDate descending
                    select new SprintsListItem { SprintName = s.SprintName, TotalTasks = totalTasksCount.Count(), TotalStoryPoints = totalStoryPointsCount.Sum(a => a), CompletedTasks = completedTasksCount.Count(), CompletedStoryPoints = completedStoryPointsCount.Sum(a => a), PendingTasks = pendingTasksCount.Count(), PendingStoryPoints = pendingStoryPointsCount.Count(), BeginDate = s.BeginDate, EndDate = s.EndDate, SprintID = s.SprintID };
            if (sprintName != "")
                r = r.Where(s => s.SprintName.ToLower().Contains(sprintName.ToLower()));

            return r.ToList();

        }
    }
}
