using System.Collections.Generic;
using QAManagement.Data.Services.Providers;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Data.Services.Providers
{
    public class CompanyProvider : baseDataProvider
    {
        public Company ConvertToModel(QAManagement.Data.dsQAManager.CompanyRow item)
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
        public List<Company> ConvertToModelList(QAManagement.Data.dsQAManager.CompanyDataTable itemlist)
        {
            List<Company> lst = new List<Company>();
            foreach (QAManagement.Data.dsQAManager.CompanyRow item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public QAManagement.Data.dsQAManager.CompanyRow ConvertToDataRow(Company item)
        {
            QAManagement.Data.dsQAManager.CompanyRow model = new QAManagement.Data.dsQAManager.CompanyDataTable().NewCompanyRow();
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
        public QAManagement.Data.dsQAManager.CompanyDataTable ConvertToDataTable(List<Company> itemlist)
        {
            QAManagement.Data.dsQAManager.CompanyDataTable lst = new QAManagement.Data.dsQAManager.CompanyDataTable();
            foreach (Company item in itemlist)
                lst.AddCompanyRow(ConvertToDataRow(item));
            return lst;
        }

    }
}
