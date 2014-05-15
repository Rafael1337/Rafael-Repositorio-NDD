using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medindo_a_febre6
{
    //        O sistema de avaliação de uma determinada disciplina obedece aos seguintes criterios
    //- durante o semestre são dadas três notas;
    //- a nota final é obtida pela média aritmética das notas dadas durante o curso;
    //- é considerado aprovado o aluno que obtiver a nota final superior ou igual a 60 e que tiver comparecido ao minimo de 40 aulas.
    //faça um algoritimo em c# que:
    //    }
    class _12
    {
        public static Random RandNum = new Random();
        public static int Qt_aulas,Qt_freq,Total_alunos,Total_faltas;
        public static double Notafinal, Nota1, Nota2, Nota3;
        public static string Matricula = "";
        public static void Aluno()
        {
            Console.WriteLine("Informe o total de alunos: ");
            Total_alunos = Convert.ToInt32(Console.ReadLine());
            int j = 1;
            do
            {
                Console.WriteLine("Informe a matricula: ");
                Matricula = Console.ReadLine();
                Nota1 = RandNum.Next(1, 100);
                Nota2 = RandNum.Next(1, 100);
                Nota3 = RandNum.Next(1, 100);
                Notafinal = (Nota1 + Nota2 + Nota3) / 3;

                Console.WriteLine("Nota final do aluno: " + Notafinal);
                Console.WriteLine("Informe o total de aulas dadas - MINIMO 40: ");
                Qt_aulas = Convert.ToInt32(Console.ReadLine());
                if (Qt_aulas < 40)
                {
                    Console.WriteLine("Valor invalido");
                    break;
                }
                Console.WriteLine("Informe o total de faltas do aluno: ");
                Total_faltas = Convert.ToInt32(Console.ReadLine());

                Qt_freq = Qt_aulas - Total_faltas;

                if (Notafinal >= 60 && Qt_freq >= 40)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                    if (Notafinal < 60)
                    {
                        Console.WriteLine("Reprovou por Media");
                    }
                    else
                        if (Qt_freq < 40)
                        {
                            Console.WriteLine("Reprovado por faltas");
                        }
               
                j++;
            } while (j == Total_alunos);
           

        }
     
        static void Main(string[] args)
        {
            Aluno();
        }
    }
}
