using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QAManagement.Data.Services.DataContracts;

namespace QAManagement.Views.old
{

    public class CommentView : Comment
    {
        public System.Int64 ID { get; set; }
        public System.String Description { get; set; }
        public System.Int64 RequirementID { get; set; }
    }
}
