using System.Collections.Generic;
using QAManagement.Data.Services.Providers;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Data.Services.Providers
{
    public class TestResultProvider : baseDataProvider
    {
        public TestResult ConvertToModel(QAManagement.Data.dsQAManager.TestResultRow item)
        {
            TestResult model = new TestResult();
            model.ID = item.ID;
            model.Results = item.Results;
            model.RequirementID = item.RequirementID;
            model.Pass = item.Pass;
            return model;
        }
        public List<TestResult> ConvertToModelList(QAManagement.Data.dsQAManager.TestResultDataTable itemlist)
        {
            List<TestResult> lst = new List<TestResult>();
            foreach (QAManagement.Data.dsQAManager.TestResultRow item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public QAManagement.Data.dsQAManager.TestResultRow ConvertToDataRow(TestResult item)
        {
            QAManagement.Data.dsQAManager.TestResultRow model = new QAManagement.Data.dsQAManager.TestResultDataTable().NewTestResultRow();
            model.ID = item.ID;
            model.Results = item.Results;
            model.RequirementID = item.RequirementID;
            model.Pass = item.Pass;
            return model;
        }
        public QAManagement.Data.dsQAManager.TestResultDataTable ConvertToDataTable(List<TestResult> itemlist)
        {
            QAManagement.Data.dsQAManager.TestResultDataTable lst = new QAManagement.Data.dsQAManager.TestResultDataTable();
            foreach (TestResult item in itemlist)
                lst.AddTestResultRow(ConvertToDataRow(item));
            return lst;
        }

    }
}
