using System;
using System.Data.SqlClient;

namespace ADO.NET_CRUDConsoleApp
{
    internal class View
    {
        Query query = new Query();
        Connection conn = new Connection();

        public void ReturnOptions()
        {
            string opc = Options();
            while (opc != "X")
            {

                switch (opc)
                {
                    case "1":
                        query.View(conn.GetConn());
                        break;
                    case "2":
                        //CallAdd();
                        break;
                    case "3":
                        //CallEdit();
                        break;
                    case "4":
                        //CallDelete();
                        break;
                    default:
                        throw new ArgumentException("\tDigite um valor válido!!!");
                }


                opc = Options();
            }
        }
        public string Options()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar Produtos");
            Console.WriteLine("2 - Adicionar Produuto");
            Console.WriteLine("3 - Editar Produto");
            Console.WriteLine("4 - Deletar Produto");
            Console.WriteLine("X - Sair");
            Console.Write("\t");

            string Option = Console.ReadLine().ToUpper();
            return Option;
        }
        public void CallAdd()
        {

        }
    }
}
