using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10.ExercicioComplementares
{
    class Datas_Meses
    {
        public static void Datas(int dia, int mes, int ano)
        {
            Console.WriteLine("Informe dia,mes e ano (MESES INICIADOS COM 0 QUANDO MENORES QUE 10 )");
            Console.WriteLine("Informe o dia: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o ano: ");
            ano = Convert.ToInt32(Console.ReadLine());

            if (ano % 4 == 0 || ano % 400 == 0)
            {
                Console.WriteLine("Ano é bissexto");
                if (mes == 01 || mes == 03 || mes == 05 || mes == 07 || mes == 08 || mes == 10 || mes == 12 && dia < 31)
                {
                    Console.WriteLine("Dia invalido");
                } if (mes == 04 || mes == 06 || mes == 9 || mes == 11 && dia < 30 || dia > 30)
                {
                    Console.WriteLine("Dia invalido");
                } if (mes == 02 && dia < 29 || dia > 29)
                {
                    Console.WriteLine("Dia invalido");
                }
            }
            else           
            {
                Console.WriteLine("Ano não é bissexto");
                if (mes == 01 || mes == 03 || mes == 05 || mes == 07 || mes == 08 || mes == 10 || mes == 12 && dia < 31)
                {
                    Console.WriteLine("Dia invalido");
                } if (mes == 04 || mes == 06 || mes == 9 || mes == 11 && dia < 30 || dia > 30)
                {
                    Console.WriteLine("Dia invalido");
                } if (mes == 02 && dia < 28 || dia > 28)
                {
                    Console.WriteLine("Dia invalido");
                }
            }
        }
        static void Main(string[] args)
        {
            int dia = 0;
            int mes = 0;
            int ano = 0;
            Datas(dia, mes, ano);
            
        }
    }
}
