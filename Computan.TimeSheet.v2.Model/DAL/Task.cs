using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computan.TimeSheet.v2.Model.DAL
{
   public class Task
    {
        public List<BLL.Task> GetAllTask()
        {
            List<BLL.Task> tasks = new List<BLL.Task>();
            SqlConnection conn = null;
            SqlDataAdapter adapter = null;
            try
            {
                // prepare connection to the database.
                conn = SQLHelper.GetConnection();
                conn.Open();

                if (conn == null)
                {
                    throw new Exception("Sorry, connection to the database failed.");
                }

                // write sqlcommand.
                string storedProcedureName = "TasksLoadAll";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                //Prepare and Attach parameters here. (just sample)
                //SqlParameter param1 = new SqlParameter("@FirstName", "");
                //cmd.Parameters.Add(param1);         

                // fetch data from database.
                DataSet dsData = new DataSet();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dsData);

                // iterate all the fetched data and populate students objects.
                if (dsData != null)
                {
                    if (dsData.Tables.Count > 0)
                    {
                        foreach (DataRow dr in dsData.Tables[0].Rows)
                        {
                            BLL.Task task = new BLL.Task
                            {
                                TaskId = (long)dr["TaskId"],
                                ProjectId= (long)dr["ProjectId"],                             
                                SkillId = (long)dr["SkillId"],
                                TaskDate =Convert.ToDateTime(dr["TaskDate"]),
                                Title = Convert.ToString(dr["Title"]),
                                Details = Convert.ToString(dr["Details"]),
                                TimeInMinutes =Convert.ToInt32(dr["TimeInMinutes"]),
                                CreatedOnUTC = Convert.ToDateTime(dr["CreatedOnUTC"]),
                                UpdatedOnUTC = Convert.ToDateTime(dr["UpdatedOnUTC"]),
                                IpUsed = Convert.ToString(dr["IpUsed"]),
                                UserId = Convert.ToString(dr["UserId"]),

                               


                            };
                            tasks.Add(task);
                            
                        }
                    }
                }
                // return skills list.
                return tasks;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (adapter != null) adapter.Dispose();
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        public BLL.Task TasksLoadByTaskId(long taskid)
        {
            BLL.Task tasks = new BLL.Task();
            SqlConnection conn = null;
            SqlDataReader reader = null;
            try
            {
                // prepare connection to the database.
                conn = SQLHelper.GetConnection();
                conn.Open();
                if (conn == null)
                {
                    throw new Exception("Sorry, connection to the database failed.");
                }

                // write sqlcommand.
                string storedProcedureName = "TasksLoadByTaskId";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@TaskId", taskid);
                reader = cmd.ExecuteReader();
            
                if (reader.Read())
                {
                    tasks = new BLL.Task
                    {
                        TaskId = (long)reader["TaskId"],
                        ProjectId = (long)reader["ProjectId"],
                        SkillId = (long)reader["SkillId"],
                        TaskDate = Convert.ToDateTime(reader["TaskDate"]),
                        Title = Convert.ToString(reader["Title"]),
                        Details = Convert.ToString(reader["Details"]),
                        TimeInMinutes = Convert.ToInt32(reader["TimeInMinutes"]),
                        CreatedOnUTC = Convert.ToDateTime(reader["CreatedOnUTC"]),
                        UpdatedOnUTC = Convert.ToDateTime(reader["UpdatedOnUTC"]),
                        IpUsed = Convert.ToString(reader["IpUsed"]),
                        UserId = Convert.ToString(reader["UserId"]),

                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null) reader.Dispose();
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return tasks;
        }

        public void TaskInsert(BLL.Task task)
        {
            SqlConnection conn = null;
            try
            {
                // prepare connection to the database.
                conn = SQLHelper.GetConnection();
                conn.Open();
                if (conn == null)
                {
                    throw new Exception("Sorry, connection to the database failed.");
                }

                // write sqlcommand.
                string storedProcedureName = "TasksInsert";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@TaskId", "0");
                cmd.Parameters.AddWithValue("@ProjectId", task.ProjectId);
                cmd.Parameters.AddWithValue("@SkillId", task.SkillId);
                cmd.Parameters.AddWithValue("@TaskDate", task.TaskDate);
                cmd.Parameters.AddWithValue("@Title", task.Title);
                cmd.Parameters.AddWithValue("@Details", task.Details);
                cmd.Parameters.AddWithValue("@TimeInMinutes", task.TimeInMinutes);
                cmd.Parameters.AddWithValue("@CreatedOnUTC", task.CreatedOnUTC);
                cmd.Parameters.AddWithValue("@UpdatedOnUTC", task.UpdatedOnUTC);
                cmd.Parameters.AddWithValue("@IpUsed", task.IpUsed);
                cmd.Parameters.AddWithValue("@UserId", task.UserId);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }


        public void TasksUpdate(BLL.Task updatetask)
        {
            SqlConnection conn = null;
            try
            {
                // prepare connection to the database.
                conn = SQLHelper.GetConnection();
                conn.Open();
                if (conn == null)
                {
                    throw new Exception("Sorry, connection to the database failed.");
                }

                // write sqlcommand.
                string storedProcedureName = "TaskUpdates";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@TaskId", updatetask.TaskId);
                cmd.Parameters.AddWithValue("@ProjectId", updatetask.ProjectId);
                cmd.Parameters.AddWithValue("@SkillId", updatetask.SkillId);
                cmd.Parameters.AddWithValue("@TaskDate", updatetask.TaskDate);
                cmd.Parameters.AddWithValue("@Title", updatetask.Title);
                cmd.Parameters.AddWithValue("@Details", updatetask.Details);
                cmd.Parameters.AddWithValue("@TimeInMinutes", updatetask.TimeInMinutes);
                //cmd.Parameters.AddWithValue("@CreatedOnUTC", updatetask.CreatedOnUTC);
                cmd.Parameters.AddWithValue("@UpdatedOnUTC", updatetask.UpdatedOnUTC);
              //  cmd.Parameters.AddWithValue("@IpUsed", updatetask.IpUsed);
                //cmd.Parameters.AddWithValue("@UserId", updatetask.UserId);

                int success = cmd.ExecuteNonQuery();
                //return true; // success 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public BLL.Task TasksDelete(long taskid)
        {
            BLL.Task tasks = new BLL.Task();
            SqlConnection conn = null;
            SqlDataReader reader = null;
            try
            {
                // prepare connection to the database.
                conn = SQLHelper.GetConnection();
                conn.Open();
                if (conn == null)
                {
                    throw new Exception("Sorry, connection to the database failed.");
                }

                // write sqlcommand.
                string storedProcedureName = "TasksDelete";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@TaskId", taskid);
                int sc = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null) reader.Dispose();
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return tasks;
        }
    }
}
