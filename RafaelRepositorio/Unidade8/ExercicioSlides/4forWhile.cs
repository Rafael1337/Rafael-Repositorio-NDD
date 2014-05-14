using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExercicioSlides
{
    class _4forWhile
    {
        static void Main11(string[] args)
        {
            Console.Write("Informe um valor a ser divido pelo maior valor inteiro do visual studio: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int v = 2147483647;
            do
            {
                v /= 2;
                int h = v /= y;
                Console.WriteLine("Com o valor informado: "+h);
                Console.WriteLine("Dividido por 2: "+v);
            } while (v >= 100);
        }
    }
}
