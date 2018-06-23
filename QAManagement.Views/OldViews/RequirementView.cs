using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Views.old
{
public class RequirementView:baseView
{
public System.Int64 ID { get; set; }
public System.String Description { get; set; }
public System.String LongDescription { get; set; }
public System.String Number { get; set; }
public System.Int64 ProjectID { get; set; }
public System.String SpecificationReference { get; set; }
public System.String PassingDescription { get; set; }
public System.Int64 Weighting { get; set; }
public System.Int64 OwnedByUserID { get; set; }
}
}
