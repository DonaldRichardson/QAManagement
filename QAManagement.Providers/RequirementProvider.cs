using System.Collections.Generic;
using QAManagement.Data.Services.DataContracts;
using QAManagement.Views;
using System.ComponentModel;

namespace QAManagement
{
    [DataObject(true)]
    public class RequirementProvider : baseProvider
    {
        public Requirement ConvertToModel(baseRequirementView item)
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
        public List<Requirement> ConvertToModelList(List<baseRequirementView> itemlist)
        {
            List<Requirement> lst = new List<Requirement>();
            foreach (baseRequirementView item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public baseRequirementView ConvertToView(Requirement item)
        {
            baseRequirementView view = new baseRequirementView();
            view.ID = item.ID;
            view.Description = item.Description;
            view.LongDescription = item.LongDescription;
            view.Number = item.Number;
            view.ProjectID = item.ProjectID;
            view.SpecificationReference = item.SpecificationReference;
            view.PassingDescription = item.PassingDescription;
            view.Weighting = item.Weighting;
            view.OwnedByUserID = item.OwnedByUserID;
            return view;
        }
        public List<baseRequirementView> ConvertToViewList(List<Requirement> itemlist)
        {
            List<baseRequirementView> lst = new List<baseRequirementView>();
            foreach (Requirement item in itemlist)
                lst.Add(ConvertToView(item));
            return lst;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public baseRequirementView GetPaymentPoint(int id)
        {
            QAManagement.Data.Services.RequirementService svc = new Data.Services.RequirementService();
            Data.Services.DataContracts.Requirement item = svc.GetRequirementContract(id);

            return this.ConvertToView(item);
        }
    }
}
