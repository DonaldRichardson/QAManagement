using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class Company : QAManagement.Site.Pages.BasePage
    {
      

        public override void Page_Load(object sender, EventArgs e)
        {
            NextPage = "Projects.aspx";
            base.Page_Load(sender, e);
            
        }


        new void GridSelectedIndexChanged(Object sender, EventArgs e)
        {
          
            //object x = grdCompanies.SelectedDataKey.Value;
            //Server.Transfer(@"Projects.aspx?ID=" + grdList.SelectedDataKey.Value.ToString());
            //fvEdit.Visible = true;
        }

        protected void lnkAdd_Click(object sender, EventArgs e)
        {
            Server.Transfer(@"User.aspx?ID=" + grdList.SelectedDataKey.Value.ToString());
        }




    }
}