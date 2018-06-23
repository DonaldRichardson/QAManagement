using System.Collections.Generic;
using QAManagement.Data.Services.Providers;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Data.Services.Providers
{
    public class ProjectUsersProvider : baseDataProvider
    {
        public ProjectUsers ConvertToModel(QAManagement.Data.dsQAManager.ProjectUsersRow item)
        {
            ProjectUsers model = new ProjectUsers();
            model.ID = item.ID;
            model.UserID = item.UserID;
            model.ProjectID = item.ProjectID;
            return model;
        }
        public List<ProjectUsers> ConvertToModelList(QAManagement.Data.dsQAManager.ProjectUsersDataTable itemlist)
        {
            List<ProjectUsers> lst = new List<ProjectUsers>();
            foreach (QAManagement.Data.dsQAManager.ProjectUsersRow item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public QAManagement.Data.dsQAManager.ProjectUsersRow ConvertToDataRow(ProjectUsers item)
        {
            QAManagement.Data.dsQAManager.ProjectUsersRow model = new QAManagement.Data.dsQAManager.ProjectUsersDataTable().NewProjectUsersRow();
            model.ID = item.ID;
            model.UserID = item.UserID;
            model.ProjectID = item.ProjectID;
            return model;
        }
        public QAManagement.Data.dsQAManager.ProjectUsersDataTable ConvertToDataTable(List<ProjectUsers> itemlist)
        {
            QAManagement.Data.dsQAManager.ProjectUsersDataTable lst = new QAManagement.Data.dsQAManager.ProjectUsersDataTable();
            foreach (ProjectUsers item in itemlist)
                lst.AddProjectUsersRow(ConvertToDataRow(item));
            return lst;
        }

    }
}
