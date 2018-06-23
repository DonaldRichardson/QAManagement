using System.Collections.Generic;
using QAManagement.Data.Services.Providers;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Data.Services.Providers
{
    public class CommentProvider : baseDataProvider
    {
        public Comment ConvertToModel(QAManagement.Data.dsQAManager.CommentsRow item)
        {
            Comment model = new Comment();
            model.ID = item.ID;
            model.Description = item.Description;
            model.RequirementID = item.RequirementID;
            return model;
        }
        public List<Comment> ConvertToModelList(QAManagement.Data.dsQAManager.CommentsDataTable itemlist)
        {
            List<Comment> lst = new List<Comment>();
            foreach (QAManagement.Data.dsQAManager.CommentsRow item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public QAManagement.Data.dsQAManager.CommentsRow ConvertToDataRow(Comment item)
        {
            QAManagement.Data.dsQAManager.CommentsRow model = new QAManagement.Data.dsQAManager.CommentsDataTable().NewCommentsRow();
            model.ID = item.ID;
            model.Description = item.Description;
            model.RequirementID = item.RequirementID;
            return model;
        }
        public QAManagement.Data.dsQAManager.CommentsDataTable ConvertToDataTable(List<Comment> itemlist)
        {
            QAManagement.Data.dsQAManager.CommentsDataTable lst = new QAManagement.Data.dsQAManager.CommentsDataTable();
            foreach (Comment item in itemlist)
                lst.AddCommentsRow(ConvertToDataRow(item));
            return lst;
        }

    }
}
