using QAManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QAManagement.Views;
using QAManagement.Data.Services.DataContracts;
using System.Collections.Generic;

namespace QAManagement.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for RequirementProviderTest and is intended
    ///to contain all RequirementProviderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RequirementProviderTest
    {

        static Requirement _Requirement = new Requirement();
        static baseRequirementView _baseRequirementView = new baseRequirementView();
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
        private static void CompareModelObject(Requirement expected, Requirement actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.LongDescription, actual.LongDescription);
            Assert.AreEqual(expected.Number, actual.Number);
            Assert.AreEqual(expected.ProjectID, actual.ProjectID);
            Assert.AreEqual(expected.SpecificationReference, actual.SpecificationReference);
            Assert.AreEqual(expected.PassingDescription, actual.PassingDescription);
            Assert.AreEqual(expected.Weighting, actual.Weighting);
            Assert.AreEqual(expected.OwnedByUserID, actual.OwnedByUserID);
        }
        private static void CompareViewObject(baseRequirementView expected, baseRequirementView actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.LongDescription, actual.LongDescription);
            Assert.AreEqual(expected.Number, actual.Number);
            Assert.AreEqual(expected.ProjectID, actual.ProjectID);
            Assert.AreEqual(expected.SpecificationReference, actual.SpecificationReference);
            Assert.AreEqual(expected.PassingDescription, actual.PassingDescription);
            Assert.AreEqual(expected.Weighting, actual.Weighting);
            Assert.AreEqual(expected.OwnedByUserID, actual.OwnedByUserID);
        }
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _Requirement = new Requirement()
            {
                ID =1, 
                Description ="1", 
                LongDescription ="1", 
                Number ="1", 
                ProjectID =1, 
                SpecificationReference ="1", 
                PassingDescription ="1", 
                Weighting =1, 
                OwnedByUserID =1 
            };

            _baseRequirementView = new baseRequirementView()
            {
                ID = 1,
                Description = "1",
                LongDescription = "1",
                Number = "1",
                ProjectID = 1,
                SpecificationReference = "1",
                PassingDescription = "1",
                Weighting = 1,
                OwnedByUserID = 1
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
        ///A test for RequirementProvider Constructor
        ///</summary>
        [TestMethod()]
        public void RequirementProviderConstructorTest()
        {
            RequirementProvider target = new RequirementProvider();
        }

        /// <summary>
        ///A test for ConvertToModel
        ///</summary>
        [TestMethod()]
        public void ConvertToModelTest()
        {
            RequirementProvider target = new RequirementProvider();
            baseRequirementView item = _baseRequirementView;
            Requirement expected = _Requirement;
            Requirement actual;
            actual = target.ConvertToModel(item);
            CompareModelObject(expected, actual);
        }



        /// <summary>
        ///A test for ConvertToModelList
        ///</summary>
        [TestMethod()]
        public void ConvertToModelListTest()
        {
            RequirementProvider target = new RequirementProvider();
            List<baseRequirementView> itemlist = new List<baseRequirementView>();
            itemlist.Add(_baseRequirementView);
            itemlist.Add(_baseRequirementView);
            List<Requirement> expected = new List<Requirement>();
            expected.Add(_Requirement);
            expected.Add(_Requirement);
            List<Requirement> actual;
            actual = target.ConvertToModelList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareModelObject(expected[0], actual[0]);
            CompareModelObject(expected[1], actual[1]);
        }

        /// <summary>
        ///A test for ConvertToView
        ///</summary>
        [TestMethod()]
        public void ConvertToViewTest()
        {
            RequirementProvider target = new RequirementProvider();
            Requirement item = _Requirement;
            baseRequirementView expected = _baseRequirementView;
            baseRequirementView actual;
            actual = target.ConvertToView(item);
            CompareViewObject(expected, actual);
        }

        /// <summary>
        ///A test for ConvertToViewList
        ///</summary>
        [TestMethod()]
        public void ConvertToViewListTest()
        {
            RequirementProvider target = new RequirementProvider();
            List<Requirement> itemlist = new List<Requirement>();
            itemlist.Add(_Requirement);
            itemlist.Add(_Requirement);
            List<baseRequirementView> expected = new List<baseRequirementView>();
            expected.Add(_baseRequirementView);
            expected.Add(_baseRequirementView);
            List<baseRequirementView> actual;
            actual = target.ConvertToViewList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareViewObject(expected[0], actual[0]);
            CompareViewObject(expected[1], actual[1]);
        }
    }
}
