using System.Collections.Generic;
using System.ComponentModel;
using QAManagement.Data.Services.DataContracts;
using QAManagement.Views;

namespace QAManagement
{
    [DataObject(true)]
    public class CommentProvider : baseProvider
    {
        public Comment ConvertToModel(baseCommentView item)
        {
            Comment model = new Comment();
            model.ID = item.ID;
            model.Description = item.Description;
            model.RequirementID = item.RequirementID;
            return model;
        }
        public List<Comment> ConvertToModelList(List<baseCommentView> itemlist)
        {
            List<Comment> lst = new List<Comment>();
            foreach (baseCommentView item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public baseCommentView ConvertToView(Comment item)
        {
            baseCommentView view = new baseCommentView();
            view.ID = item.ID;
            view.Description = item.Description;
            view.RequirementID = item.RequirementID;
            return view;
        }
        public List<baseCommentView> ConvertToViewList(List<Comment> itemlist)
        {
            List<baseCommentView> lst = new List<baseCommentView>();
            foreach (Comment item in itemlist)
                lst.Add(ConvertToView(item));
            return lst;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public baseCommentView GetComment(int id)
        {
           
            Data.Services.CommentService svc = new Data.Services.CommentService();
            Data.Services.DataContracts.Comment contract = svc.GetCommentById(id);
            baseCommentView view = new baseCommentView
            {
                Description = contract.Description,
                ID = contract.ID,
                RequirementID = contract.RequirementID
            };

            return view;
        }

    }
}
