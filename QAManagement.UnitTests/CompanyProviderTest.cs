using QAManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QAManagement.Views;
using QAManagement.Data.Services.DataContracts;
using System.Collections.Generic;

namespace QAManagement.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for CompanyProviderTest and is intended
    ///to contain all CompanyProviderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CompanyProviderTest
    {

        static Company _Company = new Company();
        static baseCompanyView _baseCompanyView = new baseCompanyView();
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
        private static void CompareModelObject(Company expected, Company actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ContactPerson, actual.ContactPerson);
            Assert.AreEqual(expected.ContactPersonNumber, actual.ContactPersonNumber);
            Assert.AreEqual(expected.ContactEmail, actual.ContactEmail);
            Assert.AreEqual(expected.Address1, actual.Address1);
            Assert.AreEqual(expected.Address2, actual.Address2);
            Assert.AreEqual(expected.Address3, actual.Address3);
            Assert.AreEqual(expected.PostalCode, actual.PostalCode);
            Assert.AreEqual(expected.OfficePhoneNumber, actual.OfficePhoneNumber);
            Assert.AreEqual(expected.OfficeEmail, actual.OfficeEmail);
            Assert.AreEqual(expected.Validated, actual.Validated);
        }
        private static void CompareViewObject(baseCompanyView expected, baseCompanyView actual)
        {
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ContactPerson, actual.ContactPerson);
            Assert.AreEqual(expected.ContactPersonNumber, actual.ContactPersonNumber);
            Assert.AreEqual(expected.ContactEmail, actual.ContactEmail);
            Assert.AreEqual(expected.Address1, actual.Address1);
            Assert.AreEqual(expected.Address2, actual.Address2);
            Assert.AreEqual(expected.Address3, actual.Address3);
            Assert.AreEqual(expected.PostalCode, actual.PostalCode);
            Assert.AreEqual(expected.OfficePhoneNumber, actual.OfficePhoneNumber);
            Assert.AreEqual(expected.OfficeEmail, actual.OfficeEmail);
            Assert.AreEqual(expected.Validated, actual.Validated);
        }
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _Company = new Company()
            {
            ID = 1, 
            Name = "1", 
            Description = "1", 
            ContactPerson = "1", 
            ContactPersonNumber = "1", 
            ContactEmail = "1", 
            Address1 = "1", 
            Address2 = "1", 
            Address3 = "1", 
            PostalCode = "1", 
            OfficePhoneNumber = "1", 
            OfficeEmail = "1",
            Validated = new DateTime(2012,1,1)
            };

            _baseCompanyView = new baseCompanyView()
            {
            ID = 1, 
            Name = "1", 
            Description = "1", 
            ContactPerson = "1", 
            ContactPersonNumber = "1", 
            ContactEmail = "1", 
            Address1 = "1", 
            Address2 = "1", 
            Address3 = "1", 
            PostalCode = "1", 
            OfficePhoneNumber = "1", 
            OfficeEmail = "1", 
            Validated = new DateTime(2012,1,1)
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
        ///A test for CompanyProvider Constructor
        ///</summary>
        [TestMethod()]
        public void CompanyProviderConstructorTest()
        {
            CompanyProvider target = new CompanyProvider();

        }

        /// <summary>
        ///A test for ConvertToModel
        ///</summary>
        [TestMethod()]
        public void ConvertToModelTest()
        {
            CompanyProvider target = new CompanyProvider(); // TODO: Initialize to an appropriate value
            baseCompanyView item = _baseCompanyView;
            Company expected =_Company;
            Company actual;
            actual = target.ConvertToModel(item);
            CompareModelObject(expected,actual);

        }

        /// <summary>
        ///A test for ConvertToModelList
        ///</summary>
        [TestMethod()]
        public void ConvertToModelListTest()
        {
            CompanyProvider target = new CompanyProvider(); // TODO: Initialize to an appropriate value
            List<baseCompanyView> itemlist =new List<baseCompanyView>();
            itemlist.Add(_baseCompanyView);
            itemlist.Add(_baseCompanyView);

            List<Company> expected = new List<Company>();
            expected.Add(_Company);
            expected.Add(_Company);
            List<Company> actual;
            actual = target.ConvertToModelList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareModelObject(expected[0],actual[0]);
            CompareModelObject(expected[1],actual[1]);
        }

        /// <summary>
        ///A test for ConvertToView
        ///</summary>
        [TestMethod()]
        public void ConvertToViewTest()
        {
            CompanyProvider target = new CompanyProvider(); // TODO: Initialize to an appropriate value
            Company item = _Company;
            baseCompanyView expected = _baseCompanyView;
            baseCompanyView actual;
            actual = target.ConvertToView(item);
            CompareViewObject(expected,actual);
        }

        /// <summary>
        ///A test for ConvertToViewList
        ///</summary>
        [TestMethod()]
        public void ConvertToViewListTest()
        {
            CompanyProvider target = new CompanyProvider(); // TODO: Initialize to an appropriate value
            List<Company> itemlist = new List<Company>();
            itemlist.Add(_Company);
            itemlist.Add(_Company);
            List<baseCompanyView> expected = new List<baseCompanyView>();
            expected.Add(_baseCompanyView);
            expected.Add(_baseCompanyView);
            List<baseCompanyView> actual;
            actual = target.ConvertToViewList(itemlist);
            Assert.AreEqual(expected.Count, actual.Count);
            CompareViewObject(expected[0],actual[0]);
            CompareViewObject(expected[1],actual[1]);
        }

        /// <summary>
        ///A test for GetCompany
        ///</summary>
        [TestMethod()]
        public void GetCompanyTest()
        {
            //CompanyProvider target = new CompanyProvider(); // TODO: Initialize to an appropriate value
            //int id = 0; // TODO: Initialize to an appropriate value
            //baseCompanyView expected = null; // TODO: Initialize to an appropriate value
            //baseCompanyView actual;
            //actual = target.GetCompany(id);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
