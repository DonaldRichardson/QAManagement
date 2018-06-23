using QAManagement.Data.Services.DataContracts;
using System.Collections.Generic;
using System.ComponentModel;

namespace QAManagement.Views
{
    [DataObject(true)]
    public class CompanyProvider : baseProvider, ICompanyProvider
    {
        //public Company ConvertToModel(CompanyView item)
        //{
        //    Company model = new Company();
        //    model.ID = item.ID;
        //    model.Name = item.Name;
        //    model.Description = item.Description;
        //    model.ContactPerson = item.ContactPerson;
        //    model.ContactPersonNumber = item.ContactPersonNumber;
        //    model.ContactEmail = item.ContactEmail;
        //    model.Address1 = item.Address1;
        //    model.Address2 = item.Address2;
        //    model.Address3 = item.Address3;
        //    model.PostalCode = item.PostalCode;
        //    model.OfficePhoneNumber = item.OfficePhoneNumber;
        //    model.OfficeEmail = item.OfficeEmail;
        //    model.Validated = item.Validated;
        //    return model;
        //}
        //public List<Company> ConvertToModelList(List<CompanyView> itemlist)
        //{
        //    List<CompanyContract> lst = new List<CompanyContract>();
        //    foreach (CompanyView item in itemlist)
        //        lst.Add(ConvertToModel(item));
        //    return lst;
        //}
        //public CompanyView ConvertToView(Company item)
        //{
        //    CompanyView view = new CompanyView();
        //    view.ID = item.ID;
        //    view.Name = item.Name;
        //    view.Description = item.Description;
        //    view.ContactPerson = item.ContactPerson;
        //    view.ContactPersonNumber = item.ContactPersonNumber;
        //    view.ContactEmail = item.ContactEmail;
        //    view.Address1 = item.Address1;
        //    view.Address2 = item.Address2;
        //    view.Address3 = item.Address3;
        //    view.PostalCode = item.PostalCode;
        //    view.OfficePhoneNumber = item.OfficePhoneNumber;
        //    view.OfficeEmail = item.OfficeEmail;
        //    view.Validated = item.Validated;
        //    return view;
        //}
        //public List<CompanyView> ConvertToViewList(List<Company> itemlist)
        //{
        //    List<CompanyView> lst = new List<CompanyView>();
        //    foreach (CompanyContract item in itemlist)
        //        lst.Add(ConvertToView(item));
        //    return lst;
        //}

        //[DataObjectMethod(DataObjectMethodType.Select)]
        //public CompanyView GetCompany(int id)
        //{
        //    Data.Services.CompanyService svc = new Data.Services.CompanyService();
        //    Data.Services.Interfaces.Company item = new Company();// svc.GetCompany(id);
        //    CompanyView view = new CompanyView();
        //    view.ID = item.ID;
        //    view.Name = item.Name;
        //    view.Description = item.Description;
        //    view.ContactPerson = item.ContactPerson;
        //    view.ContactPersonNumber = item.ContactPersonNumber;
        //    view.ContactEmail = item.ContactEmail;
        //    view.Address1 = item.Address1;
        //    view.Address2 = item.Address2;
        //    view.Address3 = item.Address3;
        //    view.PostalCode = item.PostalCode;
        //    view.OfficePhoneNumber = item.OfficePhoneNumber;
        //    view.OfficeEmail = item.OfficeEmail;
        //    view.Validated = item.Validated;
        //    return view;
        //}

    }
}
