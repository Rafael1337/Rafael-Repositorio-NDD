using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.ExerciciosComplementares
{
    class _4
    {
        public static int i;
      
        public static Random Rand = new Random();
        static void Main11(string[] args)
        {
            int[] vetor = new int[12];
            int[] vetor2 = new int[12];

            for (i = 0; i < vetor.Length; i++)
            {
                vetor[i] = Rand.Next(0, 10);
                Console.WriteLine("Valores do primeiro vetor: " + vetor[i]);
                              
            }
            Console.WriteLine("");
             for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == 0)
                {
                    vetor2[i] = 1;
                }
                else
                    vetor2[i] = vetor[i];
                
                Console.WriteLine("Valores do Segundo vetor: " + vetor2[i]);                             
            }
        }
    }
}
