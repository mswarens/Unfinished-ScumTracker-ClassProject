using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrumProjectTracking.Sprints.SprintsList;
using System.Collections.Generic;
using ScrumProjectTracking.DataAccess;

namespace ScrumProjectTrackingTest.Sprints.SprintsList
{
    [TestClass]
    public class SprintsListUnitTest
    {
        [TestMethod]
        public void TestGetResultsCountTest1()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 1, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            List<SprintsListItem> items = source.getResults("Mercury",DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items.Count == 0, "GetResults does not return 0 items as expected");
            
        }

        [TestMethod]
        public void TestGetResultsCountTest2()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 1, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("5/1/2019"));

            Assert.IsTrue(items.Count == 0, "GetReesults does not return 0 items as expected");

        }

        [TestMethod]
        public void TestGetResultsCountTest3()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 1, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items.Count == 1, "GetResults does not return 1 item as expected");

        }

        [TestMethod]
        public void TestGetResultsCountTest4()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 1, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            List<SprintsListItem> items = source.getResults("", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items.Count == 1, "GetResults does not return 1 item as expected");

        }


        [TestMethod]
        public void TestGetResultsSprintIDTest1()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].SprintID == 3, "Sprint ID does not match expected value.");


        }


        [TestMethod]
        public void TestGetResultsSprintNameTest1()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].SprintName== "Neptune", "Sprint name does not match expected value.");


        }



        [TestMethod]
        public void TestGetResultsBeginDateTest1()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].BeginDate == DateTime.Parse("1/1/2019"), "Begin Date does not match expected value.");


        }

        [TestMethod]
        public void TestGetResultsEndDateTest1()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].EndDate == DateTime.Parse("3/31/2019"), "Begin Date does not match expected value.");


        }

        [TestMethod]
        public void TestGetResultsPendingTasksTest1()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });


            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].PendingTasks == 0, "Pending tasks does not match expected value.");


        }

        [TestMethod]
        public void TestGetResultsPendingTasksTest2()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Pending" });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Pending" });

            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));
            
            Assert.IsTrue(items[0].PendingTasks == 2, "Pending tasks does not match expected value.");


        }

        [TestMethod]
        public void TestGetResultsPendingStoryPointsTest1()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });


            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].PendingStoryPoints == 0, "Pending story points does not match expected value.");


        }

        [TestMethod]
        public void TestGetResultsPendingStoryPointsTest2()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Pending", StoryPoints = 3 });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Pending", StoryPoints = 2 });

            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].PendingStoryPoints == 5, "Pending story points does not match expected value.");


        }

        [TestMethod]
        public void TestGetResultsCompletedPointsTest1()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Pending", StoryPoints = 3 });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Completed", StoryPoints = 2 });

            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].CompletedStoryPoints == 2, "Completed story points does not match expected value.");


        }
        [TestMethod]
        public void TestGetResultsCompletedPointsTest2()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Completed", StoryPoints = 3 });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Completed", StoryPoints = 2 });

            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].CompletedStoryPoints == 5, "Completed story points does not match expected value.");


        }
        [TestMethod]
        public void TestGetResultsCompletedTasksTest1()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Pending", StoryPoints = 3 });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Pending", StoryPoints = 2 });

            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].CompletedTasks == 0, "Completed tasks does not match expected value.");


        }
        [TestMethod]
        public void TestGetResultsCompletedTasksTest2()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Completed", StoryPoints = 3 });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Completed", StoryPoints = 2 });

            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].CompletedTasks == 2, "Completed tasks does not match expected value.");


        }
        [TestMethod]
        public void TestGetResultsTotalTasksTest1()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            source.context.sprints.Add(new Sprint { SprintID = 2, SprintName = "Pluto", BeginDate = DateTime.Parse("4/1/2019"), EndDate = DateTime.Parse("4/30/2019") });

            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Completed", StoryPoints = 3 });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 3, TaskStatus = "Pending", StoryPoints = 2 });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 2, TaskStatus = "Pending", StoryPoints = 2 });
            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].TotalTasks == 2, "Total tasks does not match expected value.");


        }
        [TestMethod]
        public void TestGetResultsTotalTasksTest2()
        {
            SprintsListTestAccess source = new SprintsListTestAccess();
            source.context.sprints.Add(new Sprint { SprintID = 3, SprintName = "Neptune", BeginDate = DateTime.Parse("1/1/2019"), EndDate = DateTime.Parse("3/31/2019") });
            source.context.sprints.Add(new Sprint { SprintID = 2, SprintName = "Pluto", BeginDate = DateTime.Parse("4/1/2019"), EndDate = DateTime.Parse("4/30/2019") });

            source.context.sprintTasks.Add(new SprintTask { SprintID = 2, TaskStatus = "Completed", StoryPoints = 3 });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 2, TaskStatus = "Pending", StoryPoints = 2 });
            source.context.sprintTasks.Add(new SprintTask { SprintID = 2, TaskStatus = "Pending", StoryPoints = 2 });
            List<SprintsListItem> items = source.getResults("Neptune", DateTime.Parse("3/31/2019"));

            Assert.IsTrue(items[0].TotalTasks == 0, "Total tasks does not match expected value.");


        }



    }
}
