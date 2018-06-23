
using System.Collections.Generic;
using System.ComponentModel;
using QAManagement.Data.Services.DataContracts;
using QAManagement.Views;

namespace QAManagement
{
    [DataObject(true)]
    public class CompanyProvider : baseProvider
    {
        public Company ConvertToModel(baseCompanyView item)
        {
            Company model = new Company();
            model.ID = item.ID;
            model.Name = item.Name;
            model.Description = item.Description;
            model.ContactPerson = item.ContactPerson;
            model.ContactPersonNumber = item.ContactPersonNumber;
            model.ContactEmail = item.ContactEmail;
            model.Address1 = item.Address1;
            model.Address2 = item.Address2;
            model.Address3 = item.Address3;
            model.PostalCode = item.PostalCode;
            model.OfficePhoneNumber = item.OfficePhoneNumber;
            model.OfficeEmail = item.OfficeEmail;
            model.Validated = item.Validated;
            return model;
        }
        public List<Company> ConvertToModelList(List<baseCompanyView> itemlist)
        {
            List<Company> lst = new List<Company>();
            foreach (baseCompanyView item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public baseCompanyView ConvertToView(Company item)
        {
            baseCompanyView view = new baseCompanyView();
            view.ID = item.ID;
            view.Name = item.Name;
            view.Description = item.Description;
            view.ContactPerson = item.ContactPerson;
            view.ContactPersonNumber = item.ContactPersonNumber;
            view.ContactEmail = item.ContactEmail;
            view.Address1 = item.Address1;
            view.Address2 = item.Address2;
            view.Address3 = item.Address3;
            view.PostalCode = item.PostalCode;
            view.OfficePhoneNumber = item.OfficePhoneNumber;
            view.OfficeEmail = item.OfficeEmail;
            view.Validated = item.Validated;
            return view;
        }
        public List<baseCompanyView> ConvertToViewList(List<Company> itemlist)
        {
            List<baseCompanyView> lst = new List<baseCompanyView>();
            foreach (Company item in itemlist)
                lst.Add(ConvertToView(item));
            return lst;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public baseCompanyView GetCompany(int id)
        {
            QAManagement.Data.Services.CompanyService svc =  new Data.Services.CompanyService();
            Data.Services.DataContracts.Company item = svc.GetCompany(id);

            baseCompanyView view = new baseCompanyView();
            view = this.ConvertToView(item);

            return view;
        }

    }
}
