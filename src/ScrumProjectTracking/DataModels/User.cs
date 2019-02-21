using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataModels
{
    public class User
    {
        public string UserID { get; set;  }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int TeamID { get; set; }
        public string Password { get; set; }
        public bool Disabled { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime AddedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
