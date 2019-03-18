using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataAccess
{
    class ScrumTestSource : IDataAccess, IDisposable

    {

        List<Team> teams = new List<Team>();
        List<Sprint> sprints = new List<Sprint>();
        List<Project> projects = new List<Project>();
        List<SprintTask> sprintTasks = new List<SprintTask>();
        List<User> users = new List<User>();
        List<Backlog> backlogs = new List<Backlog>();


        public IEnumerable<Team> Teams => teams;

        public IEnumerable<Sprint> Sprints => sprints;

        public IEnumerable<SprintTask> SprintTasks => sprintTasks;

        public IEnumerable<Project> Projects => projects;

        public IEnumerable<User> Users => users;

        public IEnumerable<Backlog> Backlogs => Backlogs;
        public void Dispose()
        {
            

        }
    }
}
