using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Main;
namespace ScrumProjectTracking.Main
{
     interface IFrmMainDataAccess : IDisposable
    {
        IDataAccess dataContext { get;  }

        SprintInfo getCurrentSprintInfo();

        SprintInfo getNextSprintInfo();

        List<PendingSprintTask> getPendingTasks(string userName, int sprintID);

        int getTotalTasksUser(string userName, int sprintID);

        int getTotalStoryPointsUser(string userName, int sprintID);

        int getTotalStoryPointsTeam(int teamID, int sprintID);

        int getTotalTasksTeam(int teamID, int sprintID);

        int getPendingTasksTeam(int teamID, int sprintID);

        int getPendingStoryPointsTeam(int teamID, int sprintID);

    }
}
