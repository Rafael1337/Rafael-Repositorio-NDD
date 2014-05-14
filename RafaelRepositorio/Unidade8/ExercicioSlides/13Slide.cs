using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExercicioSlides
{
    class _13Slide
    {
        public static int soma;
       public static Random RandNum = new Random();
        static void Main11 (string[] args)
        {
            
            for (int i = 0; i <= 4; i++)
            {
                int l = RandNum.Next(1, 7);
                if (l % 3 != 0)
                {
                    soma = soma + l;
                    continue;
                   // Console.WriteLine("Soma"+ soma);
                }
                else
                    Console.WriteLine("é par"+l);
            }
        }
    }
}
