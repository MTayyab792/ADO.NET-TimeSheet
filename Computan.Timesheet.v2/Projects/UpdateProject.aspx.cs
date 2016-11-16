using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Computan.Timesheet.v2.Projects
{
    public partial class UpdateProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    Computan.TimeSheet.v2.Model.BLL.Project objproject = new TimeSheet.v2.Model.BLL.Project();
                    Int64 ptdid = 0;
                    ptdid = Convert.ToInt32(Request.QueryString["pid"].ToString());
                    Computan.TimeSheet.v2.Model.BLL.Project objp = objproject.LoadProjectById(ptdid);

                    txttitle.Text = objp.Title;
                    txtdescription.Text = objp.Description;
                    //IsActiveDropDownList.Text =Convert.ToBoolean(objp.IsActive).ToString();
                    cbIsActive.Checked = objp.IsActive;
                    Created_Date.Text = Convert.ToDateTime(objp.CreatedOn).ToString();


                    //txtcreatedon.Text = Convert.ToDateTime(objp.CreatedOn).ToString(); 

                    Last_Update_Date.Text = Convert.ToString(DateTime.Now);


                    //txtlastupdatedon.Text =Convert.ToDateTime(objp.LastUpdatedOn).ToString();
                    //txtipused.Text = Convert.ToDateTime(objp.IpUsed).ToString();
                    //txtuserid.Text =Convert.ToString(objp.UserId);

                }
            }
            catch (NullReferenceException ex)
            {

                throw ex;
            }

            
        }

        protected void Cancel_Record_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Projects/ViewProject.aspx");
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        protected void update_Record_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSheet.v2.Model.BLL.Project objaddproject = new TimeSheet.v2.Model.BLL.Project();

                objaddproject.ProjectId = Convert.ToInt64(Request.QueryString["pid"]);
                objaddproject.Title = txttitle.Text;
                objaddproject.Description = txtdescription.Text;
                // objaddproject.IsActive = Convert.ToBoolean(IsActiveDropDownList.SelectedValue);
                objaddproject.IsActive = cbIsActive.Checked;
                objaddproject.LastUpdatedOn = DateTime.Now;


                //objaddproject.CreatedOn = Convert.ToDateTime(txtcreatedon.Text);
                //objaddproject.LastUpdatedOn = DateTime.Now;
                //objaddproject.IpUsed = Convert.ToString(txtipused.Text);
                //objaddproject.UserId = Convert.ToString(txtuserid.Text);


                objaddproject.ProjectUpdate();
                Response.Redirect("~/Projects/ViewProject.aspx");

            }
            catch (Exception ex)
            {

                throw ex;
            }
           

        }
    }
}