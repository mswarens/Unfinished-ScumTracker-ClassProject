using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataAccess
{
    public class Backlog
    {
        public int BacklogID { get; set; }
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public int TeamID { get; set; }
        public string UserStory { get; set; }
        public int StoryPoints { get; set; }
        public int Priority { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
