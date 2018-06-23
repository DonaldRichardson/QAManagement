using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QAManagement.Data.Services.DataContracts;

namespace QAManagement.Data.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CommentService" in code, svc and config file together.
    public class CommentService : ICommentService
    {


        public Comment GetCommentById(int id)
        {
            QAManagement.Data.dsQAManagerTableAdapters.CommentsTableAdapter da = new dsQAManagerTableAdapters.CommentsTableAdapter();
            Data.dsQAManager.CommentsDataTable tbl = da.GetDataByID(id);
            dsQAManager.CommentsRow r = tbl[0];
            return new Providers.CommentProvider().ConvertToModel(r);
        }

        public List<Comment> GetAllComments()
        {
            throw new NotImplementedException();
        }


        public void UpdateComment(Comment item)
        {
            QAManagement.Data.dsQAManagerTableAdapters.CommentsTableAdapter da = new dsQAManagerTableAdapters.CommentsTableAdapter();
            
            
        }

    }
}
