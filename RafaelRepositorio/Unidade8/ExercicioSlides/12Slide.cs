using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExercicioSlides
{
    class _12Slide
    {
        public static Random Rand = new Random();
        static void Main111(string[] args)
        {
            int aux,soma,i;
            soma = 0;
            for(i = 1;i <= 5;i++){
             aux = Rand.Next(1, 7);
             soma = soma + aux;
             Console.WriteLine("Soma: " + soma);
             if (soma > 19)
             {
                 break;
             }
             else
             {
                 continue;
             }
            }
            if (soma > 19)
            {
                Console.WriteLine("Campeao: "+i);
            }
            else
                Console.WriteLine("Nao foi hj: "+soma);
        }
    }
}
