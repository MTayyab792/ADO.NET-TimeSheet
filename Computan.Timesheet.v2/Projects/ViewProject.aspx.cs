using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Computan.TimeSheet.v2.Model;

namespace Computan.Timesheet.v2.Projects
{
    public partial class ViewProject : System.Web.UI.Page
    {
        protected void  Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Make sure user is authenticated.
                if (!User.Identity.IsAuthenticated)
                {
                    Response.Redirect("/account/login");
                }
            }


            try
            {
                if (!Page.IsPostBack)
                {
                    TimeSheet.v2.Model.BLL.Project projectDetail = new TimeSheet.v2.Model.BLL.Project();
                    List<Computan.TimeSheet.v2.Model.BLL.Project> objProject = projectDetail.GetAllProject();
                    GridView.DataSource = objProject;
                    GridView.DataBind();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
           

        }
            public void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                //Checking the RowType of the Row  
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    Computan.TimeSheet.v2.Model.BLL.Project row = (Computan.TimeSheet.v2.Model.BLL.Project)e.Row.DataItem;
                    HyperLink hlUpdate = (HyperLink)e.Row.FindControl("hlUpdate");
                    hlUpdate.NavigateUrl = "~/Projects/UpdateProject.aspx?pid=" + row.ProjectId;
                    //hlUpdate.Text = "Update";


                    HyperLink hlDelete = (HyperLink)e.Row.FindControl("hlDelete");
                    hlDelete.NavigateUrl = "~/Projects/DeleteProject.aspx?pid=" + row.ProjectId;
                    hlDelete.Text = "Delete";

                }
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
                Response.Redirect("AddProject.aspx");
            }

            catch (Exception ex)
            {

                throw ex;
            }

        }

     
        }
}