using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Connection
    {
        private readonly string connectionString;

        public Connection()
        {
            connectionString = @"Server=DESKTOP-JNLM84J\SQLEXPRESS; DataBase=dbFinan; Integrated Security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
