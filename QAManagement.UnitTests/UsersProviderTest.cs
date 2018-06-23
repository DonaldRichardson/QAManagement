using QAManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QAManagement.Views;
using QAManagement.Data.Services.DataContracts;
using System.Collections.Generic;

namespace QAManagement.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for UsersProviderTest and is intended
    ///to contain all UsersProviderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UsersProviderTest
    {
        static baseUsersView _baseUsersView;
        static Users _Users;

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

        private static void CompareModelObject(Users expected, Users actual)
        {
            Assert.AreEqual(expected.AccountNo, actual.AccountNo);
            Assert.AreEqual(expected.Active, actual.Active);
            Assert.AreEqual(expected.Address1, actual.Address1);
            Assert.AreEqual(expected.Address2, actual.Address2);
            Assert.AreEqual(expected.Address3, actual.Address3);
            Assert.AreEqual(expected.Bank, actual.Bank);
            Assert.AreEqual(expected.BranchCode, actual.BranchCode);
            Assert.AreEqual(expected.CellNumber, actual.CellNumber);
            Assert.AreEqual(expected.CompanyID, actual.CompanyID);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Password, actual.Password);
            Assert.AreEqual(expected.PaypointThreshold, actual.PaypointThreshold);
            Assert.AreEqual(expected.PhoneNumber, actual.PhoneNumber);
            Assert.AreEqual(expected.PostalCode, actual.PostalCode);
            Assert.AreEqual(expected.Username, actual.Username);
        }

        private static void CompareViewObject(baseUsersView expected, baseUsersView actual)
        {
            Assert.AreEqual(expected.AccountNo, actual.AccountNo);
            Assert.AreEqual(expected.Active, actual.Active);
            Assert.AreEqual(expected.Address1, actual.Address1);
            Assert.AreEqual(expected.Address2, actual.Address2);
            Assert.AreEqual(expected.Address3, actual.Address3);
            Assert.AreEqual(expected.Bank, actual.Bank);
            Assert.AreEqual(expected.BranchCode, actual.BranchCode);
            Assert.AreEqual(expected.CellNumber, actual.CellNumber);
            Assert.AreEqual(expected.CompanyID, actual.CompanyID);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Password, actual.Password);
            Assert.AreEqual(expected.PaypointThreshold, actual.PaypointThreshold);
            Assert.AreEqual(expected.PhoneNumber, actual.PhoneNumber);
            Assert.AreEqual(expected.PostalCode, actual.PostalCode);
            Assert.AreEqual(expected.Username, actual.Username);
        }
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _baseUsersView = new baseUsersView()
            {
                AccountNo = "1",
                Active = true,
                Address1 = "add 1",
                Address2 = "add 2",
                Address3 = "add 3",
                Bank = "bank",
                BranchCode = "1",
                CellNumber = "1",
                CompanyID = 1,
                Email = "A@A",
                ID = 1,
                Password = "password",
                PaypointThreshold = 1,
                PhoneNumber = "1",
                PostalCode = "1",
                Username = "username"
            };
            _Users = new Users()
            {
                AccountNo = "1",
                Active = true,
                Address1 = "add 1",
                Address2 = "add 2",
                Address3 = "add 3",
                Bank = "bank",
                BranchCode = "1",
                CellNumber = "1",
                CompanyID = 1,
                Email = "A@A",
                ID = 1,
                Password = "password",
                PaypointThreshold = 1,
                PhoneNumber = "1",
                PostalCode = "1",
                Username = "username"
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
        ///A test for ConvertToModel
        ///</summary>
        [TestMethod()]
        public void ConvertToModelTest()
        {
            UsersProvider target = new UsersProvider(); // TODO: Initialize to an appropriate value
            baseUsersView item = _baseUsersView;
            Users expected = _Users;
            Users actual;
            actual = target.ConvertToModel(item);
            CompareModelObject(expected, actual);

        }

        

        /// <summary>
        ///A test for ConvertToModelList
        ///</summary>
        [TestMethod()]
        public void ConvertToModelListTest()
        {
            UsersProvider target = new UsersProvider(); // TODO: Initialize to an appropriate value
            List<baseUsersView> itemlist  = new List<baseUsersView>();
            itemlist.Add(_baseUsersView);
            itemlist.Add(_baseUsersView);
            
            List<Users> expected = new List<Users>();
            expected.Add(_Users);
            expected.Add(_Users);
            List<Users> actual;
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
            UsersProvider target = new UsersProvider(); // TODO: Initialize to an appropriate value
            Users item = _Users;
            baseUsersView expected = _baseUsersView;
            baseUsersView actual;
            actual = target.ConvertToView(item);
            CompareViewObject(expected, actual);
        }

        /// <summary>
        ///A test for ConvertToViewList
        ///</summary>
        [TestMethod()]
        public void ConvertToViewListTest()
        {
            UsersProvider target = new UsersProvider(); // TODO: Initialize to an appropriate value
            List<Users> itemlist =new List<Users> ();
            itemlist.Add(_Users);
            itemlist.Add(_Users);
            List<baseUsersView> expected = new List<baseUsersView>();
            expected.Add(_baseUsersView);
            expected.Add(_baseUsersView);
            List<baseUsersView> actual;
            actual = target.ConvertToViewList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareViewObject(expected[0], actual[0]);
            CompareViewObject(expected[1], actual[1]);

        }
    }
}
