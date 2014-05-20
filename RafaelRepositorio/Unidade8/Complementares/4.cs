using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class _4
    {
        static void Main11(string[] args)
        {
            for (int j = 0; j <= 10; j++)
            {
                for (int i = 0; i <= 10; i++)
                {

                    int valor = 0; 
                    valor = j* i;
                    Console.WriteLine("Tabudada do:" + j + "*"+ i + "RESULTADO: "+ valor);              
                }
            }
        }
    }
}
