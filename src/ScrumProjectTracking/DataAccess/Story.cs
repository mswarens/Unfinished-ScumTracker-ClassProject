using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumProjectTracking.DataAccess
{
    public class Story
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoryID { get; set; }
        public string StoryName { get; set;  }
        public string Status { get; set;  }
        public int ProjectID { get; set; }
        public string UserStory { get; set; }
        public int? StoryPoints { get; set; }
        public string Priority { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
