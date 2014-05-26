using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade__7.ExercicioFixacao
{
    class _3
    {
        static void Main3113(string[] args)
        {
            int opc;
            int qtProdutos = 0;
            string nome;
            double valorProd;
            double mediaProd = 0;
            double valortotal = 0;
            do
            {
                Console.WriteLine("PRODUTOS - 1");
                Console.WriteLine("SAIR - 0");
                opc = Convert.ToInt32(Console.ReadLine());
                
                switch (opc) {
                    case 1:
                Console.WriteLine("Informe Quantidade produtos no estoque");
                qtProdutos = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                do{
                    Console.WriteLine("Informe o produto: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Informe o valor do produto: ");
                    valorProd = Convert.ToDouble(Console.ReadLine());
                    valortotal += valorProd;
                    mediaProd += valorProd/qtProdutos;
                                        
                    i++;
                }while(i < qtProdutos);
                Console.WriteLine("Valor total em estoque: " + valortotal);
                Console.WriteLine("Media de valor dos produtos: " + mediaProd);
                    break;
                    default:
                Console.WriteLine("Saiu");
                break;
                }
            } while (opc == 0);
        }
    }
}
