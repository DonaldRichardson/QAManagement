using QAManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QAManagement.Views;
using QAManagement.Data.Services.DataContracts;
using System.Collections.Generic;

namespace QAManagement.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for ProjectUsersProviderTest and is intended
    ///to contain all ProjectUsersProviderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProjectUsersProviderTest
    {

        static ProjectUsers _ProjectUsers = new ProjectUsers();
        static baseProjectUsersView _baseProjectUsersView = new baseProjectUsersView();
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
        private static void CompareModelObject(ProjectUsers expected, ProjectUsers actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.UserID, actual.UserID);
            Assert.AreEqual(expected.ProjectID, actual.ProjectID);
        }
        private static void CompareViewObject(baseProjectUsersView expected, baseProjectUsersView actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.UserID, actual.UserID);
            Assert.AreEqual(expected.ProjectID, actual.ProjectID);
        }

        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _ProjectUsers = new ProjectUsers()
            {
                ID = 1, 
                UserID = 1, 
                ProjectID = 1, 
            };

            _baseProjectUsersView = new baseProjectUsersView()
            {
                ID = 1,
                UserID = 1,
                ProjectID = 1,
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
        ///A test for ProjectUsersProvider Constructor
        ///</summary>
        [TestMethod()]
        public void ProjectUsersProviderConstructorTest()
        {
            ProjectUsersProvider target = new ProjectUsersProvider();
        }

        [TestMethod()]
        public void ConvertToModelListTest()
        {
            ProjectUsersProvider target = new ProjectUsersProvider();
            List<baseProjectUsersView> itemlist = new List<baseProjectUsersView>();
            itemlist.Add(_baseProjectUsersView);
            itemlist.Add(_baseProjectUsersView);
            List<ProjectUsers> expected = new List<ProjectUsers>();
            expected.Add(_ProjectUsers);
            expected.Add(_ProjectUsers);
            List<ProjectUsers> actual;
            actual = target.ConvertToModelList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareModelObject(expected[0], actual[0]);
            CompareModelObject(expected[1], actual[1]);
        }


        [TestMethod()]
        public void ConvertToViewListTest()
        {
            ProjectUsersProvider target = new ProjectUsersProvider();
            List<ProjectUsers> itemlist = new List<ProjectUsers>();
            itemlist.Add(_ProjectUsers);
            itemlist.Add(_ProjectUsers);
            List<baseProjectUsersView> expected = new List<baseProjectUsersView>();
            expected.Add(_baseProjectUsersView);
            expected.Add(_baseProjectUsersView);
            List<baseProjectUsersView> actual;
            actual = target.ConvertToViewList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareViewObject(expected[0], actual[0]);
            CompareViewObject(expected[1], actual[1]);
        }


        [TestMethod()]
        public void ConvertToViewTest()
        {
            ProjectUsersProvider target = new ProjectUsersProvider();
            ProjectUsers item = _ProjectUsers;
            baseProjectUsersView expected = _baseProjectUsersView;
            baseProjectUsersView actual;
            actual = target.ConvertToView(item);
            CompareViewObject(expected, actual);
        }


        [TestMethod()]
        public void ConvertToModelTest()
        {
            ProjectUsersProvider target = new ProjectUsersProvider();
            baseProjectUsersView item = _baseProjectUsersView;
            ProjectUsers expected = _ProjectUsers;
            ProjectUsers actual;
            actual = target.ConvertToModel(item);
            CompareModelObject(expected, actual);
        }



    }
}
