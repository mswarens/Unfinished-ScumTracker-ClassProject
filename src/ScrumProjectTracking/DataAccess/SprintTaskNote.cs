using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataAccess
{
    public class SprintTaskNote
    {
        public int SprintTaskNoteID { get; set; }
        public int SprintTaskID { get; set; }
        public string NoteText { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDateTime { get; set; }
    }
}
