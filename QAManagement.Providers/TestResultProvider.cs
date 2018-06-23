using System.Collections.Generic;
using QAManagement.Data.Services.DataContracts;
using QAManagement.Views;
using System.ComponentModel;

namespace QAManagement
{
    [DataObject(true)]
    public class TestResultProvider : baseProvider
    {
        public TestResult ConvertToModel(baseTestResultView item)
        {
            TestResult model = new TestResult();
            model.ID = item.ID;
            model.Results = item.Results;
            model.RequirementID = item.RequirementID;
            model.Pass = item.Pass;
            return model;
        }
        public List<TestResult> ConvertToModelList(List<baseTestResultView> itemlist)
        {
            List<TestResult> lst = new List<TestResult>();
            foreach (baseTestResultView item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public baseTestResultView ConvertToView(TestResult item)
        {
            baseTestResultView view = new baseTestResultView();
            view.ID = item.ID;
            view.Results = item.Results;
            view.RequirementID = item.RequirementID;
            view.Pass = item.Pass;
            return view;
        }
        public List<baseTestResultView> ConvertToViewList(List<TestResult> itemlist)
        {
            List<baseTestResultView> lst = new List<baseTestResultView>();
            foreach (TestResult item in itemlist)
                lst.Add(ConvertToView(item));
            return lst;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public baseTestResultView GetPaymentPoint(int id)
        {
            QAManagement.Data.Services.TestResultService svc = new Data.Services.TestResultService();
            Data.Services.DataContracts.TestResult item = svc.GetTestResultContract(id);

            return this.ConvertToView(item);
        }
    }
}
