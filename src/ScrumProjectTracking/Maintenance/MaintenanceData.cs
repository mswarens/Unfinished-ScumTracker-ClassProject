using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess;

namespace ScrumProjectTracking.Maintenance
{
    class MaintenanceData
    {
        IDataAccess data = new ScrumDBSource();
        
        public List<Team> teamData()
        {
            return (data.Teams).ToList();
        }
        public List<Project> projectData()
        {
            return (data.Projects).ToList();
        }
        public List<User> userData()
        {
            return (data.Users).ToList();
        }
    }
}
