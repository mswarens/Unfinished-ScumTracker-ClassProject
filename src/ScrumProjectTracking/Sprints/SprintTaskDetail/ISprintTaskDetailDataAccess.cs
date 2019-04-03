using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess;
using ScrumProjectTracking.Forms;
namespace ScrumProjectTracking.Sprints.SprintTaskDetail
{
    interface ISprintTaskDetailDataAccess : IDisposable
    {
        

         List<ValidationError> getValidationErrors();

         SprintTask getSprintTask(int sprintTaskID);

        SprintTask getNewSprintTask();

        void saveSprintTask();

        List<SprintListItem> getSprintList();

        List<ProjectListItem> getProjectList();

        List<TeamListItem> getTeamList();

        List<UserListItem> getUserList(int? teamID);

        bool validateRecord(SprintTask st);

        void addSprintTask(SprintTask newSprintTask);

        bool sprintTaskChanged(SprintTask sprintTask);

        List<SprintTaskNote> getSprintTaskNotes(int sprintTaskID);

        void deleteSprintTaskNote(int sprintTaskNoteID);


    }
}
