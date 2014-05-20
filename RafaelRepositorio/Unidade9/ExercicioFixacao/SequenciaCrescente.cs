using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.Arrays
{
    class SequenciaCrescente
    {
        public static Random RandNum = new Random();
        static void Main11(string[] args)
        {

            int[] vet = new int[10];

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = i + 1;
                Console.WriteLine(i +" "+ vet[i]);
            }
        }
    }
}
