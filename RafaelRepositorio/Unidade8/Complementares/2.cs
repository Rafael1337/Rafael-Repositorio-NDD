using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.Complementares
{
    class _2
    {
        public static string tamanho,tamanho2,tamanho3;
        public static int i, aux, g;
        public static void partebranca(int a)
        {
            for (i = 0; i < a; i++)
            {
                Console.Write(" ");
            }

        }
        public static void partebranca2(int b)
        {
            for (i = 0; i < b; i++)
            { 
                Console.Write(" ");
            }

        }

        public static void partebranca3(int c)
        {
            for (i = 0; i < c; i++)
            {
                Console.Write(" ");
            }

        }
        static void Main(string[] args)
        {
            aux = 0;
            i = 0;
            tamanho = "*******";
                tamanho2 = "   *******";
                tamanho3 = "       *******";
            while (i < 2)
            {
                {
                    for (g = 0; g <= 5; g++)
                    {
                        partebranca(aux);
                        Console.WriteLine(tamanho);
                        aux++;
                    }
                    for (g = 0; g <= 5; g++)
                    {
                        partebranca2(aux);
                        Console.WriteLine(tamanho2);
                        aux++;
                    }
                    for (g = 0; g <= 5; g++)
                    {
                        partebranca3(aux);
                        Console.WriteLine(tamanho3);
                        aux++;
                    }
                    aux = 0;
                    Console.WriteLine(" ");
                    i++;
                }
            }

        }
    }
}
