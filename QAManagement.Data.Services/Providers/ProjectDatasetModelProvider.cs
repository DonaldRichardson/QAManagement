using System.Collections.Generic;
using QAManagement.Data.Services.Providers;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Data.Services.Providers
{
    public class ProjectProvider : baseDataProvider
    {
        public Project ConvertToModel(QAManagement.Data.dsQAManager.ProjectRow item)
        {
            Project model = new Project();
            model.ID = item.ID;
            model.Name = item.Name;
            model.Description = item.Description;
            model.CompanyID = item.CompanyID;
            model.TestingDepth = item.TestingDepth;
            return model;
        }
        public List<Project> ConvertToModelList(QAManagement.Data.dsQAManager.ProjectDataTable itemlist)
        {
            List<Project> lst = new List<Project>();
            foreach (QAManagement.Data.dsQAManager.ProjectRow item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public QAManagement.Data.dsQAManager.ProjectRow ConvertToDataRow(Project item)
        {
            QAManagement.Data.dsQAManager.ProjectRow model = new QAManagement.Data.dsQAManager.ProjectDataTable().NewProjectRow();
            model.ID = item.ID;
            model.Name = item.Name;
            model.Description = item.Description;
            model.CompanyID = item.CompanyID;
            model.TestingDepth = item.TestingDepth;
            return model;
        }
        public QAManagement.Data.dsQAManager.ProjectDataTable ConvertToDataTable(List<Project> itemlist)
        {
            QAManagement.Data.dsQAManager.ProjectDataTable lst = new QAManagement.Data.dsQAManager.ProjectDataTable();
            foreach (Project item in itemlist)
                lst.AddProjectRow(ConvertToDataRow(item));
            return lst;
        }

    }
}
