using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrumProjectTracking.Sprints.SprintTaskDetail;
using ScrumProjectTracking.DataAccess;
using System.Collections.Generic;
using ScrumProjectTracking.Forms;
namespace ScrumProjectTrackingTest.Sprints.SprintTaskDetail
   
{
    [TestClass]
    public class SprintTaskDetailUnitTests
    {
        [TestMethod]
        public void getProjectListCountTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            List<ProjectListItem> projectList = sprintTaskDetailTest.getProjectList();
            Assert.IsTrue(projectList.Count == 2, "Project list count does not equal expected value.");
           

        }

        [TestMethod]
        public void getProjectListCountTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            List<ProjectListItem> projectList = sprintTaskDetailTest.getProjectList();
            Assert.IsTrue(projectList.Count == 1, "Project list count does not equal expected value.");


        }

        [TestMethod]
        public void getProjectListProjectNameTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            List<ProjectListItem> projectList = sprintTaskDetailTest.getProjectList();
            Assert.IsTrue(projectList[1].ProjectName == "Project 1","Project name does not equal expected value.");


        }

        [TestMethod]
        public void getProjectListProjectNameTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            List<ProjectListItem> projectList = sprintTaskDetailTest.getProjectList();
            Assert.IsTrue(projectList[0].ProjectName == String.Empty, "Project name does not equal expected value.");


        }

        [TestMethod]
        public void getProjectListProjectIDTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            List<ProjectListItem> projectList = sprintTaskDetailTest.getProjectList();
            Assert.IsTrue(projectList[0].ProjectID == 0, "Project ID does not equal expected value.");


        }

        [TestMethod]
        public void getProjectListProjectIDTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            List<ProjectListItem> projectList = sprintTaskDetailTest.getProjectList();
            Assert.IsTrue(projectList[1].ProjectID == 1, "Project ID does not equal expected value.");


        }


        [TestMethod]
        public void getsprintListCountTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            List<SprintListItem> sprintList = sprintTaskDetailTest.getSprintList();
            Assert.IsTrue(sprintList.Count == 2, "Sprint list count does not equal expected value.");


        }

        [TestMethod]
        public void getsprintListCountTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            List<SprintListItem> sprintList = sprintTaskDetailTest.getSprintList();
            Assert.IsTrue(sprintList.Count == 1, "Sprint list count does not equal expected value.");


        }

        [TestMethod]
        public void getsprintListSprintNameTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            List<SprintListItem> sprintList = sprintTaskDetailTest.getSprintList();
            Assert.IsTrue(sprintList[1].SprintName == "Sprint 1", "Sprint name does not equal expected value.");


        }

        [TestMethod]
        public void getsprintListSprintNameTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            List<SprintListItem> sprintList = sprintTaskDetailTest.getSprintList();
            Assert.IsTrue(sprintList[0].SprintName == String.Empty, "Sprint name does not equal expected value.");


        }

        [TestMethod]
        public void getsprintListSprintIDTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            List<SprintListItem> sprintList = sprintTaskDetailTest.getSprintList();
            Assert.IsTrue(sprintList[0].SprintID == 0, "Sprint ID does not equal expected value.");


        }

        [TestMethod]
        public void getsprintListSprintIDTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            List<SprintListItem> sprintList = sprintTaskDetailTest.getSprintList();
            Assert.IsTrue(sprintList[1].SprintID == 1, "Sprint ID does not equal expected value.");


        }

        [TestMethod]
        public void getteamListCountTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            List<TeamListItem> teamList = sprintTaskDetailTest.getTeamList();
            Assert.IsTrue(teamList.Count == 2, "Team list count does not equal expected value.");


        }

        [TestMethod]
        public void getteamListCountTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            List<TeamListItem> teamList = sprintTaskDetailTest.getTeamList();
            Assert.IsTrue(teamList.Count == 1, "Team list count does not equal expected value.");


        }

        [TestMethod]
        public void getteamListteamNameTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            List<TeamListItem> teamList = sprintTaskDetailTest.getTeamList();
            Assert.IsTrue(teamList[1].TeamName == "Team 1", "Team name does not equal expected value.");


        }

        [TestMethod]
        public void getteamListTeamNameTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            List<TeamListItem> teamList = sprintTaskDetailTest.getTeamList();
            Assert.IsTrue(teamList[0].TeamName == String.Empty, "Team name does not equal expected value.");


        }

        [TestMethod]
        public void getteamListSprintIDTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            List<TeamListItem> teamList = sprintTaskDetailTest.getTeamList();
            Assert.IsTrue(teamList[0].TeamID == 0, "Team ID does not equal expected value.");


        }


        [TestMethod]
        public void getteamListSprintIDTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            List<TeamListItem> teamList = sprintTaskDetailTest.getTeamList();
            Assert.IsTrue(teamList[1].TeamID == 1, "Team ID does not equal expected value.");


        }



        [TestMethod]
        public void getuserListCountTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskDetailTest.dc.users.Add(new User { UserID = "Test", TeamID = 1 });
            List<UserListItem> userList = sprintTaskDetailTest.getUserList(1);
            Assert.IsTrue(userList.Count == 2, "User list count does not equal expected value.");


        }

        [TestMethod]
        public void getuserListCountTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            List<UserListItem> teamList = sprintTaskDetailTest.getUserList(1);
            Assert.IsTrue(teamList.Count == 1, "User list count does not equal expected value.");


        }

        [TestMethod]
        public void getuserListuserIDTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskDetailTest.dc.users.Add(new User { UserID = "Test", TeamID = 1 });
            List<UserListItem> userList = sprintTaskDetailTest.getUserList(1);
            Assert.IsTrue(userList[1].UserID == "Test", "User name does not equal expected value.");


        }

        [TestMethod]
        public void getuserListuserIDTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskDetailTest.dc.users.Add(new User { UserID = "Test", TeamID = 1 });
            List<UserListItem> userList = sprintTaskDetailTest.getUserList(1);
            Assert.IsTrue(userList[0].UserID == "", "User name does not equal expected value.");

        }

        [TestMethod]
        public void getuserListDisplayNameTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskDetailTest.dc.users.Add(new User { UserID = "Test", TeamID = 1 , LastName = "Doe", FirstName = "John"});
            List<UserListItem> userList = sprintTaskDetailTest.getUserList(1);
            Assert.IsTrue(userList[0].DisplayName == "", "Display name does not equal expected value.");


        }


        [TestMethod]
        public void getuserListDisplayNameTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            sprintTaskDetailTest.dc.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskDetailTest.dc.users.Add(new User { UserID = "Test", TeamID = 1, LastName = "Doe", FirstName = "John" });
            List<UserListItem> userList = sprintTaskDetailTest.getUserList(1);
            Assert.IsTrue(userList[1].DisplayName == "Doe, John", "Display name does not equal expected value.");


        }

        [TestMethod]

        public void validateRecordErrorsFoundTest1 ()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            bool errorsFound = sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(errorsFound == false, "Validate record error found does not equal expectged value.");
        }

        [TestMethod]

        public void validateRecordErrorsFoundTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";
            
            bool errorsFound = sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(errorsFound, "Validate record error found does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordDescriptionTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";

            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].FieldName == "Description", "Validate record error field does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordDescriptionTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";

            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].ErrorMessage == "The value must not be blank.", "Validate record error description does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordSprintIDTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].FieldName == "Sprint", "Validate record error field does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordSprintIDTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].ErrorMessage == "The value must not be blank.", "Validate record error description does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordProjectIDTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            
            st.TaskName = "Test Task";
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].FieldName == "Project", "Validate record error field does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordProjecttIDTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            
            st.TaskName = "Test Task";
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].ErrorMessage == "The value must not be blank.", "Validate record error description does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordTaskNameTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].FieldName == "Task Name", "Validate record error field does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordTaskNameTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].ErrorMessage == "The value must not be blank.", "Validate record error description does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordTeamIDTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].FieldName == "Team", "Validate record error field does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordTeamIDTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            
            st.TaskStatus = "Pending";
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].ErrorMessage == "The value must not be blank.", "Validate record error description does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordTaskStatusTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            st.TeamID = 1;
            
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].FieldName == "Status", "Validate record error field does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordTaskStatusTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            st.TeamID = 1;
            
            st.TaskSubStatus = "Gathering requirements";
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].ErrorMessage == "The value must not be blank.", "Validate record error description does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordSubstatusTest1()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].FieldName == "Substatus", "Validate record error field does not equal expected value.");
        }

        [TestMethod]
        public void validateRecordSubstatusTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = new SprintTask();
            st.SprintID = 1;
            st.ProjectID = 1;
            st.TaskName = "Test Task";
            st.TeamID = 1;
            st.TaskStatus = "Pending";
            
            st.Description = "Test description";
            sprintTaskDetailTest.validateRecord(st);
            Assert.IsTrue(sprintTaskDetailTest.getValidationErrors()[0].ErrorMessage == "The value must not be blank.", "Validate record error description does not equal expected value.");
        }

        [TestMethod]

        public void getNewSprintTaskTest1 ()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = sprintTaskDetailTest.getNewSprintTask();
            Assert.IsTrue(st.TaskStatus == "Pending", "New task status does not equal expected value.");

        }

        [TestMethod]
        public void getNewSprintTaskTest2()
        {
            SprintTaskDetailTestAccess sprintTaskDetailTest = new SprintTaskDetailTestAccess();
            SprintTask st = sprintTaskDetailTest.getNewSprintTask();
            Assert.IsTrue(st.TaskSubStatus == "Requirements gathering", "New task substatus does not equal expected value.");

        }
    }

}
