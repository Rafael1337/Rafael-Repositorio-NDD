using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6
{
    class Complementar6Exe3
    {
        public static int opc;
        public static double peso,altura;
        public static string homem, mulher;
        public static void YoloSwag()
        {
            Console.WriteLine("1 - SEXO MASCULINO");
            Console.WriteLine("2 - SEXO FEMININO");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    homem = "Homem";
                    Console.WriteLine("Informe a altura");
                    altura = Convert.ToDouble(Console.ReadLine());
                    peso = (72.7 * altura)-58;
                    Console.WriteLine("Sexo: ", homem);
                    Console.WriteLine("Altura: ", altura);
                    Console.WriteLine("Peso ideal: ", peso);
                    break;
                case 2:
                    mulher = "Mulher";
                    Console.WriteLine("Informe a altura");
                    altura = Convert.ToDouble(Console.ReadLine());
                    peso = (62.1 * altura)-44.7;
                    Console.WriteLine("Sexo: ", mulher);
                    Console.WriteLine("Altura: ", altura);
                    Console.WriteLine("Peso ideal: ", peso);
                    break;
            }
        }
        static void Main141(string[] args)
        {
            YoloSwag();
        }
    }
}
