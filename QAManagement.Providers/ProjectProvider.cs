using System.Collections.Generic;
using QAManagement.Data.Services.DataContracts;
using QAManagement.Views;
using System.ComponentModel;
namespace QAManagement
{
    [DataObject(true)]
    public class ProjectProvider : baseProvider
    {
        public Project ConvertToModel(baseProjectView item)
        {
            Project model = new Project();
            model.ID = item.ID;
            model.Name = item.Name;
            model.Description = item.Description;
            model.CompanyID = item.CompanyID;
            model.TestingDepth = item.TestingDepth;
            return model;
        }
        public List<Project> ConvertToModelList(List<baseProjectView> itemlist)
        {
            List<Project> lst = new List<Project>();
            foreach (baseProjectView item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public baseProjectView ConvertToView(Project item)
        {
            baseProjectView view = new baseProjectView();
            view.ID = item.ID;
            view.Name = item.Name;
            view.Description = item.Description;
            view.CompanyID = item.CompanyID;
            view.TestingDepth = item.TestingDepth;
            return view;
        }
        public List<baseProjectView> ConvertToViewList(List<Project> itemlist)
        {
            List<baseProjectView> lst = new List<baseProjectView>();
            foreach (Project item in itemlist)
                lst.Add(ConvertToView(item));
            return lst;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public baseProjectView GetProject(int id)
        {
            QAManagement.Data.Services.ProjectService svc = new Data.Services.ProjectService();
            Data.Services.DataContracts.Project item = svc.GetProjectContract(id);

            return this.ConvertToView(item);
        }
    }
}
