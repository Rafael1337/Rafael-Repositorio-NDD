using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementares6
{
    class Complementares6Exe9
    {
        public static string t, contarLetras;
        public static int variosFuros, aux;


        public static void ContadorDeBuracos()
        {
            Console.WriteLine("Informe o fucking texto: ");
            t = Console.ReadLine();
            buracos();
            Console.WriteLine("Teus furos são esses: " + aux, t);

        }
        public static void buracos()
        {
            var l = contarLetras.ToCharArray();

            for (int i = 0; i < contarLetras.Length; i++)
            {
                switch (contarLetras[i])
                {
                    case 'q':
                    case 'r':
                    case 'o':
                    case 'p':
                    case 'a':
                    case 'd':
                    case 'Q':
                    case 'R':
                    case 'O':
                    case 'P':
                    case 'A':
                    case 'D':
                        aux += 1;
                        break;
                    case 'b':
                    case 'B':
                        aux += 2;
                        break;
                    default:
                        Console.WriteLine("flw");
                        break;

                }
            }
        }

        static void Main11(string[] args)
        {
            ContadorDeBuracos();
            buracos();

        }
    }
}
