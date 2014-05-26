using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade__7.ExercicioFixacao
{
    class _2
    {
        static void Main11(string[] args)
        {
            double salario = 0;
            int filhosCount = 0;
            int opc;
            double MaiorSalario = 0;
            int quantHabitantes = 0;
            double SalarioMedia = 0;
            double MediaFilho = 0;
            do
            {
                Console.WriteLine("Cadastar habitante: - 1 ");
                Console.WriteLine("Sair - 0");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc) {
                    case 1:
                Console.WriteLine("informe a quantidade de filhos:  ");
                filhosCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o salario: ");
                salario = Convert.ToDouble(Console.ReadLine());
                quantHabitantes++;
                MediaFilho += filhosCount/quantHabitantes;
                if (salario < MaiorSalario)
                {
                    MaiorSalario = salario;
                }
                SalarioMedia += salario / quantHabitantes;               
                break;
                    default:
                Console.WriteLine("cabo");
                break;
            }
                Console.WriteLine("O maior salario : " + MaiorSalario);
                Console.WriteLine("Total de habitantes: " + quantHabitantes);
                Console.WriteLine("Quantidade media de filhos: " + MediaFilho);
                Console.WriteLine("Media de salario: " + SalarioMedia);


            } while (opc == 0);
        }
    }    
}
