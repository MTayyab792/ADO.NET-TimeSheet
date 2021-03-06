﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Computan.Timesheet.v2.Tasks
{
    public partial class DeleteTasks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!Page.IsPostBack)
                {
                    List<Computan.TimeSheet.v2.Model.BLL.Project> objProject = new TimeSheet.v2.Model.BLL.Project().GetAllProject();
                    projectnameDropDownList2.DataSource = objProject;
                    projectnameDropDownList2.DataTextField = "Title";
                    projectnameDropDownList2.DataValueField = "ProjectId";
                    projectnameDropDownList2.DataBind();
                    projectnameDropDownList2.Items.Insert(0, "Please Select Project");


                    TimeSheet.v2.Model.BLL.Skill skillDetail = new TimeSheet.v2.Model.BLL.Skill();
                    List<Computan.TimeSheet.v2.Model.BLL.Skill> objskill = skillDetail.GetAllSkill();
                    skillnameDropDownList3.DataSource = objskill;
                    skillnameDropDownList3.DataTextField = "Name";
                    skillnameDropDownList3.DataValueField = "SkillId";
                    skillnameDropDownList3.DataBind();
                    skillnameDropDownList3.Items.Insert(0, "Please Select Skill");


                    Computan.TimeSheet.v2.Model.BLL.Task objTask = new TimeSheet.v2.Model.BLL.Task();
                    Int64 tid = 0;
                    tid = Convert.ToInt32(Request.QueryString["tid"].ToString());
                    Computan.TimeSheet.v2.Model.BLL.Task objt = objTask.TasksLoadByTaskId(tid);

                    txttitle.Text = objt.Title;
                    txtdetails.Text = objt.Details;
                    projectnameDropDownList2.Items.FindByValue(objt.ProjectId.ToString()).Selected = true;
                    projectnameDropDownList2.SelectedValue = objt.ProjectId.ToString();

                    skillnameDropDownList3.Items.FindByValue(objt.SkillId.ToString()).Selected = true;
                    skillnameDropDownList3.SelectedValue = objt.SkillId.ToString();
                    Created_Date.Text = Convert.ToDateTime(objt.CreatedOnUTC).ToString();
                    Last_Update_Date.Text = Convert.ToString(DateTime.UtcNow);
                    txtdatetime.Text = Convert.ToString(objt.TaskDate);


                    List<string> minutes = new List<string>();
                    for (int i = 5; i <= 600; i = i + 5)
                    {
                        if (i < 600)
                        {
                            minutes.Add(i.ToString("00"));
                        }


                    }

                    timeInMinutesDropDownList1.DataSource = minutes;
                    timeInMinutesDropDownList1.DataBind();

                    timeInMinutesDropDownList1.Items.Insert(0, "Please Select Minutes");
                    timeInMinutesDropDownList1.Items.FindByValue(objt.TimeInMinutes.ToString()).Selected = true;
                    timeInMinutesDropDownList1.SelectedValue = objt.TimeInMinutes.ToString();

                }
            }
            catch (NullReferenceException ex)
            {

                throw ex;
            }

        }

        protected void btnDeletetask_Click(object sender, EventArgs e)
        {
            Computan.TimeSheet.v2.Model.BLL.Task objDel = new TimeSheet.v2.Model.BLL.Task();
            Int64 tid = 0;
            tid = Convert.ToInt32(Request.QueryString["tid"].ToString());

            Computan.TimeSheet.v2.Model.BLL.Task objD = objDel.TasksDelete(tid);




            Response.Redirect("~/Tasks/ViewTasks.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Tasks/ViewTasks.aspx");

        }
    }
}