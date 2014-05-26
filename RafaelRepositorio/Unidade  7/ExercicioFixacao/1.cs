using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade__7.ExercicioFixacao
{
    class _1
    {
        static void Main111(string[] args)
        {
            double produto;
            double ValorMaior = 0;
            double Valor;
            double valorTotal = 0;
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine("Informe o codigo do produto: ");
                produto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe o valor do produto: ");
                Valor = Convert.ToDouble(Console.ReadLine());
                valorTotal += Valor;
                if (ValorMaior < Valor)
                {
                    ValorMaior = Valor;
                }               
            }
            Console.WriteLine("O maior valor é : " + ValorMaior);
            Console.WriteLine("A média de valor é: " + valorTotal);
        }
    }
}
