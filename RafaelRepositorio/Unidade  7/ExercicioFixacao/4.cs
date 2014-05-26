using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade__7.ExercicioFixacao
{
    class _4
    {
        static void Main13(string[] args)
        {
            int valor = 0;

            do
            {
                Console.Write("Informe o número máximo: ");
                valor = int.Parse(Console.ReadLine());

               if(valor % 2 == 0){
                   Console.WriteLine("insira um valor impar");
               }else
                   Console.WriteLine(" \n");
            } while (valor % 2 == 0);

            int b = (valor - 1) / 2;

            for (int i = 0; i <= (valor / 2) + 1; i++)
            {
                for (int j = i + 1; j <= valor - i; j++)
                {
                    Console.Write(" "+ j);
                }

                Console.Write("\n");

                for (int j = 0; j < (i + 1) * 2; j++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
  