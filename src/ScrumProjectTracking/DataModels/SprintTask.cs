using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataModels
{
    public class SprintTask
    {
        
        public int SprintTaskID { get; set; }
        public int ProjectID { get; set; }
        public int SprintID { get; set; }
        public int TeamID { get; set; }
        public string AssignedUserID { get; set; }
        public string TaskName { get; set; }
        public string TaskStatus { get; set; }
        public int TaskCompletionPercent { get; set; }
        public string Description { get; set; }
        public int StoryPoints { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime AddedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
