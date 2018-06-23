using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Views.old
{
public class TestResultView:baseView
{
public System.Int64 ID { get; set; }
public System.String Results { get; set; }
public System.Int64 RequirementID { get; set; }
public System.Boolean Pass { get; set; }
}
}
