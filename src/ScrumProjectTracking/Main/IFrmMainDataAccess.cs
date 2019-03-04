using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess; 

namespace ScrumProjectTracking.Main
{
     interface IFrmMainDataAccess : IDisposable
    {
        IDataAccess dataContext { get;  }

        SprintInfo getCurrentSprintInfo();

        SprintInfo getNextSprintInfo();

        List<PendingSprintTask> getPendingTasks(string userName, int sprintID);

        int getTotalTasks(string userName, int sprintID);

        int getTotalStoryPoints(string userName, int sprintID);

        



    }
}
