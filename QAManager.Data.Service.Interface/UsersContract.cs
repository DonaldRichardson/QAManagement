using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace QAManagement.Data.Services.DataContracts
{
    [DataContract]
    public class Users : QAManager.Data.Services.DataContracts.BaseContract, QAManager.Data.Services.DataContracts.IUserContract
    {
        [DataMember]
        public System.Int64 ID { get; set; }
        [DataMember]
        public System.String Username { get; set; }
        [DataMember]
        public System.String Password { get; set; }
        [DataMember]
        public System.Int64 CompanyID { get; set; }
        [DataMember]
        public System.String Email { get; set; }
        [DataMember]
        public System.String Address1 { get; set; }
        [DataMember]
        public System.String Address2 { get; set; }
        [DataMember]
        public System.String Address3 { get; set; }
        [DataMember]
        public System.String PostalCode { get; set; }
        [DataMember]
        public System.String PhoneNumber { get; set; }
        [DataMember]
        public System.String CellNumber { get; set; }
        [DataMember]
        public System.Int64 PaypointThreshold { get; set; }
        [DataMember]
        public System.String Bank { get; set; }
        [DataMember]
        public System.String AccountNo { get; set; }
        [DataMember]
        public System.String BranchCode { get; set; }
        [DataMember]
        public System.Boolean Active { get; set; }
    }
}
