using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Views.old
{
public class ProjectView:baseView
{
public System.Int64 ID { get; set; }
public System.String Name { get; set; }
public System.String Description { get; set; }
public System.Int64 CompanyID { get; set; }
public System.Byte TestingDepth { get; set; }
}
}
