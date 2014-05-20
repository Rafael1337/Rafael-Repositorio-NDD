using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class _5
    {
        public static int n,i;
        public static Random RandNum = new Random();
        static void Main11(string[] args)
        {
            for (i = 0; i <= 10; i++)
            {                
                n = RandNum.Next(1, 6);
                if (n == 6)
                {
                    int y = 0;
                    y = y + 1;
                    if (y == 2)
                    {
                        Console.WriteLine("Você perdeu 2x o 6");
                        break;
                    }
                    else{
                        continue;
                    }
                }
                n += n;
            }
            if (i == 10)
            {
                int x = n % 3;
                Console.WriteLine("Você ganhou");
            }
            else
            {
                Console.WriteLine("Você perdeu");
            }
            }
        }
    }

