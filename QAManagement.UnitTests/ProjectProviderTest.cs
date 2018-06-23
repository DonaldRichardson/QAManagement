using QAManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QAManagement.Views;
using QAManagement.Data.Services.DataContracts;
using System.Collections.Generic;

namespace QAManagement.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for ProjectProviderTest and is intended
    ///to contain all ProjectProviderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProjectProviderTest
    {
        static Project _Project = new Project();
        static baseProjectView _baseProjectView = new baseProjectView();
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
        private static void CompareModelObject(Project expected, Project actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CompanyID, actual.CompanyID);
            Assert.AreEqual(expected.TestingDepth, actual.TestingDepth);
        }
        private static void CompareViewObject(baseProjectView expected, baseProjectView actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CompanyID, actual.CompanyID);
            Assert.AreEqual(expected.TestingDepth, actual.TestingDepth);
        }
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _Project = new Project()
            {
                ID = 1, 
                Name = "1", 
                Description = "1", 
                CompanyID = 1, 
                TestingDepth = 1
            };

            _baseProjectView = new baseProjectView()
            {
                ID = 1, 
                Name = "1", 
                Description = "1", 
                CompanyID = 1, 
                TestingDepth = 1 
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
        ///A test for ProjectProvider Constructor
        ///</summary>
        [TestMethod()]
        public void ProjectProviderConstructorTest()
        {
            ProjectProvider target = new ProjectProvider();
        }

        [TestMethod()]
        public void ConvertToModelListTest()
        {
            ProjectProvider target = new ProjectProvider();
            List<baseProjectView> itemlist = new List<baseProjectView>();
            itemlist.Add(_baseProjectView);
            itemlist.Add(_baseProjectView);
            List<Project> expected = new List<Project>();
            expected.Add(_Project);
            expected.Add(_Project);
            List<Project> actual;
            actual = target.ConvertToModelList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareModelObject(expected[0], actual[0]);
            CompareModelObject(expected[1], actual[1]);
        }


        [TestMethod()]
        public void ConvertToViewListTest()
        {
            ProjectProvider target = new ProjectProvider();
            List<Project> itemlist = new List<Project>();
            itemlist.Add(_Project);
            itemlist.Add(_Project);
            List<baseProjectView> expected = new List<baseProjectView>();
            expected.Add(_baseProjectView);
            expected.Add(_baseProjectView);
            List<baseProjectView> actual;
            actual = target.ConvertToViewList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareViewObject(expected[0], actual[0]);
            CompareViewObject(expected[1], actual[1]);
        }


        [TestMethod()]
        public void ConvertToViewTest()
        {
            ProjectProvider target = new ProjectProvider();
            Project item = _Project;
            baseProjectView expected = _baseProjectView;
            baseProjectView actual;
            actual = target.ConvertToView(item);
            CompareViewObject(expected, actual);
        }


        [TestMethod()]
        public void ConvertToModelTest()
        {
            ProjectProvider target = new ProjectProvider();
            baseProjectView item = _baseProjectView;
            Project expected = _Project;
            Project actual;
            actual = target.ConvertToModel(item);
            CompareModelObject(expected, actual);
        }



    }
}
