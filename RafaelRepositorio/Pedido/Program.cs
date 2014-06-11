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

            //    //SqlCommand command = new SqlCommand("SELECT * FROM Produto", sqlConnection);

            //    //SqlDataReader reader = command.ExecuteReader();

            ////    while(reader.Read()){
            ////        Console.WriteLine(reader["Nome"]);
            ////    }
            //    Console.WriteLine("Digite a id do produto a ser editado: ");
            //    int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digita o nome produto: ");
            //string nome = Console.ReadLine();
            //string splitupdate = String.Format("UPDATE Produto SET Nome = '{0}' WHERE ID = {1}",nome,id);
            //SqlCommand comand = new SqlCommand(splitupdate,sqlConnection);

            //    try
            //    {
            //        int i = comand.ExecuteNonQuery();
            //if (i > 0)
            //{
            //    Console.WriteLine("Produto deletado com sucesso! ");
            //}
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.ToString());
            //    }

            ////INSERIR PRODUTO


            //INSERIR CLIENTE
            int opc = 0;
            Console.WriteLine("1 - CADASTRAR PRODUTO");
            Console.WriteLine("2 - CADASTRAR CLIENTE");
            Console.WriteLine("0 - SAIR - END");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Informe a quantidade de produtos: ");
                    int prodQuant = Convert.ToInt32(Console.ReadLine());
                    int p = 0;
                    do
                    {
                        Console.WriteLine("Digite o nome do produto: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o valor da unidade: ");
                        string unidade = Console.ReadLine();
                        Console.WriteLine("Digite o valor do produto: ");
                        double valor = Convert.ToDouble(Console.ReadLine());

                        string sqlInsert = String.Format("INSERT INTO Produto (Nome, Unidade, Valor) VALUES ('{0}','{1}','{2}') ", nome, unidade, valor);
                        SqlCommand command = new SqlCommand(sqlInsert, sqlConnection);

                        try
                        {
                            int j = command.ExecuteNonQuery();
                            if (j > 0)
                            {
                                Console.WriteLine("Produto inserido com sucesso! ");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        } p++;
                    } while (p >= prodQuant);
                    break;
                case 2:
                    Console.WriteLine("Informe a quantidade de cliente: ");
                    int Cliente = Convert.ToInt32(Console.ReadLine());
                    int i = 0;
                    do
                    {
                        Console.WriteLine("Digite o nome do cliente: ");
                        string nomeCliente = Console.ReadLine();
                        Console.WriteLine("Informe o sobre nome do cliente: ");
                        string SobreNome = Console.ReadLine();
                        Console.WriteLine("Informe o telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe o CPF: ");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Informe a CIDADE: ");
                        string cidade = Console.ReadLine();
                        Console.WriteLine("Estado: ");
                        string estado = Console.ReadLine();
                        Console.WriteLine("Informe o CEP: ");
                        string cep = Console.ReadLine();

                        string sqlInsertClient = String.Format("INSERT INTO Cliente(Nome,Sobrenome,telefone,cpf,cidade,estado,cep) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", nomeCliente, SobreNome, telefone, cpf, cidade, estado, cep);
                        SqlCommand command = new SqlCommand(sqlInsertClient, sqlConnection);
                        try
                        {
                            int j = command.ExecuteNonQuery();
                            if (j > 0)
                            {
                                Console.WriteLine("Cliente cadastrado");
                            }
                        }
                        catch (Exception g)
                        {
                            Console.WriteLine(g.ToString());
                        }

                        i++;

                    } while (i >= Cliente);
                    break;
            }
        }
    }
}

