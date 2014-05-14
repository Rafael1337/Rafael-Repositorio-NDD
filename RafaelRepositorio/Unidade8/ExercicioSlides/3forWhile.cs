using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExercicioSlides
{
    class _3forWhile
    {
        static void Main111(string[] args)
        {
            int x = 1;
            do
            {
                if (x % 3 != 0)
                {
                    Console.WriteLine(x);
                }
                x++;

            } while (x <= 100);
        }

    }
}