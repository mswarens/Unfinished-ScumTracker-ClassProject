using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Forms;

namespace ScrumProjectTracking.Sprints.SprintDetail
{
    public interface ISprintDetailDataAccess
    {
        List<ValidationError> getValidationErrors();

        Sprint getSprint(int sprintID);

        Sprint getNewSprint();

        void saveSprint();

        bool validateRecord(Sprint st);

        void addSprint(Sprint newSprintTask);

        bool sprintChanged(Sprint sprint);

    }
}
