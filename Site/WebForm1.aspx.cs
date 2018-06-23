using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace QAManagement.Site
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            QAManagementModel.Company co = new QAManagementModel.Company();
            QAManagementModel.QAManagementEntities context = new QAManagementModel.QAManagementEntities(new Uri(@"http://localhost:49329/WcfDataService1.svc"));
            co.Name = "Disconnected Service Inserted";
            co.OfficeEmail = " I wonder";
            context.AddToCompanies(co);
            context.SaveChanges();
            
            
        }
    }
}