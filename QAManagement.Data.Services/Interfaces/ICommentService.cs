﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QAManagement.Data.Services.DataContracts;

namespace QAManagement.Data.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommentService" in both code and config file together.
    [ServiceContract]
    public interface ICommentService
    {
        [OperationContract]
        Comment GetCommentById(int id);

        [OperationContract]
        List<Comment> GetAllComments();

        [OperationContract]
        void UpdateComment(Comment item);

    }

   
}
