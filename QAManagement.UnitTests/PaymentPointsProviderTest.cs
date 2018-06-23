using QAManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QAManagement.Views;
using QAManagement.Data.Services.DataContracts;
using System.Collections.Generic;

namespace QAManagement.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for PaymentPointsProviderTest and is intended
    ///to contain all PaymentPointsProviderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PaymentPointsProviderTest
    {

        static basePaymentPointsView _basePaymentPointsView = new basePaymentPointsView();
        static PaymentPoints _PaymentPoints = new PaymentPoints();
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
        private static void CompareModelObject(PaymentPoints expected, PaymentPoints actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.UserID, actual.UserID);
            Assert.AreEqual(expected.Points, actual.Points);
        }
        private static void CompareViewObject(basePaymentPointsView expected, basePaymentPointsView actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.UserID, actual.UserID);
            Assert.AreEqual(expected.Points, actual.Points);
        }
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _PaymentPoints = new PaymentPoints()
            {
            ID = 1, 
            UserID = 1, 
            Points = 1, 
            };

            _basePaymentPointsView = new basePaymentPointsView()
            {
                ID = 1,
                UserID = 1,
                Points = 1,
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
        ///A test for PaymentPointsProvider Constructor
        ///</summary>
        [TestMethod()]
        public void PaymentPointsProviderConstructorTest()
        {
            PaymentPointsProvider target = new PaymentPointsProvider();

        }

        /// <summary>
        ///A test for ConvertToModel
        ///</summary>
        [TestMethod()]
        public void ConvertToModelTest()
        {
            PaymentPointsProvider target = new PaymentPointsProvider(); // TODO: Initialize to an appropriate value
            basePaymentPointsView item = _basePaymentPointsView;
            PaymentPoints expected = _PaymentPoints;
            PaymentPoints actual;
            actual = target.ConvertToModel(item);
            CompareModelObject(expected, actual);
        }

        /// <summary>
        ///A test for ConvertToModelList
        ///</summary>
        [TestMethod()]
        public void ConvertToModelListTest()
        {
            PaymentPointsProvider target = new PaymentPointsProvider(); // TODO: Initialize to an appropriate value
            List<basePaymentPointsView> itemlist = new List<basePaymentPointsView>();
            itemlist.Add(_basePaymentPointsView);
            itemlist.Add(_basePaymentPointsView);
            List<PaymentPoints> expected = new List<PaymentPoints>();
            expected.Add(_PaymentPoints);
            expected.Add(_PaymentPoints);
            List<PaymentPoints> actual;
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
            PaymentPointsProvider target = new PaymentPointsProvider(); // TODO: Initialize to an appropriate value
            PaymentPoints item = _PaymentPoints;
            basePaymentPointsView expected = _basePaymentPointsView;
            basePaymentPointsView actual;
            actual = target.ConvertToView(item);
            CompareViewObject(expected, actual);

        }

        /// <summary>
        ///A test for ConvertToViewList
        ///</summary>
        [TestMethod()]
        public void ConvertToViewListTest()
        {
            PaymentPointsProvider target = new PaymentPointsProvider(); // TODO: Initialize to an appropriate value
            List<PaymentPoints> itemlist = new List<PaymentPoints>();
            itemlist.Add(_PaymentPoints);
            itemlist.Add(_PaymentPoints);
            List<basePaymentPointsView> expected = new List<basePaymentPointsView>();
            expected.Add(_basePaymentPointsView);
            expected.Add(_basePaymentPointsView);
            List<basePaymentPointsView> actual;
            actual = target.ConvertToViewList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareViewObject(expected[0], actual[0]);
            CompareViewObject(expected[1], actual[1]);
        }
    }
}
