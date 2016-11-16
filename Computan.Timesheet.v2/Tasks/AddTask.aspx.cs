using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Computan.Timesheet.v2.Tasks
{
    public partial class AddTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TimeSheet.v2.Model.BLL.Project projectDetail = new TimeSheet.v2.Model.BLL.Project();
                List<Computan.TimeSheet.v2.Model.BLL.Project> objProject = projectDetail.GetAllProject();
                projectnameDropDownList2.DataSource = objProject;
                projectnameDropDownList2.DataTextField = "Title";
                projectnameDropDownList2.DataValueField = "ProjectId";
                projectnameDropDownList2.DataBind();
                projectnameDropDownList2.Items.Insert(0, "Please Select Project");

            }
            if (!Page.IsPostBack)
            {
                TimeSheet.v2.Model.BLL.Skill skillDetail = new TimeSheet.v2.Model.BLL.Skill();
                List<Computan.TimeSheet.v2.Model.BLL.Skill> objskill = skillDetail.GetAllSkill();
                skillnameDropDownList3.DataSource = objskill;
                skillnameDropDownList3.DataTextField = "Name";
                skillnameDropDownList3.DataValueField = "SkillId";
                skillnameDropDownList3.DataBind();
                skillnameDropDownList3.Items.Insert(0, "Please Select Skill");
            }
            if (!Page.IsPostBack)
            {

                List<string> minutes = new List<string>();
                for (int i = 5; i <= 600; i=i+5)
                {
                    if (i < 600)
                    {
                        minutes.Add(i.ToString("00"));
                    }


                }

                timeInMinutesDropDownList1.DataSource = minutes;
                timeInMinutesDropDownList1.DataBind();

               timeInMinutesDropDownList1.Items.Insert(0, "Please Select Minutes");

            }

        }
        protected void btnaddtask_Click(object sender, EventArgs e)
        {

            try
            {
                TimeSheet.v2.Model.BLL.Task objaddTask = new TimeSheet.v2.Model.BLL.Task();
                objaddTask.ProjectId = Convert.ToInt64(projectnameDropDownList2.SelectedValue);
                objaddTask.SkillId = Convert.ToInt64(skillnameDropDownList3.SelectedValue);


                // objaddTask.TaskDate = Convert.ToDateTime(Request.Form["txtdatetime"]);

                //objaddTask.TaskDate = Request.Form[txtdatetime.UniqueID];
                objaddTask.Title = txttitle.Text;
                objaddTask.TaskDate = Convert.ToDateTime(txtdatetime.Text);
                objaddTask.Details = txtdetails.Text;
                objaddTask.TimeInMinutes = Convert.ToInt32(timeInMinutesDropDownList1.SelectedValue);
                objaddTask.CreatedOnUTC = DateTime.UtcNow;
                objaddTask.UpdatedOnUTC = DateTime.UtcNow;
                objaddTask.IpUsed = Request.UserHostAddress;
                objaddTask.UserId = User.Identity.GetUserId();  

                objaddTask.TasksInsert();
                Response.Redirect("~/Tasks/ViewTasks.aspx");


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/Tasks/ViewTasks.aspx");

        }
    }
}