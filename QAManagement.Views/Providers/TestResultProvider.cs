using System.Collections.Generic;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Views
{
    public class TestResultProvider : baseProvider, ITestResultProvider
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

}
}
