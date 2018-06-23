using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Data.Services.DataContracts
{
[DataContract]
    public class Company : QAManager.Data.Services.DataContracts.BaseContract, QAManager.Data.Services.DataContracts.IBaseContract
{
[DataMember]
public System.Int64 ID { get; set; }
[DataMember]
public System.String Name { get; set; }
[DataMember]
public System.String Description { get; set; }
[DataMember]
public System.String ContactPerson { get; set; }
[DataMember]
public System.String ContactPersonNumber { get; set; }
[DataMember]
public System.String ContactEmail { get; set; }
[DataMember]
public System.String Address1 { get; set; }
[DataMember]
public System.String Address2 { get; set; }
[DataMember]
public System.String Address3 { get; set; }
[DataMember]
public System.String PostalCode { get; set; }
[DataMember]
public System.String OfficePhoneNumber { get; set; }
[DataMember]
public System.String OfficeEmail { get; set; }
[DataMember]
public System.DateTime Validated { get; set; }
}
}
