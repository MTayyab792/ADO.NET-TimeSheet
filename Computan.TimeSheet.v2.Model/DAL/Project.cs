using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace Computan.TimeSheet.v2.Model.DAL
{
    public class Project
    {
        public List<BLL.Project> GetAllProject()
        {
            List<BLL.Project> projects = new List<BLL.Project>();
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
                string storedProcedureName = "ProjectsLoadAll";
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
                            BLL.Project project = new BLL.Project
                            {
                                ProjectId = (long)dr["ProjectId"],
                                Title = dr["Title"].ToString(),
                                Description = dr["Description"].ToString(),
                                IsActive = Convert.ToBoolean(dr["IsActive"].ToString()),
                                CreatedOn = Convert.ToDateTime(dr["CreatedOn"].ToString()),
                                LastUpdatedOn = Convert.ToDateTime(dr["LastUpdatedOn"].ToString()),
                                IpUsed =  Convert.ToString(dr["IpUsed"].ToString()),
                                UserId = Convert.ToString(dr["UserId"])
                            };
                            projects.Add(project);
                        }
                    }
                }
                // return project list.
                return projects;
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
        public BLL.Project LoadProjectById(long ProjectId)
        {
            BLL.Project project = new BLL.Project();
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
                string storedProcedureName = "ProjectLoadByProjecttId";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    project = new BLL.Project
                    {
                        ProjectId = (long)reader["ProjectId"],
                        Title = reader["Title"].ToString(),
                        Description = reader["Description"].ToString(),
                        IsActive = Convert.ToBoolean(reader["IsActive"].ToString()),
                        CreatedOn = Convert.ToDateTime(reader["CreatedOn"].ToString()),
                        LastUpdatedOn = Convert.ToDateTime(reader["LastUpdatedOn"].ToString()),
                        IpUsed = project.IpUsed, /*Convert.ToDateTime(reader["IpUsed"].ToString()),*/
                        UserId = Convert.ToString(reader["UserId"])
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
            return project;
        }



        
        
        public void ProjectInsert(BLL.Project project)
        {
            //textBox1.Text = "Computer Name: " + Environment.MachineName



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
                string storedProcedureName = "ProjectsInsert";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@ProductId", "0");      
                cmd.Parameters.AddWithValue("@Title", project.Title);
                cmd.Parameters.AddWithValue("@Description", project.Description);
                cmd.Parameters.AddWithValue("@IsActive", project.IsActive);
                cmd.Parameters.AddWithValue("@CreatedOn", project.CreatedOn);
                cmd.Parameters.AddWithValue("@LastUpdatedOn", project.LastUpdatedOn);
                cmd.Parameters.AddWithValue("@IpUsed", project.IpUsed);
                cmd.Parameters.AddWithValue("@UserId", project.UserId);

             int sc =  cmd.ExecuteNonQuery();
                
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
        public void ProjectUpdate(BLL.Project updateProject)
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
                string storedProcedureName = "ProjectsUpdate";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@ProjectId", updateProject.ProjectId);
                cmd.Parameters.AddWithValue("@Title", updateProject.Title);
                cmd.Parameters.AddWithValue("@Description", updateProject.Description);
                cmd.Parameters.AddWithValue("@IsActive", updateProject.IsActive);
                //cmd.Parameters.AddWithValue("@CreatedOn", updateProject.CreatedOn);
                cmd.Parameters.AddWithValue("@LastUpdatedOn", updateProject.LastUpdatedOn);
                //cmd.Parameters.AddWithValue("@IpUsed", updateProject.IpUsed);
                //cmd.Parameters.AddWithValue("@UserId", updateProject.UserId);

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
        public BLL.Project ProjectDelete(long ProjectId)
        {
            BLL.Project project = new BLL.Project();
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
                string storedProcedureName = "ProjectsDelete";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
                cmd.ExecuteNonQuery();
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
            return project;
        }

    }
}
