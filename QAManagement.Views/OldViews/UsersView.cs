using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Views.old
{
public class UsersView:baseView
{
public System.Int64 ID { get; set; }
public System.String Username { get; set; }
public System.String Password { get; set; }
public System.Int64 CompanyID { get; set; }
public System.String Email { get; set; }
public System.String Address1 { get; set; }
public System.String Address2 { get; set; }
public System.String Address3 { get; set; }
public System.String PostalCode { get; set; }
public System.String PhoneNumber { get; set; }
public System.String CellNumber { get; set; }
public System.Int64 PaypointThreshold { get; set; }
public System.String Bank { get; set; }
public System.String AccountNo { get; set; }
public System.String BranchCode { get; set; }
public System.Boolean Active { get; set; }
}
}
