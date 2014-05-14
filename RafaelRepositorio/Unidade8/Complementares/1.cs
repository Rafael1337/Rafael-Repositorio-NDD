using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.Complementares
{
    class _1
    {
        public static Random Rand = new Random();
        static void Main11(string[] args)
        {
            int a, b;
            a = Rand.Next(1,100);
            b = Rand.Next(1,100);
            Console.WriteLine("numero A: " + a);
            Console.WriteLine("numero B: " + b);
            if (a > b)
            {
                Console.WriteLine("PRIMEIRO: " + a + " > " + " SEGUNDO: " + b);
            }
            else
                if (a == b)
                {
                    Console.WriteLine("PRIMEIRO: "+ a + " = " + "SEGUNDO : " + b);
                }
                else
                    Console.WriteLine("SEGUNDO: " + b +" > " + " PRIMEIRO: " + a);
        }
    }
}
