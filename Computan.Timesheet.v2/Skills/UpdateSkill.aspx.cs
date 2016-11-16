using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Computan.TimeSheet.v2.Model;

namespace Computan.Timesheet.v2.Skills
{
    public partial class UpdateSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    if (!String.IsNullOrEmpty(Request.QueryString["sid"]))
                    {
                        Int64 sid = Convert.ToInt32(Request.QueryString["sid"].ToString());
                        TimeSheet.v2.Model.BLL.Skill objSkill = new TimeSheet.v2.Model.BLL.Skill().SkillsLoadSkillById(sid);

                        txtname.Text = objSkill.Name;
                        cbIsActive.Checked = objSkill.IsActive;
                    }
                }
            }
            catch (NullReferenceException ex)
            {

                throw ex;
            }
        }

        protected void Update_Skill_Click(object sender, EventArgs e)
        {

            try
            {
                Computan.TimeSheet.v2.Model.BLL.Skill objAddSkill = new Computan.TimeSheet.v2.Model.BLL.Skill();

                objAddSkill.SkillId = Convert.ToInt64(Request.QueryString["sid"]);
                objAddSkill.Name = txtname.Text;
                //objAddSkill.IsActive = Convert.ToBoolean(cbIsActive.Text);
                objAddSkill.IsActive = cbIsActive.Checked;

           
                objAddSkill.SkillsUpdate();
                Response.Redirect("ViewSkill.aspx");
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
                Response.Redirect("ViewSkill.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}