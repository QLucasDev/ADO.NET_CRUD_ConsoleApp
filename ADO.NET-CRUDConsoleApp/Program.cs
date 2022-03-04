 using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_CRUDConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string cs = @"Data Source=LAPTOP-QF5TI23D\SQLEXPRESS;"
            //            + "Initial Catalog=PRODUTOS;"
            //            + "Integrated Security=True";

            //SqlConnection conn = new SqlConnection(cs);

            Connection connection = new Connection();
            Query query = new Query();

            try
            {
                connection.GetConn().Open();
                //query.View(connection.GetConn());
                //query.Add(connection.GetConn(), "Nave Epacial", 20.55M);
                //query.Delete(connection.GetConn(), 17);
                //query.Edit(connection.GetConn(), "MotoRC", 22.99M, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.GetConn().Close();
            }
        }
    }
}
