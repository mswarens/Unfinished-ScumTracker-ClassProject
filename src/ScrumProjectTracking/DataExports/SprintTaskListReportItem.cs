using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataExports
{
    public class SprintTaskListReportItem
    {
        public int sprintTaskID { get; set; }
        public string sprintName { get; set; }
        public string taskName { get; set; }
        public string teamName { get; set; }
        public string assignedToName { get; set; }
        public string projectName { get; set; }
        public int storyPoints { get; set; }
        public string taskStatus { get; set; }
        public string taskSubStatus { get; set; }
        public int taskCompletionPercent { get; set; }

    }
}
