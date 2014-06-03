using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.ExercicioFixacao
{
    class AcharMaiorElemento
    {
        public static Random Rand = new Random();
        static void Main31(string[] args)
        {
            int[] Nums = new int[20];
            int maior = 0;
            int menor = 0;
            for (int i = 1; i < 20; i++)
            {
                Nums[i] = Rand.Next(1, 100);
                if (Nums[i] > maior)
                {
                    maior = Nums[i];
                    Console.WriteLine("Maior numero: " + maior);
                }
                if (Nums[i] < menor)
                {
                    menor = Nums[i];
                    Console.WriteLine("Menor numero: " + menor);
                }
            }
        }
    }
}
