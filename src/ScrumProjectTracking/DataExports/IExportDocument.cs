using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.Sprints.SprintTaskList;

namespace ScrumProjectTracking.DataExports
{
    public interface IExportDocument
    {

         string exportData(List<SprintTaskListItem> results);

    }
}
