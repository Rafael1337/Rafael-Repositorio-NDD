﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExercicioSlides
{
    class _2
    {
        public static double valor;
        public static Random RandNum = new Random();
        static void Main11(string[] args)
        {
            valor = RandNum.NextDouble() * 10;
            if (valor >= 0.5)
            {
                Console.Write("È CARO");
            }else
                {

                    Console.Write("baratin");
                }
        }
    }
}
