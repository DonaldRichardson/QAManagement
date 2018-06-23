using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Views.old
{
public class CompanyView:baseView
{
public System.Int64 ID { get; set; }
public System.String Name { get; set; }
public System.String Description { get; set; }
public System.String ContactPerson { get; set; }
public System.String ContactPersonNumber { get; set; }
public System.String ContactEmail { get; set; }
public System.String Address1 { get; set; }
public System.String Address2 { get; set; }
public System.String Address3 { get; set; }
public System.String PostalCode { get; set; }
public System.String OfficePhoneNumber { get; set; }
public System.String OfficeEmail { get; set; }
public System.DateTime Validated { get; set; }
}
}
