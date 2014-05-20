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
        static void Main(string[] args)
        {

            int[] Numeros;
            Numeros = new int[10];
            
            for (int i = 0; i < Numeros.Length; i++)
            {
                Numeros[i] = RandNum.Next(1, 10);
                if (i != 0)
                {
                    if (Numeros[i] > Numeros[i - 1])
                    {
                        Console.WriteLine(Numeros[i]);
                    }
                    continue;
                    
                }
            }
        }
    }
}
