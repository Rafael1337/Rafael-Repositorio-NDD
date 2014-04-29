using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        public static double v1, v2, v3, receptor1, receptor2, receptor3, s1, s2, s3;
        public static string c1, c2, c3;
        public static void Corretores(double s1, double s2, double s3, string c1, string c2, string c3, double v1, double v2, double v3,double receptor1, double receptor2, double receptor3)
        {
            Console.WriteLine("Informe o nome do corretor 1");
            c1 = Console.ReadLine();
            Console.WriteLine("Informe o salario do corretor 1: ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o nome do corretor 2");
            c2 = Console.ReadLine();
            Console.WriteLine("Informe o salario do corretor 2: ");
            s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o nome do corretor 3");
            c3 = Console.ReadLine();
            Console.WriteLine("Informe o salario do corretor 3: ");
            s3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor das vendas do corretor 1: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor das vendas do corretor 2: ");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor das vendas do corretor 3: ");
            v3 = Convert.ToDouble(Console.ReadLine());

            if (v1 > 50000.00)
            {
                receptor1 = (s1 / v1) * 0.12;
            }
            else
                if (v1 > 30000.00 && v1 < 50000.00)
                {
                    receptor1 = (s1 / v1) * 9.5 / 100;
                }
                else
                    receptor1 = (s1 / v1) * 0.7;
            
            if (v2 > 50000.00)
            {
                receptor2 = (s1 / v2) * 0.12;
            }
            else
                if (v2 > 30000.00 && v2 < 50000.00)
                {
                    receptor2 = (s1 / v2) * 9.5 / 100;
                }
                else
                    receptor2 = (s1 / v2) * 0.7;

            if (v3 > 50000.00)
            {
                receptor3 = (s1 / v3) * 0.12;
            }
            else
                if (v3 > 30000.00 && v3 < 50000.00)
                {
                    receptor3 = (s1 / v3) * 9.5/100;
                }
                else
                    receptor3 = (s1 / v3) * 0.7;

            Console.WriteLine("Salario reajustado do corretor" +c1+ "com comissão " + receptor1);
            Console.WriteLine("Salario reajustado do corretor" +c2+ "com comissão " + receptor2);
            Console.WriteLine("Salario reajustado do corretor" +c3 + "com comissão " + receptor3);

        }
        static void Main(string[] args)
        {
            Corretores(s1, s2, s3, c1, c2, c3, v1, v2, v3, receptor1, receptor2, receptor3);

        }
    }
}
