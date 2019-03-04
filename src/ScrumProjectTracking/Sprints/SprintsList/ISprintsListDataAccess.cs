using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.Sprints.SprintsList
{
    interface ISprintsListDataAccess
    {

        List<SprintsListItem> getResults(string sprintName, DateTime endDate);
     
    }
}
