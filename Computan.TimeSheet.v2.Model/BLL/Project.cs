using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Xml.Serialization;

namespace Computan.TimeSheet.v2.Model.BLL
{
    public  class Project
    {
        DAL.Project objDal = new DAL.Project();
        public long ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime  CreatedOn { get; set ; }
        public DateTime LastUpdatedOn { get; set; }
        public string IpUsed { get; set; }
        public string UserId { get; set; }


        public List<BLL.Project> GetAllProject()
        {
            try
            {
                return objDal.GetAllProject();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ProjectInsert()
        {

            try
            {
                objDal.ProjectInsert(this);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public BLL.Project LoadProjectById(long ProjectId)
        {
            try
            {
                return objDal.LoadProjectById(ProjectId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void ProjectUpdate()
        {

            try
            {
                objDal.ProjectUpdate(this);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public BLL.Project ProjectDelete(long ProjectId)
        {
            try
            {
                return objDal.ProjectDelete(ProjectId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
