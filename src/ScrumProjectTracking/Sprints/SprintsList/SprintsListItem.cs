using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.Sprints.SprintsList
{
    public class SprintsListItem
    {
        public int SprintID { get; set; }
        public string SprintName { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalTasks { get; set; }
        public int TotalStoryPoints { get; set; }
        public int CompletedTasks { get; set; }
        public int CompletedStoryPoints { get; set; }
        public int PendingTasks { get; set; }
        public int PendingStoryPoints { get; set; }
    }
}
