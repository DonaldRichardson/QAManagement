using System.Collections.Generic;
using QAManagement.Data.Services.DataContracts;
using QAManagement.Data.Services.Providers;

namespace QAManagement.Data.Services.Providers
{
    public class UsersProvider : baseDataProvider
    {
        public Users ConvertToModel(QAManagement.Data.dsQAManager.UsersRow item)
        {
            Users model = new Users();
            model.ID = item.ID;
            model.Username = item.Username;
            model.Password = item.Password;
            model.CompanyID = item.CompanyID;
            model.Email = item.Email;
            model.Address1 = item.Address1;
            model.Address2 = item.Address2;
            model.Address3 = item.Address3;
            model.PostalCode = item.PostalCode;
            model.PhoneNumber = item.PhoneNumber;
            model.CellNumber = item.CellNumber;
            model.PaypointThreshold = item.PaypointThreshold;
            model.Bank = item.Bank;
            model.AccountNo = item.AccountNo;
            model.BranchCode = item.BranchCode;
            model.Active = item.Active;
            return model;
        }
        public List<Users> ConvertToModelList(QAManagement.Data.dsQAManager.UsersDataTable itemlist)
        {
            List<Users> lst = new List<Users>();
            foreach (QAManagement.Data.dsQAManager.UsersRow item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public QAManagement.Data.dsQAManager.UsersRow ConvertToDataRow(Users item)
        {
            QAManagement.Data.dsQAManager.UsersRow model = new QAManagement.Data.dsQAManager.UsersDataTable().NewUsersRow();
            model.ID = item.ID;
            model.Username = item.Username;
            model.Password = item.Password;
            model.CompanyID = item.CompanyID;
            model.Email = item.Email;
            model.Address1 = item.Address1;
            model.Address2 = item.Address2;
            model.Address3 = item.Address3;
            model.PostalCode = item.PostalCode;
            model.PhoneNumber = item.PhoneNumber;
            model.CellNumber = item.CellNumber;
            model.PaypointThreshold = item.PaypointThreshold;
            model.Bank = item.Bank;
            model.AccountNo = item.AccountNo;
            model.BranchCode = item.BranchCode;
            model.Active = item.Active;
            return model;
        }
        public QAManagement.Data.dsQAManager.UsersDataTable ConvertToDataTable(List<Users> itemlist)
        {
            QAManagement.Data.dsQAManager.UsersDataTable lst = new QAManagement.Data.dsQAManager.UsersDataTable();
            foreach (Users item in itemlist)
                lst.AddUsersRow(ConvertToDataRow(item));
            return lst;
        }

    }
}
