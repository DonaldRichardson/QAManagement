using QAManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QAManagement.Views;
using QAManagement.Data.Services.DataContracts;
using System.Collections.Generic;

namespace QAManagement.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for StepProviderTest and is intended
    ///to contain all StepProviderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StepProviderTest
    {

         static Step _Step = new Step();
        static baseStepView _baseStepView = new baseStepView();

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        private static void CompareModelObject(Step expected, Step actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.RequirementID, actual.RequirementID);
            Assert.AreEqual(expected.Number, actual.Number);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.Result, actual.Result);
            Assert.AreEqual(expected.IsTest, actual.IsTest);
        }
        private static void CompareViewObject(baseStepView expected, baseStepView actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.RequirementID, actual.RequirementID);
            Assert.AreEqual(expected.Number, actual.Number);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.Result, actual.Result);
            Assert.AreEqual(expected.IsTest, actual.IsTest);
        }
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _Step = new Step()
            {
                ID =1, 
                RequirementID =1, 
                Number =1, 
                Description ="1", 
                Result ="1", 
                IsTest =true, 
            };

            _baseStepView = new baseStepView()
            {
                ID = 1, 
                RequirementID = 1, 
                Number = 1, 
                Description = "1", 
                Result = "1", 
                IsTest = true, 
            };

        }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for StepProvider Constructor
        ///</summary>
        [TestMethod()]
        public void StepProviderConstructorTest()
        {
            StepProvider target = new StepProvider();

        }

        [TestMethod()]
        public void ConvertToModelListTest()
        {
            StepProvider target = new StepProvider();
            List<baseStepView> itemlist = new List<baseStepView>();
            itemlist.Add(_baseStepView);
            itemlist.Add(_baseStepView);
            List<Step> expected = new List<Step>();
            expected.Add(_Step);
            expected.Add(_Step);
            List<Step> actual;
            actual = target.ConvertToModelList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareModelObject(expected[0], actual[0]);
            CompareModelObject(expected[1], actual[1]);
        }


        [TestMethod()]
        public void ConvertToViewListTest()
        {
            StepProvider target = new StepProvider();
            List<Step> itemlist = new List<Step>();
            itemlist.Add(_Step);
            itemlist.Add(_Step);
            List<baseStepView> expected = new List<baseStepView>();
            expected.Add(_baseStepView);
            expected.Add(_baseStepView);
            List<baseStepView> actual;
            actual = target.ConvertToViewList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareViewObject(expected[0], actual[0]);
            CompareViewObject(expected[1], actual[1]);
        }


        [TestMethod()]
        public void ConvertToViewTest()
        {
            StepProvider target = new StepProvider();
            Step item = _Step;
            baseStepView expected = _baseStepView;
            baseStepView actual;
            actual = target.ConvertToView(item);
            CompareViewObject(expected, actual);
        }


        [TestMethod()]
        public void ConvertToModelTest()
        {
            StepProvider target = new StepProvider();
            baseStepView item = _baseStepView;
            Step expected = _Step;
            Step actual;
            actual = target.ConvertToModel(item);
            CompareModelObject(expected, actual);
        }



    }
}
