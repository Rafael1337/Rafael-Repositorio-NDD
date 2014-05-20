using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_9
{
    class _6
    {
        public static Random randi = new Random();
        static void Main11(string[] args)
        {
            
            int[,] Numeros = new int[4,4];
            for (int i = 0; i <= 4; i++)
            {                
                for (int j = 0; j <= 4; j++)
                {
                    Numeros[i, j] = randi.Next(1, 100);
                    Console.WriteLine("Valores: "+ Numeros[i,j]);
                }
                Console.WriteLine("Indice i: ");
            }
        }
    }
}
