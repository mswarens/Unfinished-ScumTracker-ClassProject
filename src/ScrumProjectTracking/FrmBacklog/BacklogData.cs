using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.DataAccess;

namespace ScrumProjectTracking.FrmBacklog
{
    public class BacklogData
    {
        ScrumDBSource data = new ScrumDBSource();
        ScrumContext dataManipulation = new ScrumContext();
        
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
        public List<Backlog> backlogData()
        {
            return (data.Backlogs).ToList();
        }
        public void newBacklogRow(int BlID, int PrID, int TID, string Story, int StrPoints, int Prior, string AddB, DateTime AddDT)
        {
            var dataObject = new Backlog()
            {
                BacklogID = BlID,
                ProjectID = PrID,
                UserStory = Story,
                StoryPoints = StrPoints,
                Priority = Prior,
                AddedBy = AddB,
                AddedDateTime = AddDT

            };

            dataManipulation.Add(dataObject);
        }
    }
}
