using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computan.TimeSheet.v2.Model.DAL
{
   public class Skill
    {
        public List<BLL.Skill> GetAllSkill()
        {
            List<BLL.Skill> skills = new List<BLL.Skill>();
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
                string storedProcedureName = "SkillsLoadAll";
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
                            BLL.Skill skill = new BLL.Skill
                            {
                                SkillId = (long)dr["SkillId"],
                                Name = dr["Name"].ToString(),
                                IsActive = Convert.ToBoolean(dr["IsActive"].ToString())
                                    
                                                                      
                            };
                            skills.Add(skill);
                        }
                    }
                }
                // return skills list.
                return skills;
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
        public BLL.Skill SkillsLoadSkillById(long SkillId)
        {
            BLL.Skill skills = new BLL.Skill();
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
                string storedProcedureName = "SkillsLoadBySkillId";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@SkillId", SkillId );
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    skills = new BLL.Skill
                    {
                        SkillId = (long)reader["SkillId"],
                        Name = reader["Name"].ToString(),
                        IsActive = Convert.ToBoolean(reader["IsActive"].ToString())
                        
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
            return skills;
        }
        public void SkillsInsert(BLL.Skill skill)
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
                string storedProcedureName = "SkillsInsert";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@SkillId", "0");               
                cmd.Parameters.AddWithValue("@Name", skill.Name);
                cmd.Parameters.AddWithValue("@IsActive", skill.IsActive);
              
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
        public void SkillsUpdate(BLL.Skill updateskill)
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
                string storedProcedureName = "SkillsUpdate";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;
                             
                cmd.Parameters.AddWithValue("@SkillId", updateskill.SkillId);
                cmd.Parameters.AddWithValue("@Name", updateskill.Name);
                cmd.Parameters.AddWithValue("@IsActive", updateskill.IsActive);

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
        public BLL.Skill SkillsDelete(long SkillId)
        {
            BLL.Skill skills = new BLL.Skill();
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
                string storedProcedureName = "SkillsDelete";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 50000;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                cmd.Parameters.AddWithValue("@SkillId", SkillId);
             int sc =  cmd.ExecuteNonQuery();
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
            return skills;
        }

    }
}
