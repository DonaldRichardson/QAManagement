using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Data.Services.DataContracts
{
[DataContract]
    public class PaymentPoints : QAManager.Data.Services.DataContracts.BaseContract, QAManager.Data.Services.DataContracts.IPaymentPointContract
{
[DataMember]
public System.Int64 ID { get; set; }
[DataMember]
public System.Int64 UserID { get; set; }
[DataMember]
public System.Int64 Points { get; set; }
}
}
