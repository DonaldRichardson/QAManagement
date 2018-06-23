using System.Collections.Generic;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Views
{
    public class ProjectUsersProvider : baseProvider, IProjectUserProvider
{
public ProjectUsers ConvertToModel(baseProjectUsersView item)
{
ProjectUsers model = new ProjectUsers();
model.ID = item.ID;
model.UserID = item.UserID;
model.ProjectID = item.ProjectID;
return model;
}
public List<ProjectUsers> ConvertToModelList(List<baseProjectUsersView> itemlist)
{
 List<ProjectUsers> lst = new List<ProjectUsers>();
foreach (baseProjectUsersView item in itemlist)
   lst.Add(ConvertToModel(item));
return lst;
}
public baseProjectUsersView ConvertToView(ProjectUsers item)
{
baseProjectUsersView view = new baseProjectUsersView();
view.ID = item.ID;
view.UserID = item.UserID;
view.ProjectID = item.ProjectID;
return view;
}
public List<baseProjectUsersView> ConvertToViewList(List<ProjectUsers> itemlist)
{
 List<baseProjectUsersView> lst = new List<baseProjectUsersView>();
foreach (ProjectUsers item in itemlist)
   lst.Add(ConvertToView(item));
return lst;
}

}
}
