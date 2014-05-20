using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.ExerciciosComplementares
{
    class _5
    {
        public static int i,r,n,aux;
        public static Random Rand = new Random();
        static void Main(string[] args)
        {
            
            char[] Resposta = new char[]{'a','b','c','d','e'};
            string[] Gabarito = new string[10];
            string[] RespostaAlunos = new string[10];
            string[] Alunos = new string[20];

            for (i = 0; i < 10; i++)
            {                
                Gabarito[i] = Resposta[Rand.Next(0, 6)].ToString();
                if (i == 10)
                {
                    Console.WriteLine("GABARITO");
                    Console.WriteLine("Resposta do gabarito: "+Gabarito[i]);
                }
            }
            for (n = 0; n < 20; n++)
            {
                Console.WriteLine("Nome aluno: ");
                Alunos[n] = Console.ReadLine();
            }
            for (r = 0; r < 10; r++)
            {
                Console.WriteLine("Informe a resposta da: " + r);
                RespostaAlunos[r] = Console.ReadLine();
                if (RespostaAlunos[r] == Gabarito[i])
                {
                    aux = aux + 1;
                }
            }
            Console.WriteLine("Aluno: " + Alunos[n]);
            Console.WriteLine("Respostas do gabarito: " + RespostaAlunos[r]);
            Console.WriteLine("Nota do Aluno: " + aux);

        }
    }
}
