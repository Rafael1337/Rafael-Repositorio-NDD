using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10.Fixacao
{
    class IRPF
    {
        public static double Irpf(double salarioBruto,double reducao,double previdencia,double dependente,double INSS, double salario, double irpff)
        {
            INSS = 0.11;
            dependente = 150.69;
            previdencia = 0.10;
            salarioBruto = salario;
            salario = salario / INSS;
            salario = salario / dependente;
            salario = salario / previdencia;
            reducao = salario;
            salarioBruto -= salario;
            salarioBruto = irpff;
            return irpff;
        }
        static void Main231(string[] args)
        {
            double salarioBruto = 0;
            double reducao = 0;
            double previdencia = 0;
            double dependente = 0;
            double INSS = 0;
            double irpff = 0;
            Console.WriteLine("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            double result = Irpf(salarioBruto, reducao, previdencia, dependente, INSS, salario, irpff);
            Console.WriteLine(result);
        }
    }
}
