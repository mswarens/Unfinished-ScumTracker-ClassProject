using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.Backlog
{
   public class ProjectListItem
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectBeginDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public int PendingStoryCount { get; set; }
    }
}
