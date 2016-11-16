using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computan.TimeSheet.v2.Model.BLL
{
  public  class Skill
    {
        DAL.Skill objDal = new DAL.Skill();
        public long SkillId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }


        public List<BLL.Skill> GetAllSkill()
        {
            try
            {
                return objDal.GetAllSkill();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void SkillInsert()
        {

            try
            {
                objDal.SkillsInsert(this);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public BLL.Skill SkillsLoadSkillById(long SkillId)
        {
            try
            {
                return objDal.SkillsLoadSkillById(SkillId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void SkillsUpdate()
        {

            try
            {
                objDal.SkillsUpdate(this);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public BLL.Skill SkillsDelete(long SkillId)
        {
            try
            {
                return objDal.SkillsDelete(SkillId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
