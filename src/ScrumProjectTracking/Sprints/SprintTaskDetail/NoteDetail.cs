using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Main;
namespace ScrumProjectTracking.Sprints.SprintTaskDetail
{
    public partial class NoteDetail : Form
    {

        int sprintTaskID;

        public NoteDetail (int sprintTaskID)
        {
            InitializeComponent();
            this.sprintTaskID = sprintTaskID;
            tbNoteText.ReadOnly = false;
            btnSave.Enabled = true;
        }

        public NoteDetail(string sprintNoteText)
        {
            InitializeComponent();
            tbNoteText.Text = sprintNoteText;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNoteText.Text.Trim() != "") {
                using (ScrumDBSource context = new ScrumDBSource())
                {
                    SprintTaskNote newNote = new SprintTaskNote();
                    newNote.SprintTaskID = sprintTaskID;
                    newNote.NoteText = tbNoteText.Text;
                    newNote.AddedBy = CurrentUser.UserID;
                    newNote.AddedDateTime = DateTime.Now;
                    context.getContext.SprintTaskNotes.Add(newNote);
                    context.SaveChanges();
                }
                btnSave.Enabled = false;
                tbNoteText.ReadOnly = true;
            }
        }
    }
}
