using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Views.old
{
public class PaymentPointsView:baseView
{
public System.Int64 ID { get; set; }
public System.Int64 UserID { get; set; }
public System.Int64 Points { get; set; }
}
}
