using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.Sprints.SprintTaskList
{
    interface ISprintTaskListDataAccess 
    {
        List<SprintTaskListItem> getResults(string taskName, int sprintID, int projectID, int teamID, string assignedUserID, List<string> taskStatus);

        
    }
}
