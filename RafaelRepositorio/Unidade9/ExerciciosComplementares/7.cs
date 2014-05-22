using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.ExerciciosComplementares
{
    class _7
    {
        public static Random NumeroRandom = new Random();
        static void Main(string[] args)
        {

            int[] a = new int[50];
            int[] b = new int[50];
            int[] c = new int[50];
                for (int i = 49; i >= 0; i--)
                {
                    a[i] = i + 1;
                    a[i] = NumeroRandom.Next(1, 100);
                   

                    for (int j = 0; j < b.Length; j++)
                    {
                        b[j] = j + 1;
                        b[j] = NumeroRandom.Next(1, 100);
                        Console.WriteLine("Valores do indice: " + i + " de A: " + a[i]);
                        Console.WriteLine("Valores do indice: " + j + " de B: " + b[j]);

                       
                        c[i] = a[i] + b[j];
                        Console.WriteLine("SOMA: " + c[i]);
                       
                    }                
                }      
        }
    }
}
