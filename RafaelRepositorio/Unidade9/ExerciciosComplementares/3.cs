using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.ExerciciosComplementares
{
    class _3
    {
        public static int maior;
        public static Random Rand = new Random();
        static void Main11(string[] args)
        {
            int[] vetor = new int[7];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i] = Rand.Next(1, 100));
                if (vetor[i] > vetor[0])
                {                    
                    maior = vetor[i];                   
                }
                
            }
            Console.WriteLine("Maior valor: " + maior);
        }
    }
}
