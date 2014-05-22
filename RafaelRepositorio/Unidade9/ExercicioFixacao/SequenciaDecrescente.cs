using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.Arrays
{
    class SequenciaDecrescente
    {
        public static Random rand = new Random();
        static void Main31(string[] args)
        {
            int[] vet = new int[10];

            for (int i = 9; i >= 0; i--)
            {
                vet[i] = i + 1;
                vet[i] = rand.Next(1, 100);

                Console.WriteLine(i + " " + vet[i]);
            }
        }
    }
}
