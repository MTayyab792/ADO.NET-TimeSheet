using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Computan.Timesheet.v2.Tasks
{
    public partial class ViewTasks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    Computan.TimeSheet.v2.Model.BLL.Task taskDetail = new Computan.TimeSheet.v2.Model.BLL.Task();
                    List<Computan.TimeSheet.v2.Model.BLL.Task> objTask = taskDetail.GetAllTask();
                    GridView.DataSource = objTask;
                    GridView.DataBind();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                //Checking the RowType of the Row  
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    Computan.TimeSheet.v2.Model.BLL.Task row = (Computan.TimeSheet.v2.Model.BLL.Task)e.Row.DataItem;
                    HyperLink hlUpdate = (HyperLink)e.Row.FindControl("hlUpdate");
                    hlUpdate.NavigateUrl = "~/Tasks/UpdateTasks.aspx?tid=" + row.TaskId;
                    hlUpdate.Text = "Update";


                    HyperLink hlDelete = (HyperLink)e.Row.FindControl("hlDelete");
                    hlDelete.NavigateUrl = "~/Tasks/DeleteTasks.aspx?tid=" + row.TaskId;
                    hlDelete.Text = "Delete";

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        protected void btnaddtasks_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Tasks/AddTask.aspx");
        }
    }
}