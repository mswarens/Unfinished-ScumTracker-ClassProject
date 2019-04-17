using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Forms;

namespace ScrumProjectTracking.Sprints.SprintDetail
{
    public class SprintDetailTestAccess : ISprintDetailDataAccess
    {
        ScrumTestSource dc = new ScrumTestSource();
        List<ValidationError> validationErrors = new List<ValidationError>();

        public List<ValidationError> getValidationErrors() => validationErrors;


        public Sprint getSprint(int sprintID)
        {
            return dc.Sprints.Where(a => a.SprintID == sprintID).FirstOrDefault();
        }




        public void Dispose()
        {
            dc.Dispose();

        }

        public Sprint getNewSprint()
        {
            Sprint st = new Sprint();
         
            return st;

        }



   

        public void saveSprint()
        {

            dc.SaveChanges();
        }

        public bool validateRecord(Sprint st)
        {
            validationErrors.Clear();
            if ((st.SprintName ?? "").Trim() == "")
                addValidationError("Sprint Name", "The value must not be blank.");
            if (st.BeginDate == null)
                addValidationError("Begin Date", "The value must not be blank.");
            if (st.EndDate == null)
                addValidationError("End Date", "The value must not be blank.");
            if (st.EndDate != null && st.EndDate > DateTime.Now.AddDays(120))
                addValidationError("End Date", "The end date cannot be greater than 120 days from the current date.");
            if (st.EndDate != null && st.EndDate < DateTime.Now.AddDays(-90))
                addValidationError("End Date", "The end date cannot be less than 90 days from the current date.");
            if (st.EndDate != null && st.BeginDate > DateTime.Now.AddDays(90))
                addValidationError("Begin Date", "The begin date cannot be greater than 90 days from the current date.");
            if (st.BeginDate != null && st.BeginDate < DateTime.Now.AddDays(-120))
                addValidationError("Begin Date", "The begin date cannot be less than 120 days from the current date.");
            if (dc.Sprints.Where(a => a.EndDate >= st.BeginDate && a.BeginDate <= st.EndDate).Count() > 0)
                addValidationError("Begin/End Date", "The begin and end date range overlaps with an existing sprint.");
            if (st.EndDate != null && st.BeginDate != null && st.BeginDate >= st.EndDate)
                addValidationError("Begin/End Date", "The end date must be greater than the begin date.");
            return (validationErrors.Count() > 0) ? true : false;
        }

        private void addValidationError(string fieldName, string validationError) => validationErrors.Add(new ValidationError { ErrorMessage = validationError, FieldName = fieldName });

        public void addSprint(Sprint newSprint)
        {
            dc.sprints.Add(newSprint);
        }

        public bool sprintChanged(Sprint sprint)
        {
            return true;
        }

    
    }
}
