using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataAccess
{
   public class ScrumTestSource : IDataAccess, IDisposable

    {


        public List<Team> teams { get; } = new List<Team>();
        public List<Sprint> sprints { get; } = new List<Sprint>();
        public List<Project> projects { get; } = new List<Project>();
        public List<SprintTask> sprintTasks { get; } = new List<SprintTask>();
        public List<User> users { get; } = new List<User>();
        public List<Story> stories { get; } = new List<Story>();
        public List<SprintTaskNote> sprintTaskNotes { get; } = new List<SprintTaskNote>();

        

        public IEnumerable<Team> Teams => teams;

        public IEnumerable<Sprint> Sprints => sprints;

        public IEnumerable<SprintTask> SprintTasks => sprintTasks;

        public IEnumerable<Project> Projects => projects;

        public IEnumerable<User> Users => users;

        public IEnumerable<Story> Stories => stories;

        public IEnumerable<SprintTaskNote> SprintTaskNotes => sprintTaskNotes;

        public void Dispose() { }

        public void SaveChanges() { }

        public ScrumTestSource getContext() => this;
    }
}
