using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumProjectTracking.DataAccess
{
    public class Sprint
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SprintID { get; set; }
        public string SprintName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime AddedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }


    }
}
