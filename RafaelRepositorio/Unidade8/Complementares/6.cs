using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class _6
    {
        public static int y;
        public static Random RandNum = new Random();
        static void Main11(string[] args)
        {
            int rand = RandNum.Next(1, 100);
            int aux = 0;

            var y = rand.ToString().ToCharArray();
            Console.WriteLine("Valor sorteado: " + rand);
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] == '1')
                    aux++;
            }
            Console.WriteLine("Quantidade de 1: " + aux);
        }        
    }
}
