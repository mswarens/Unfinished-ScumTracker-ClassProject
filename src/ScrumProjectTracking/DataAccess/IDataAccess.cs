using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScrumProjectTracking.DataAccess
{
    public interface IDataAccess : IDisposable
    {

        IEnumerable<Team> Teams { get; }
        IEnumerable<Sprint> Sprints { get; }
        IEnumerable<SprintTask> SprintTasks { get;  }
        IEnumerable<Project> Projects { get;  }
        IEnumerable<User> Users { get; }
        IEnumerable<Backlog> Backlogs { get; }
       
















    }
}
