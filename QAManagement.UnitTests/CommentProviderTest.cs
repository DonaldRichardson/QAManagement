using QAManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QAManagement.Views;
using QAManagement.Data.Services.DataContracts;
using System.Collections.Generic;

namespace QAManagement.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for CommentProviderTest and is intended
    ///to contain all CommentProviderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CommentProviderTest
    {

        static baseCommentView _baseCommentView;
        static Comment _Comment;
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
        private static void CompareModelObject(Comment expected, Comment actual)
        {
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.RequirementID, actual.RequirementID);
        }
        private static void CompareViewObject(baseCommentView expected, baseCommentView actual)
        {
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.RequirementID, actual.RequirementID);
        }
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _baseCommentView = new baseCommentView() { Description = "Description", ID = 1, RequirementID = 1 }; // TODO: Initialize to an appropriate value
            _Comment = new Comment() { Description = "Description", ID = 1, RequirementID = 1 };
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
        ///A test for CommentProvider Constructor
        ///</summary>
        [TestMethod()]
        public void CommentProviderConstructorTest()
        {
            CommentProvider target = new CommentProvider();
        }

        /// <summary>
        ///A test for ConvertToModel
        ///</summary>
        [TestMethod()]
        public void ConvertToModelTest()
        {
            CommentProvider target = new CommentProvider(); // TODO: Initialize to an appropriate value
            baseCommentView item = _baseCommentView;
            Comment expected = _Comment;
            Comment actual;
            actual = target.ConvertToModel(item);
            CompareModelObject(expected, actual);


        }

        /// <summary>
        ///A test for ConvertToModelList
        ///</summary>
        [TestMethod()]
        public void ConvertToModelListTest()
        {
            CommentProvider target = new CommentProvider(); // TODO: Initialize to an appropriate value
            List<baseCommentView> itemlist = new List<baseCommentView>();
            itemlist.Add(_baseCommentView);
            itemlist.Add(_baseCommentView);
            List<Comment> expected = new List<Comment>();
            expected.Add(_Comment);
            expected.Add(_Comment);
            List<Comment> actual;
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
            CommentProvider target = new CommentProvider(); // TODO: Initialize to an appropriate value
            baseCommentView expected = new baseCommentView() { Description = "Description", ID = 1, RequirementID = 1 }; // TODO: Initialize to an appropriate value
            Comment item = new Comment() { Description = "Description", ID = 1, RequirementID = 1 };
            baseCommentView actual;
            actual = target.ConvertToView(item);
            CompareViewObject(expected, actual);

        }

        /// <summary>
        ///A test for ConvertToViewList
        ///</summary>
        [TestMethod()]
        public void ConvertToViewListTest()
        {
            CommentProvider target = new CommentProvider(); // TODO: Initialize to an appropriate value
            List<Comment> itemlist = new List<Comment>();
            itemlist.Add(_Comment);
            itemlist.Add(_Comment);
            List<baseCommentView> expected = new List<baseCommentView>();
            expected.Add(_baseCommentView);
            expected.Add(_baseCommentView);
            List<baseCommentView> actual;
            actual = target.ConvertToViewList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareViewObject(expected[0],actual[0]);
            CompareViewObject(expected[1],actual[1]);
        }

        /// <summary>
        ///A test for GetComment
        ///</summary>
        [TestMethod()]
        public void GetCommentTest()
        {
            CommentProvider target = new CommentProvider(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            baseCommentView expected = null; // TODO: Initialize to an appropriate value
            baseCommentView actual;
            actual = target.GetComment(id);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.RequirementID, actual.RequirementID);
        }

       
    }
}
