using QAManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QAManagement.Views;
using QAManagement.Data.Services.DataContracts;
using System.Collections.Generic;

namespace QAManagement.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for TestResultProviderTest and is intended
    ///to contain all TestResultProviderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TestResultProviderTest
    {

        static baseTestResultView _baseTestResultView;
        static TestResult _TestResult;
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

        private static void CompareViewObject(baseTestResultView expected, baseTestResultView actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Pass, actual.Pass);
            Assert.AreEqual(expected.Results, actual.Results);
            Assert.AreEqual(expected.RequirementID, actual.RequirementID);
        }
        private static void CompareModelObject(TestResult expected, TestResult actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Pass, actual.Pass);
            Assert.AreEqual(expected.Results, actual.Results);
            Assert.AreEqual(expected.RequirementID, actual.RequirementID);
        }
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _baseTestResultView = new baseTestResultView()
            {
                ID = 1,
                Pass = true,
                RequirementID = 1,
                Results = "result"
            };

            _TestResult =  new TestResult()
            {
                ID = 1,
                Pass = true,
                RequirementID = 1,
                Results = "result"
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
        ///A test for TestResultProvider Constructor
        ///</summary>
        [TestMethod()]
        public void TestResultProviderConstructorTest()
        {
            TestResultProvider target = new TestResultProvider();
        }

        /// <summary>
        ///A test for ConvertToModel
        ///</summary>
        [TestMethod()]
        public void ConvertToModelTest()
        {
            TestResultProvider target = new TestResultProvider(); // TODO: Initialize to an appropriate value
            baseTestResultView item = _baseTestResultView;
            TestResult expected = _TestResult;
            TestResult actual;
            actual = target.ConvertToModel(item);
            CompareModelObject(expected, actual);
        }

        /// <summary>
        ///A test for ConvertToModelList
        ///</summary>
        [TestMethod()]
        public void ConvertToModelListTest()
        {
            TestResultProvider target = new TestResultProvider(); // TODO: Initialize to an appropriate value
            List<baseTestResultView> itemlist = new List<baseTestResultView>();
            itemlist.Add(_baseTestResultView);
            itemlist.Add(_baseTestResultView);
            List<TestResult> expected = new List<TestResult>();
            expected.Add(_TestResult);
            expected.Add(_TestResult);
            List<TestResult> actual;
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
            TestResultProvider target = new TestResultProvider(); // TODO: Initialize to an appropriate value
            TestResult item = _TestResult;
            baseTestResultView expected = _baseTestResultView;
            baseTestResultView actual;
            actual = target.ConvertToView(item);
            CompareViewObject(expected, actual);
        }

        /// <summary>
        ///A test for ConvertToViewList
        ///</summary>
        [TestMethod()]
        public void ConvertToViewListTest()
        {
            TestResultProvider target = new TestResultProvider(); // TODO: Initialize to an appropriate value
            List<TestResult> itemlist = new List<TestResult>();
            itemlist.Add(_TestResult);
            itemlist.Add(_TestResult);
            List<baseTestResultView> expected = new List<baseTestResultView>();
            expected.Add(_baseTestResultView);
            expected.Add(_baseTestResultView);
            List<baseTestResultView> actual;
            actual = target.ConvertToViewList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareViewObject(expected[0], actual[0]);
            CompareViewObject(expected[1], actual[1]);
        }
    }
}
