using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Data.Services.DataContracts
{
[DataContract]
    public class Requirement : QAManager.Data.Services.DataContracts.BaseContract, QAManager.Data.Services.DataContracts.IRequirementContract
{
[DataMember]
public System.Int64 ID { get; set; }
[DataMember]
public System.String Description { get; set; }
[DataMember]
public System.String LongDescription { get; set; }
[DataMember]
public System.String Number { get; set; }
[DataMember]
public System.Int64 ProjectID { get; set; }
[DataMember]
public System.String SpecificationReference { get; set; }
[DataMember]
public System.String PassingDescription { get; set; }
[DataMember]
public System.Int64 Weighting { get; set; }
[DataMember]
public System.Int64 OwnedByUserID { get; set; }
}
}
