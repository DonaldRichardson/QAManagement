using System.Collections.Generic;
using QAManagement.Data.Services.Providers;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Data.Services.Providers
{
    public class RequirementProvider : baseDataProvider
    {
        public Requirement ConvertToModel(QAManagement.Data.dsQAManager.RequirementRow item)
        {
            Requirement model = new Requirement();
            model.ID = item.ID;
            model.Description = item.Description;
            model.LongDescription = item.LongDescription;
            model.Number = item.Number;
            model.ProjectID = item.ProjectID;
            model.SpecificationReference = item.SpecificationReference;
            model.PassingDescription = item.PassingDescription;
            model.Weighting = item.Weighting;
            model.OwnedByUserID = item.OwnedByUserID;
            return model;
        }
        public List<Requirement> ConvertToModelList(QAManagement.Data.dsQAManager.RequirementDataTable itemlist)
        {
            List<Requirement> lst = new List<Requirement>();
            foreach (QAManagement.Data.dsQAManager.RequirementRow item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public QAManagement.Data.dsQAManager.RequirementRow ConvertToDataRow(Requirement item)
        {
            QAManagement.Data.dsQAManager.RequirementRow model = new QAManagement.Data.dsQAManager.RequirementDataTable().NewRequirementRow();
            model.ID = item.ID;
            model.Description = item.Description;
            model.LongDescription = item.LongDescription;
            model.Number = item.Number;
            model.ProjectID = item.ProjectID;
            model.SpecificationReference = item.SpecificationReference;
            model.PassingDescription = item.PassingDescription;
            model.Weighting = item.Weighting;
            model.OwnedByUserID = item.OwnedByUserID;
            return model;
        }
        public QAManagement.Data.dsQAManager.RequirementDataTable ConvertToDataTable(List<Requirement> itemlist)
        {
            QAManagement.Data.dsQAManager.RequirementDataTable lst = new QAManagement.Data.dsQAManager.RequirementDataTable();
            foreach (Requirement item in itemlist)
                lst.AddRequirementRow(ConvertToDataRow(item));
            return lst;
        }

    }
}
