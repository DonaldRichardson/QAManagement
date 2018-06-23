using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Views.old
{
public class StepView:baseView
{
public System.Int64 ID { get; set; }
public System.Int64 RequirementID { get; set; }
public System.Int32 Number { get; set; }
public System.String Description { get; set; }
public System.String Result { get; set; }
public System.Boolean IsTest { get; set; }
}
}
