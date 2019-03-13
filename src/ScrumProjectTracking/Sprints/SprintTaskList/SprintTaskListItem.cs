using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.Sprints.SprintTaskList
{
    public class SprintTaskListItem
    {
        public int SprintTaskID { get; set; }
        public int SprintID { get; set; }
        public int ProjectID { get; set; }
        public int? TeamID { get; set; }
        public string AssignedToUserID { get; set; }
        public string TaskName { get; set; }
        public string TaskStatus { get; set; }
        public string ProjectName { get; set; }
        public string TeamName { get; set; }
        public string AssignedToName { get; set; }
        public string SprintName { get; set; }

    }
}
