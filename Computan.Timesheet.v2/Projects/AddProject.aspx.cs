using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Computan.TimeSheet.v2.Model;
using Microsoft.AspNet.Identity;

namespace Computan.Timesheet.v2.Projects
{
    public partial class AddProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cancel_Record_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Projects/ViewProject.aspx");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSheet.v2.Model.BLL.Project objaddproject = new TimeSheet.v2.Model.BLL.Project();

                objaddproject.Title = txttitle.Text;
                objaddproject.Description = txtdescription.Text;
                //objaddproject.IsActive = Convert.ToBoolean(IsActiveDropDownList.SelectedValue);
                objaddproject.IsActive = cbIsactive.Checked;
                objaddproject.CreatedOn = DateTime.Now;
                objaddproject.LastUpdatedOn = DateTime.Now;
                objaddproject.IpUsed = Request.UserHostAddress;
                objaddproject.UserId = User.Identity.GetUserId();

                objaddproject.ProjectInsert();
                Label1.Text = "Project is Added";   
                Response.Redirect("~/Projects/ViewProject.aspx");

            }
            catch (FormatException ex)
            {
                throw ex;

            }

        }
    }
}