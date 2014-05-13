using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExercicioSlides
{
    
    class _3
    {
        public static double valor;
        public static Random RandNum = new Random();
        static void Main111(string[] args)
        {
            valor = RandNum.NextDouble() * 10;
            if (valor > 0.5)
            {
                Console.Write("Siga a direita");
            }
            else
                Console.Write("Siga a esquerda");
        }
    }
}
