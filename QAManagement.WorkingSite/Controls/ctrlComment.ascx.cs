using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QAManagement.WorkingSite.Controls
{
    public partial class ctrlComment : System.Web.UI.UserControl
    {
        /// <summary>
        /// FormView1 control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        public global::System.Web.UI.WebControls.FormView FormView1;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            FormView1.ChangeMode(FormViewMode.Edit);
        }
    }
}