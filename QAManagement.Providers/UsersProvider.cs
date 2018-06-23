using System.Collections.Generic;
using QAManagement.Data.Services.DataContracts;
using QAManagement.Views;
using System.ComponentModel;
namespace QAManagement
{
    [DataObject(true)]
    public class UsersProvider : baseProvider
    {
        public Users ConvertToModel(baseUsersView item)
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
        public List<Users> ConvertToModelList(List<baseUsersView> itemlist)
        {
            List<Users> lst = new List<Users>();
            foreach (baseUsersView item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public baseUsersView ConvertToView(Users item)
        {
            baseUsersView view = new baseUsersView();
            view.ID = item.ID;
            view.Username = item.Username;
            view.Password = item.Password;
            view.CompanyID = item.CompanyID;
            view.Email = item.Email;
            view.Address1 = item.Address1;
            view.Address2 = item.Address2;
            view.Address3 = item.Address3;
            view.PostalCode = item.PostalCode;
            view.PhoneNumber = item.PhoneNumber;
            view.CellNumber = item.CellNumber;
            view.PaypointThreshold = item.PaypointThreshold;
            view.Bank = item.Bank;
            view.AccountNo = item.AccountNo;
            view.BranchCode = item.BranchCode;
            view.Active = item.Active;
            return view;
        }
        public List<baseUsersView> ConvertToViewList(List<Users> itemlist)
        {
            List<baseUsersView> lst = new List<baseUsersView>();
            foreach (Users item in itemlist)
                lst.Add(ConvertToView(item));
            return lst;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public baseUsersView GetPaymentPoint(int id)
        {
            QAManagement.Data.Services.UserService svc = new Data.Services.UserService();
            Data.Services.DataContracts.Users item = svc.GetUsersContract(id);

            return this.ConvertToView(item);
        }
    }
}
