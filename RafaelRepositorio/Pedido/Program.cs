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

        private static void C_AdicionaPedido(SqlConnection sqlConection)
        {
            var dataPedido = DateTime.Now;
            Console.WriteLine("Digite a quantidade de produtos:");
            var quantidade = int.Parse(Console.ReadLine());
            int produtoId = 8;// fazer um lógica de busca
            int clienteId = 1;// fazer um lógica de busca

            string sql = String.Format(@"INSERT INTO Pedido (DataPedido, Quantidade," +
       "Produto_Id, Cliente_Id) VALUES('{0}', {1}, {2}, {3})", dataPedido, quantidade, produtoId, clienteId);

            SqlCommand insert = new SqlCommand(sql, sqlConection);

            try
            {
                int i = insert.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Cadastro inserido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString()); // Irá mostrar para nós a exceção
            }


        }

        private static void R_ListaTodosPedidos(SqlConnection sqlConection)
        {
            //Listando todos o intens na tabela pedidos
            SqlCommand select = new SqlCommand(@"SELECT P.Nome, C.PrimeiroNome, PD.DataPedido, PD.Quantidade " +
                                               "FROM Pedido AS PD " +
                                               "INNER JOIN Cliente AS C ON PD.Cliente_Id = C.Id " +
                                               "INNER JOIN Produto AS P ON PD.Produto_Id = P.Id", sqlConection);
            SqlDataReader dataReader = select.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine("Data de Hoje:" + dataReader["DataPedido"]);
                Console.WriteLine("Quantidade:" + dataReader["Quantidade"]);
                Console.WriteLine("Produto:" + dataReader["Nome"]);
                Console.WriteLine("Cliente:" + dataReader["PrimeiroNome"]);
            }
        }

        private static void U_AtualizaPedidos(SqlConnection sqlConection)
        {
            //Executa a consulta e não retorna nenhuma coleção. Usado para instruções DELETE e UPDATE onde retorna o número de registros afetados.
            SqlCommand update = new SqlCommand("Update Pedido set DataPedido = '01-01-01' WHERE Id = 2", sqlConection);

            try
            {
                int j = update.ExecuteNonQuery();
                if (j > 0)
                {
                    Console.WriteLine("Cadastro atualizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString()); // Irá mostrar para nós a exceção
            }
        }

        private static void D_ExcluiPedidos(SqlConnection sqlConection)
        {
            //Executa a consulta e não retorna nenhuma coleção. Usado para instruções DELETE e UPDATE onde retorna o número de registros afetados.
            SqlCommand delete = new SqlCommand("DELETE FROM Pedido WHERE Id=1", sqlConection);
            delete.ExecuteNonQuery();
        }
        private static void C_AdicionaProduto(SqlConnection sqlConection)
        {
            string nome = Console.ReadLine();
            string unidade = Console.ReadLine();
            double valor = Convert.ToDouble(Console.ReadLine());
            string nvalor = valor.ToString().Replace(',', '.');


            //Inserindo intens na tabela produto
            string sql = String.Format(@"INSERT INTO Produto (Nome, Unidade, Valor) VALUES('{0}','{1}',{2:.##})", nome,
                unidade, nvalor);
            SqlCommand insert = new SqlCommand(sql, sqlConection);

            try
            {
                int i = insert.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Cadastro inserido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString()); // Irá mostrar para nós a exceção
            }
        }

        private static void R_ListaTodosProdutos(SqlConnection sqlConection)
        {
            //Listando todos o intens na tabela produto
            SqlCommand select = new SqlCommand(@"SELECT * FROM Produto", sqlConection);
            SqlDataReader dataReader = select.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine(dataReader["Nome"]);
            }
        }

        private static void U_AtualizaProduto(SqlConnection sqlConection)
        {
            //Executa a consulta e não retorna nenhuma coleção. Usado para instruções DELETE e UPDATE onde retorna o número de registros afetados.
            SqlCommand update = new SqlCommand("Update Produto set Nome = 'Melancia' WHERE Id=2", sqlConection);

            try
            {
                int j = update.ExecuteNonQuery();
                if (j > 0)
                {
                    Console.WriteLine("Cadastro atualizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString()); // Irá mostrar para nós a exceção
            }
        }

        private static void D_ExcluiProduto(SqlConnection sqlConection)
        {
            //Executa a consulta e não retorna nenhuma coleção. Usado para instruções DELETE e UPDATE onde retorna o número de registros afetados.
            SqlCommand delete = new SqlCommand("DELETE FROM Produto WHERE Id=1", sqlConection);
            delete.ExecuteNonQuery();
        }

        private static void FechaConexao(SqlConnection sqlConection)
        {
            //Fecha a conexão
            sqlConection.Close();
        }

        private static SqlConnection ConectandoComBanco()
        {
            //Define uma string de conexão com o banco de dados CursoNDD.mdf
            string connectionString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Thiago\Source\Repos\CursoNDDigital\CursoNDDigital\UNIDADE XII\Banco\CursoDB.mdf;Integrated Security=True";

            //Cria um novo objeto SqlConnection object usando a string de conexão
            SqlConnection sqlConn = new SqlConnection(connectionString);

            //Abre a conexão
            sqlConn.Open();
            return sqlConn;
        }
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

