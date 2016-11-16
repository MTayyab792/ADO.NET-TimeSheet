using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Computan.Timesheet.v2.Skills
{
    public partial class DeleteSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    Computan.TimeSheet.v2.Model.BLL.Skill objSkill = new Computan.TimeSheet.v2.Model.BLL.Skill();
                    Int64 sid = 0;
                    sid = Convert.ToInt32(Request.QueryString["sid"].ToString());
                    Computan.TimeSheet.v2.Model.BLL.Skill objp = objSkill.SkillsLoadSkillById(sid);

                    txtname.Text = objp.Name;
                    //IsActiveDropDownList.Text = Convert.ToBoolean(objp.IsActive).ToString();
                    cbIsActive.Checked = objp.IsActive;
                }
            }
            catch (NullReferenceException ex)
            {

                throw ex;
            }
        }

        protected void Delete_Skill_Click(object sender, EventArgs e)
        {
                Computan.TimeSheet.v2.Model.BLL.Skill objDel = new Computan.TimeSheet.v2.Model.BLL.Skill();
                Int64 sid = 0;
                sid = Convert.ToInt32(Request.QueryString["sid"].ToString());

                Computan.TimeSheet.v2.Model.BLL.Skill objD = objDel.SkillsDelete(sid);
         
                
                Label1.Text = "Skill Deleted";
                Response.Redirect("ViewSkill.aspx");                     
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("ViewSkill.aspx");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}