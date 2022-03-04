using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_CRUDConsoleApp
{
    internal class Query
    {
        public void View(SqlConnection Conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM TB_PRODUTO";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conn;

            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dataSet);

            Console.WriteLine("Total de: {0} registros", dataSet.Tables[0].Rows.Count);

            foreach(DataRow obj in dataSet.Tables[0].Rows)
            {
                Console.WriteLine("ID: {0} - Nome: {1} - Preço: {2}", obj["ID"], obj["NOME"], obj["PRECO"]);
            }
            
        }

        public void Add(SqlConnection Conn, string name, decimal price)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO TB_PRODUTO (NOME, PRECO) VALUES (@name, @price)";
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@price", price));

            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conn;

            int nroReg = cmd.ExecuteNonQuery();

            Console.WriteLine("{0} Registro(s) Inserido(s)", nroReg.ToString());
        }

        public void Delete(SqlConnection Conn, int ID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM TB_PRODUTO WHERE ID = @ID";
            cmd.Parameters.Add(new SqlParameter("@ID", ID));

            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conn;

            int nroReg = cmd.ExecuteNonQuery();

            Console.WriteLine("{0} Registro(s) Deletados(s)", nroReg.ToString());
        }

        public void Edit(SqlConnection Conn, string name, decimal price, int ID)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE TB_PRODUTO SET NOME = @name, PRECO = @price WHERE ID = @id";

            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter ("@price", price));
            cmd.Parameters.Add(new SqlParameter("@id", ID));

            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conn;

            int nroReg = cmd.ExecuteNonQuery();

            Console.WriteLine("{0} Registro(s) Alterados(s)", nroReg.ToString());
        }
    }
}
