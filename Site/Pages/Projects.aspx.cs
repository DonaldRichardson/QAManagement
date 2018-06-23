using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class Project : QAManagement.Site.Pages.BasePage
    {
        
        
        public override void Page_Load(object sender, EventArgs e)
        {
            NextPage = "Project.aspx";
            base.Page_Load(sender, e);

        }

        new void GridSelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void lnkUsers_Click(object sender, EventArgs e)
        {
            Server.Transfer(@"User.aspx?ID=" + Request.QueryString.Get("ID"));
        }




    }
}