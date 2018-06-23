using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Data.Services.DataContracts
{
[DataContract]
    public class Project : QAManager.Data.Services.DataContracts.BaseContract, QAManager.Data.Services.DataContracts.IProjectContract
{
[DataMember]
public System.Int64 ID { get; set; }
[DataMember]
public System.String Name { get; set; }
[DataMember]
public System.String Description { get; set; }
[DataMember]
public System.Int64 CompanyID { get; set; }
[DataMember]
public System.Byte TestingDepth { get; set; }
}
}
