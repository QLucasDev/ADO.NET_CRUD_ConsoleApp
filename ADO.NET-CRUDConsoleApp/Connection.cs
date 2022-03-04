using System;
using System.Data.SqlClient;

namespace ADO.NET_CRUDConsoleApp
{
    internal class Connection
    {
        
        public SqlConnection GetConn()
        {
            string cs = @"Data Source=LAPTOP-QF5TI23D\SQLEXPRESS;"
                           + "Initial Catalog=PRODUTOS;"
                           + "Integrated Security=True";
            SqlConnection Conn = new SqlConnection(cs);
            
            Conn.Open();

            return Conn;
        }
    }
}
