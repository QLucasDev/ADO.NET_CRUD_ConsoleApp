using System;
using System.Text;

namespace ADO.NET_CRUDConsoleApp
{
    internal class View
    {
        Query query = new Query();
        Connection conn = new Connection();
        StringBuilder sb = new StringBuilder();

        public void ReturnOptions()
        {
            string opc = Options();
            while (opc != "X")
            {

                switch (opc)
                {
                    case "1":
                        CallView();
                        break;
                    case "2":
                        CallAdd();
                        break;
                    case "3":
                        CallEdit();
                        break;
                    case "4":
                        CallDelete();
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
            Console.WriteLine("2 - Adicionar Produto");
            Console.WriteLine("3 - Editar Produto");
            Console.WriteLine("4 - Deletar Produto");
            Console.WriteLine("X - Sair");
            Console.Write("\t");

            string Option = Console.ReadLine().ToUpper();
            return Option;
        }

        public void CallView()
        {
            Console.Clear();
            query.View(conn.GetConn());
        }
        public void CallAdd()
        {
            Console.Clear();
            Console.Write("Digite o nome do produto: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("Digite o valor do produto: ");
            decimal price = PriceConverter();

            query.Add(conn.GetConn(), name, price);
        }

        public void CallEdit()
        {
            Console.Clear();
            Console.Write("Digite o ID do produto: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o novo nome do produto: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite o novo valor do produto: ");
            decimal price = PriceConverter();
            query.Edit(conn.GetConn(), name, price, id);
        }

        public void CallDelete()
        {
            Console.Clear();
            Console.Write("Digite o ID do produto: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.Write("TEM CERTEZA QUE DESEJA EXCLUIR ESTE ITEM? (S/N): ");
            string confirm = Console.ReadLine().ToUpper();

            if(confirm == "S")
            {
                query.Delete(conn.GetConn(), id);
            }
            else
            {
                return;
            }
        }

        //Corrige o Bug do serparador decimal
        public decimal PriceConverter()
        {
            string price = Console.ReadLine().Replace(".","");
            price.Replace(',', '.');
            decimal fPrice = decimal.Parse(price);
            return fPrice;
        }
    }
}
