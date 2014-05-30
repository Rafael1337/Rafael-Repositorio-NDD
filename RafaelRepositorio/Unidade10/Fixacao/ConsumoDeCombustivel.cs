using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10.ExercicioFixacao
{
    class ConsumoDeCombustivel
    {
        public static double ConsumoCombustivel(double gasosa, double km)
        {

            return km /= gasosa; 

        }
        static void Main11(string[] args)
        {
            Console.WriteLine("Informe a quantidade de gasolina abastecida: ");
            double gasosa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a kilometragem percorrida pelo carro: ");
            double km = Convert.ToDouble(Console.ReadLine());
            double result  = ConsumoCombustivel(gasosa,km);
        }
    }
}


