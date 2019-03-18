using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.Main
{
    public class PendingSprintTask
    {
        public int SprintTaskID { get; set;  }
        public string TaskName { get; set; }
        public string ProjectName { get; set; }
        public string TaskSubStatus { get; set; }
        public int StoryPoints { get; set; }
        public int TaskCompletionPercent { get; set; }
    }
}
