﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExercicioSlide
{
    class Exercicio1DoSlide_OperadoresAritimeticos
    {
        public static double a;
        static void Main111(string[] args)
        {
           int x,y,z;
           x = 7;
           y = 7;
                
          z = x + y;
          z = x - y;
          z = x / y;
          z = x * y;

          Math.Pow(x, y);
          Math.Sqrt(y);
          z =  x % y ;

         
            Console.WriteLine(1 + 2 + 3 + "AHAHAHAHA");
            Console.WriteLine("AHAHAHAHA" + 1 + 2 + 3);
             a = (double) 5 / 2;

             int valor = 1;
             valor += 2;
             valor -= 1;
             valor *= 6;
             valor /= 3;
             valor %= 3;
             valor++;
             valor--;
             a = 10;
             int i = 0;
             Console.WriteLine(a < 0 || i++ < 500);
             Console.WriteLine(a < 0 && i++ < 500);
             Console.WriteLine(a > 0 & i++ > 500);
             Console.WriteLine(a > 0 | i++ > 500);
        }
    }
}
