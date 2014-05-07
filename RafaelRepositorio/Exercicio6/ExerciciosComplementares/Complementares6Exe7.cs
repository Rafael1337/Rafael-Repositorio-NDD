using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementares6
{
    class Complementares6Exe7
    {
        public static int opc;
        public static double h_salario, m_salario, t_horas, q_faltas, res_m;
        public static void Funcionario(){
            Console.WriteLine("1 - Horista");
            Console.WriteLine("2 - Mensalista");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Informe o salario por hora do funcionario: ");
                     h_salario = Convert.ToDouble(Console.ReadLine());
                     Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                     t_horas = Convert.ToDouble(Console.ReadLine());
                     t_horas = t_horas - 44;
                     h_salario = h_salario * t_horas;
                     Console.WriteLine("Salario bruto do funcionario: " + h_salario);
                    
                        
                    break;
                case 2:
                    Console.WriteLine("Informe o salario dia que totalizara o mes do mensalista ex 20 dia: ");
                    m_salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de faltas: ");
                    q_faltas = Convert.ToDouble(Console.ReadLine());
                    q_faltas = 20 - q_faltas;
                    res_m = m_salario * 20;
                    Console.WriteLine("Salario bruto do funcionario: " + res_m);
                    break;
            }
        }
        static void Main222(string[] args)
        {
            Funcionario();
        }
    }
}
