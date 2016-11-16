using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computan.TimeSheet.v2.Model.DAL
{
    public static class SQLHelper
    {
        public static SqlConnection GetConnection()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return new SqlConnection(connectionstring);
        }
    }
}
