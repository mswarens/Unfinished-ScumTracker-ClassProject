using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataAccess
{
    class ScrumDBSource : IDataAccess , IDisposable
    {
        ScrumContext context = new ScrumContext();
        
       public IEnumerable<SprintTask> SprintTasks => context.SprintTasks;

       public IEnumerable<Sprint> Sprints => context.Sprints;

        public IEnumerable<Team> Teams => context.Teams;

        public IEnumerable<User> Users => context.Users;

        public IEnumerable<Project> Projects => context.Projects;

        public IEnumerable<Backlog> Backlogs => context.Backlogs;

        public void Dispose()
        {
            context.Dispose();
            
        }

        public void SaveChanges() => context.SaveChanges();

        public ScrumContext getContext => context;
    }
}
