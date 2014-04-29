using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Complementar6Exe1
    {
        public static int qt_maca;
        public static double resp;
        public static void Frutaria()
        {
            Console.Write("Informe a quantidade de maças que deseja comprar: ");
            qt_maca = Convert.ToInt32(Console.ReadLine());

            if (qt_maca < 12 && qt_maca >= 1)
            {
                resp = qt_maca * 0.30;
                Console.WriteLine("Valor: " + resp);
            }
            else
                if (qt_maca >= 12)
                {
                    resp = qt_maca * 0.25;
                    Console.WriteLine("Valor: " + resp);
                }
                else
                    Console.Write("valor invalido");
                    Console.Write("ENCERRANDO");
        }
        static void Main421(string[] args)
        {
            Frutaria();
        }
    }
}
