using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataAccess
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string TeamType { get; set; }
        public bool Disabled { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime AddedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
