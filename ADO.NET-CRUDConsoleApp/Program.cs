using System;
using System.Data.SqlClient;

namespace ADO.NET_CRUDConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //As linhas comentadas são usadas apenas para testes


            //Instancia da Query
            Query query = new Query();

            View view = new View();
            Connection connection = new Connection();

            try
            {
                //Por motivos de bug, a conexão é aberta dentro do método..
                connection.GetConn();

                //Instancia dos métodos...
                //query.View(connection.GetConn());
                //query.Add(connection.GetConn(), "Cachorro de pelucia", 20.55M);
                //query.Delete(connection.GetConn(), 17);
                //query.Edit(connection.GetConn(), "MotoRC", 22.99M, 10);

                view.ReturnOptions();
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
