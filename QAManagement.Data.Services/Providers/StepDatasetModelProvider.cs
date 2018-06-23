using System.Collections.Generic;
using QAManagement.Data.Services.Providers;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Data.Services.Providers
{
    public class StepProvider : baseDataProvider
    {
        public Step ConvertToModel(QAManagement.Data.dsQAManager.StepRow item)
        {
            Step model = new Step();
            model.ID = item.ID;
            model.RequirementID = item.RequirementID;
            model.Number = item.Number;
            model.Description = item.Description;
            model.Result = item.Result;
            model.IsTest = item.IsTest;
            return model;
        }
        public List<Step> ConvertToModelList(QAManagement.Data.dsQAManager.StepDataTable itemlist)
        {
            List<Step> lst = new List<Step>();
            foreach (QAManagement.Data.dsQAManager.StepRow item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public QAManagement.Data.dsQAManager.StepRow ConvertToDataRow(Step item)
        {
            QAManagement.Data.dsQAManager.StepRow model = new QAManagement.Data.dsQAManager.StepDataTable().NewStepRow();
            model.ID = item.ID;
            model.RequirementID = item.RequirementID;
            model.Number = item.Number;
            model.Description = item.Description;
            model.Result = item.Result;
            model.IsTest = item.IsTest;
            return model;
        }
        public QAManagement.Data.dsQAManager.StepDataTable ConvertToDataTable(List<Step> itemlist)
        {
            QAManagement.Data.dsQAManager.StepDataTable lst = new QAManagement.Data.dsQAManager.StepDataTable();
            foreach (Step item in itemlist)
                lst.AddStepRow(ConvertToDataRow(item));
            return lst;
        }

    }
}
