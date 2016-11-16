using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Computan.Timesheet.v2.Skills
{
    public partial class ViewSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    Computan.TimeSheet.v2.Model.BLL.Skill skillDetail = new Computan.TimeSheet.v2.Model.BLL.Skill();
                    List<Computan.TimeSheet.v2.Model.BLL.Skill> objskill = skillDetail.GetAllSkill();
                    GridView.DataSource = objskill;
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
                    Computan.TimeSheet.v2.Model.BLL.Skill row = (Computan.TimeSheet.v2.Model.BLL.Skill)e.Row.DataItem;
                    HyperLink hlUpdate = (HyperLink)e.Row.FindControl("hlUpdate");
                    hlUpdate.NavigateUrl = "~/Skills/UpdateSkill.aspx?sid=" + row.SkillId;
                    hlUpdate.Text = "Update";


                    HyperLink hlDelete = (HyperLink)e.Row.FindControl("hlDelete");
                    hlDelete.NavigateUrl = "~/Skills/DeleteSkill.aspx?sid=" + row.SkillId;
                    hlDelete.Text = "Delete";

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void Add_Skill_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("AddSkill.aspx");
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}