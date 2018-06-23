using System.Collections.Generic;
using System.ComponentModel;
using QAManagement.Data.Services.DataContracts;

namespace QAManagement.Views
{
    [DataObject(true)]
    public class CommentProvider : baseProvider, ICommentProvider
    {
        public baseCommentView view { get; set; }

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
#if visual
            view = new baseCommentView()
            {
                Description = @"Stub Comment",
                ID = 1,
                RequirementID = 1
            };
            return view;
#else
            QAManagement.Data.Services.CommentService svc = new Data.Services.CommentService();
            view = ConvertToView(svc.GetCommentById(ID));
            return view;
#endif
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void UpdateComment(baseCommentView view)
        {
#if visual
#else
             Data.Services.CommentService svc = new Data.Services.CommentService();
            svc.UpdateComment(ConvertToModel(view));
#endif
        }





    }
}
