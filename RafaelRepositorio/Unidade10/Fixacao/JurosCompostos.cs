using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10.Fixacao
{
    class JurosCompostos
    {
        public static double JurosComposto(double juros, double valor, int tempo, double M)
        {
            
            M = valor * (tempo + juros);
            return M;
        }
        static void Main13(string[] args)
        {
            double M = 0;
            Console.WriteLine("Informe o juros: ");
            double juros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o montante do valor: ");
           double  valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o tempo: (MESES) ");
           int tempo = Convert.ToInt32(Console.ReadLine());
           double result = JurosComposto(juros, valor, tempo, M);
        }
    }
}
