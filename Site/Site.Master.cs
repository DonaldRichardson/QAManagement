using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lnkChangeMode_Click(object sender, EventArgs e)
        {
            if (lnkChangeMode.Text == "Edit Mode")
            {
                Session["Mode"] = "";
                lnkChangeMode.Text = "Normal Mode";
            }
            else
            {
                Session["Mode"] = "Edit";
                lnkChangeMode.Text = "Edit Mode";
            }
        }
    }
}