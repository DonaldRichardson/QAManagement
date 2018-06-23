using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QAManagement.Site.Pages
{
    public partial class BasePage : System.Web.UI.Page
    {

        protected GridView grdList;
        protected FormView fvEdit;

        public string NextPage { get; set; }
        public string Mode
        {
            get
            {
                if (Session["Mode"] == null)
                {
                    return "";
                }
                else
                    return Session["Mode"].ToString();
            }
            set { Session["Mode"] = value; }
        }

        public virtual void Page_Load(object sender, EventArgs e)
        {
            if (Mode == "Edit")
            {
                if (fvEdit != null)
                {
                    fvEdit.Visible = true;
                }
            }
            else
            {
                if (fvEdit != null)
                {
                    fvEdit.Visible = false;
                }
                
            }
        }

        public virtual void GridSelectedIndexChanged(Object sender, EventArgs e)
        {
            if (Mode=="")
            {
                 Server.Transfer(NextPage + "?ID=" + grdList.SelectedDataKey.Value.ToString());
            }
           
        }
    }
}