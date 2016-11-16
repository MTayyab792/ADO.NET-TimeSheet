using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computan.TimeSheet.v2.Model.BLL
{
  public class Task
    {
        DAL.Task objDal = new DAL.Task();
        public long TaskId { get; set; }
        public long ProjectId { get; set; }
        public long SkillId { get; set; }
        public DateTime TaskDate { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int TimeInMinutes { get; set; }
        public DateTime CreatedOnUTC { get; set; }
        public DateTime UpdatedOnUTC { get; set; }
        public string  IpUsed { get; set; }
        public string UserId { get; set; }



        public List<BLL.Task> GetAllTask()
        {
            try
            {
                return objDal.GetAllTask();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void TasksInsert()
        {

            try
            {
                objDal.TaskInsert(this);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public BLL.Task TasksLoadByTaskId(long taskid)
        {
            try
            {
                return objDal.TasksLoadByTaskId(taskid);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void TasksUpdate()
        {

            try
            {
                objDal.TasksUpdate(this);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public BLL.Task TasksDelete(long taskid)
        {
            try
            {
                return objDal.TasksDelete(taskid);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
