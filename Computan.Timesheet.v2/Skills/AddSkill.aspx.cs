using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Computan.Timesheet.v2.Skills
{
    public partial class AddSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Skill_Click(object sender, EventArgs e)
        {
            try
            {
                Computan.TimeSheet.v2.Model.BLL.Skill objAddSkill = new Computan.TimeSheet.v2.Model.BLL.Skill();

                objAddSkill.SkillId = Convert.ToInt64(Request.QueryString["sid"]);
                objAddSkill.Name = txtname.Text;
                objAddSkill.IsActive = cbIsActive.Checked;

                objAddSkill.SkillInsert();
                Response.Redirect("ViewSkill.aspx");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void Cancel_Record_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSkill.aspx");
        }
    }
}