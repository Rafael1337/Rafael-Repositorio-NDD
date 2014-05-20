using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_9
{
    class _4
    {
       public static Random randi = new Random();
        static void Main111(string[] args)
        {
            int[] Numeros = new int[10];
            for (int i = 0; i < Numeros.Length; i++)
            {
                Numeros[i] = randi.Next(1, 100);
                if (Numeros[i] % 3 == 1)
                {
                    Console.WriteLine("Indice: " + i + "Valor: " + Numeros[i]);
                }
            }            
        }
    }
}
