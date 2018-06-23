using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Data.Services.DataContracts
{
    [DataContract]
    public class TestResult : QAManager.Data.Services.DataContracts.BaseContract, QAManager.Data.Services.DataContracts.ITestResultContract
    {
        [DataMember]
        public System.Int64 ID { get; set; }
        [DataMember]
        public System.String Results { get; set; }
        [DataMember]
        public System.Int64 RequirementID { get; set; }
        [DataMember]
        public System.Boolean Pass { get; set; }
    }
}
