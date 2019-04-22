using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrumProjectTracking.Sprints.SprintDetail;
using ScrumProjectTracking.DataAccess;
namespace ScrumProjectTrackingTest.Sprints.SprintDetail
{
    [TestClass]
    public class SprintDetailUnitTests
    {
        [TestMethod]
        public void addSprintCountTest1()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Parse("2/1/2019");
            newSprint.EndDate = DateTime.Parse("3/31/2019");
            sprintDetailTestAccess.addSprint(newSprint);
            Assert.IsTrue(sprintDetailTestAccess.dc.sprints.Count == 1, "Sprint count does not equal expected value.");

        }

        [TestMethod]
        public void getSprintTest1()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Parse("2/1/2019");
            newSprint.EndDate = DateTime.Parse("3/31/2019");
            sprintDetailTestAccess.dc.sprints.Add(newSprint);


            Assert.IsTrue(sprintDetailTestAccess.getSprint(1).SprintID == 1, "Sprint ID does not equal expected value.");

        }


        [TestMethod]
        public void validateSprintCountTest1 ()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Parse("1/1/2019");
            newSprint.EndDate = DateTime.Parse("3/3/2019");
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors().Count == 0, "Validation error count does not equal expected value");



        }


        [TestMethod]
        public void validateSprintCountTest2()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;

            newSprint.BeginDate = DateTime.Parse("4/1/2019");
            newSprint.EndDate = DateTime.Parse("4/13/2019");
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors().Count == 1, "Validation error count does not equal expected value");



        }

        [TestMethod]
        public void validateSprintFieldNameTest1()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            
            newSprint.BeginDate = DateTime.Parse("4/1/2019");
            newSprint.EndDate = DateTime.Parse("4/5/2019");
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors()[0].FieldName == "Sprint Name", "Validation error field name does not equal expected value");



        }

        [TestMethod]
        public void validateSprintDatesTest1()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(-121);
            newSprint.EndDate = DateTime.Now.AddDays(-60);
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors()[0].ErrorMessage == "The begin date cannot be more than 120 days prior to the current date.", "Validation error error message does not equal expected value");



        }


        [TestMethod]
        public void validateSprintDatesTest2()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(91);
            newSprint.EndDate = DateTime.Now.AddDays(100);
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors()[0].ErrorMessage == "The begin date cannot be greater than 90 days from the current date.", "Validation error error message does not equal expected value");



        }

        [TestMethod]
        public void validateSprintDatesTest3()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(61);
            newSprint.EndDate = DateTime.Now.AddDays(121);
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors()[0].ErrorMessage == "The end date cannot be greater than 120 days from the current date.", "Validation error error message does not equal expected value");



        }

        [TestMethod]
        public void validateSprintDatesTest4()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(-101);
            newSprint.EndDate = DateTime.Now.AddDays(-91);
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors()[0].ErrorMessage == "The end date cannot be more than than 90 days prior to the current date.", "Validation error error message does not equal expected value");



        }


        [TestMethod]
        public void validateSprintDatesTest5()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(-101);
            newSprint.EndDate = DateTime.Now.AddDays(-90);
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors().Count == 0, "Validation error count does not equal expected value.");



        }

        [TestMethod]
        public void validateSprintDatesTest6()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(61);
            newSprint.EndDate = DateTime.Now.AddDays(120);
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors().Count == 0, "Validation error count does not equal expected value.");


        }

        public void validateSprintDatesTest7()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(-120);
            newSprint.EndDate = DateTime.Now.AddDays(-80);
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors().Count == 0, "Validation error count does not equal expected value.");


        }


        [TestMethod]
        public void validateSprintDatesTest8()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(90);
            newSprint.EndDate = DateTime.Now.AddDays(100);
            sprintDetailTestAccess.validateRecord(newSprint);

            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors().Count == 0, "Validation error count does not equal expected value.");


        }
        [TestMethod]
        public void validateSprintDatesTest9()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(-25);
            newSprint.EndDate = DateTime.Now.AddDays(-10);
            sprintDetailTestAccess.dc.sprints.Add(newSprint);
            Sprint newSprint2 = new Sprint();
            newSprint2.SprintID = 1;
            newSprint2.SprintName = "Sprint 1";
            newSprint2.BeginDate = DateTime.Now.AddDays(-25);
            newSprint2.EndDate = DateTime.Now.AddDays(-10);
            sprintDetailTestAccess.validateRecord(newSprint2);
            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors()[0].ErrorMessage == "The begin and end date range overlaps with an existing sprint.", "Validation error error message does not equal expected value");



        }
        [TestMethod]
        public void validateSprintDatesTest10()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(-25);
            newSprint.EndDate = DateTime.Now.AddDays(-10);
            sprintDetailTestAccess.dc.sprints.Add(newSprint);
            Sprint newSprint2 = new Sprint();
            newSprint2.SprintID = 1;
            newSprint2.SprintName = "Sprint 1";
            newSprint2.BeginDate = DateTime.Now.AddDays(-11);
            newSprint2.EndDate = DateTime.Now.AddDays(-5);
            sprintDetailTestAccess.validateRecord(newSprint2);
            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors()[0].ErrorMessage == "The begin and end date range overlaps with an existing sprint.", "Validation error error message does not equal expected value");



        }



        [TestMethod]
        public void validateSprintDatesTest11()
        {
            SprintDetailTestAccess sprintDetailTestAccess = new SprintDetailTestAccess();
            Sprint newSprint = new Sprint();
            newSprint.SprintID = 1;
            newSprint.SprintName = "Sprint 1";
            newSprint.BeginDate = DateTime.Now.AddDays(-25);
            newSprint.EndDate = DateTime.Now.AddDays(-10);
            sprintDetailTestAccess.dc.sprints.Add(newSprint);
            Sprint newSprint2 = new Sprint();
            newSprint2.SprintID = 1;
            newSprint2.SprintName = "Sprint 1";
            newSprint2.BeginDate = DateTime.Now.AddDays(-30);
            newSprint2.EndDate = DateTime.Now.AddDays(-22);
            sprintDetailTestAccess.validateRecord(newSprint2);
            Assert.IsTrue(sprintDetailTestAccess.getValidationErrors()[0].ErrorMessage == "The begin and end date range overlaps with an existing sprint.", "Validation error error message does not equal expected value");
            


        }







    }
}
