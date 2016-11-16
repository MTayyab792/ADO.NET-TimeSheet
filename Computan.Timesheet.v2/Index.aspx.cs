using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Computan.Timesheet.v2
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    // Make sure user is authenticated.
                    if (!User.Identity.IsAuthenticated)
                    {
                        Response.Redirect("/account/login");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}