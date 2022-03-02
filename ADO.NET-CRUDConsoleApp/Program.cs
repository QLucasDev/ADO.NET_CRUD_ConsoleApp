 using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_CRUDConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cs = @"Data Source=LAPTOP-QF5TI23D\SQLEXPRESS;"
                        + "Initial Catalog=PRODUTOS;"
                        + "Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);
            Query query = new Query();

            try
            {
                conn.Open();
                //query.View(conn);
                //query.Add(conn, "Nave Epacial", 20.55M);
                //query.Delete(conn, 17);
                //query.Edit(conn, "MotoRC", 22.99M, 10);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
