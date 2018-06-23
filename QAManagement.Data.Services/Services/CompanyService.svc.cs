using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QAManagement.Data.Services.DataContracts;

namespace QAManagement.Data.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in code, svc and config file together.
    public class CompanyService : ICompanyService
    {

        public Company GetCompany(int id)
        {
            QAManagement.Data.dsQAManagerTableAdapters.CompanyTableAdapter da = new dsQAManagerTableAdapters.CompanyTableAdapter();
            
            Data.dsQAManager.CompanyDataTable tbl = da.GetDataByID(id);
            dsQAManager.CompanyRow item = tbl[0];
            
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

        List<Company> ICompanyService.GetAllCompanies()
        {
            throw new NotImplementedException();
        }
    }
}
