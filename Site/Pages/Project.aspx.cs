using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QAManagement.Site.Pages
{
    public partial class Project : QAManagement.Site.Pages.BasePage
    {
        new void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkUser_Click(object sender, EventArgs e)
        {
            Server.Transfer(@"ProjectUser.aspx?ID=" + Request.QueryString.Get("ID"));
        }
    }
}