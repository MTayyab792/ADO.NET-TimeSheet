using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Computan.Timesheet.v2.Projects
{
    public partial class DeleteProject : System.Web.UI.Page
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
                    //IsActiveDropDownList.Text = Convert.ToBoolean(objp.IsActive).ToString();
                    cbIsAtive.Checked = objp.IsActive;
                    Lbl_Created_On.Text = Convert.ToDateTime(objp.CreatedOn).ToString();
                   Lbl_Last_updated_On.Text = Convert.ToString(DateTime.Now);

                    //txtcreatedon.Text = Convert.ToDateTime(objp.CreatedOn).ToString(); ;
                    //txtlastupdatedon.Text = Convert.ToDateTime(objp.LastUpdatedOn).ToString();
                    //txtipused.Text = Convert.ToDateTime(objp.IpUsed).ToString();
                    //txtuserid.Text = Convert.ToString(objp.UserId);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

     

        protected void Cancel_Record_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Projects/ViewProject.aspx");
        }

        protected void Delete_Record_Click(object sender, EventArgs e)
        {

            Computan.TimeSheet.v2.Model.BLL.Project objDel = new TimeSheet.v2.Model.BLL.Project();
            Int64 pid = 0;
            pid = Convert.ToInt32(Request.QueryString["pid"].ToString());

            Computan.TimeSheet.v2.Model.BLL.Project objD = objDel.ProjectDelete(pid);


            Label1.Text = "Record Deleted";

            Response.Redirect("~/Projects/ViewProject.aspx");


        }
    }
}