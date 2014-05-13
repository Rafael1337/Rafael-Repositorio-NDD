using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExercicioSlides
{
    class _1
    {
        public static Random RandNum = new Random();
        public static double Nota;
         static void Main111(string[] args)
        {
            Nota = RandNum.NextDouble() * 10;
            if (Nota > 7)
            {
                Console.Write("Aprovado");
            }else
                if (Nota < 7)
                {
                    Console.Write("Reprovado");
                }
        }
    }
}
