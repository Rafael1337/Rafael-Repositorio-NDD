using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aluno\Source\Repos\Rafael-Repositorio-NDD\RafaelRepositorio\Unidade12\BD\RafaelDB.mdf;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionstring);

            sqlConnection.Open();

            //SqlCommand command = new SqlCommand("SELECT * FROM Produto", sqlConnection);

            //SqlDataReader reader = command.ExecuteReader();

        //    while(reader.Read()){
        //        Console.WriteLine(reader["Nome"]);
        //    }
        Console.WriteLine("Digita o nome produto: ");
        string nome = Console.ReadLine();
        string splitupdate = String.Format("UPDATE Produto SET Nome = '(0)' WHERE ID = (1)");
        SqlCommand comand = new SqlCommand(splitupdate,sqlConnection);
            
            try
            {
                int i = comand.ExecuteNonQuery();
                Console.WriteLine("Produto atualizado com sucesso! ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

           
        
        
        }
    }
}
