using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8
{
    class _5
    {
        
        public static Random RandNum = new Random();
        static void Main241(string[] args)
        {
          
            int a = RandNum.Next(0,1000);
            int b = RandNum.Next(0,1000);
            if (a % b == 0)
            {
                Console.Write(" " + a);
                Console.WriteLine(" " + b);
                Console.WriteLine("é divisivel");
            }
            else
                Console.Write(" " + a);
                Console.WriteLine(" " + b);
                Console.WriteLine("Nao é divisivel");
        }
    }
}
