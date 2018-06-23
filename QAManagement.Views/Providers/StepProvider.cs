using System.Collections.Generic;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Views
{
    public class StepProvider : baseProvider, IStepProvider
{
public Step ConvertToModel(baseStepView item)
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
public List<Step> ConvertToModelList(List<baseStepView> itemlist)
{
 List<Step> lst = new List<Step>();
foreach (baseStepView item in itemlist)
   lst.Add(ConvertToModel(item));
return lst;
}
public baseStepView ConvertToView(Step item)
{
baseStepView view = new baseStepView();
view.ID = item.ID;
view.RequirementID = item.RequirementID;
view.Number = item.Number;
view.Description = item.Description;
view.Result = item.Result;
view.IsTest = item.IsTest;
return view;
}
public List<baseStepView> ConvertToViewList(List<Step> itemlist)
{
 List<baseStepView> lst = new List<baseStepView>();
foreach (Step item in itemlist)
   lst.Add(ConvertToView(item));
return lst;
}

}
}
