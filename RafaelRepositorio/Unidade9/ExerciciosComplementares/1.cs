using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.ExerciciosComplementares
{
    class _1
    {
        public static void Prova()
        {
            int[] Escolha = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe uma das opções de 1 a 3: ");
                Escolha[i] = Convert.ToInt32(Console.ReadLine());
                if (Escolha[i] > 3)
                {
                    Console.WriteLine("Opção invalida refaça a prova");
                    break;
                }
                Console.WriteLine("Opções: "+Escolha[i]+"/n");
            }
        }
        //Considere um programa de computador que corrige provas de múltipla escolha. Esse programa deve armazenar em um array o 
        //    gabarito de uma prova. Implemente um programa em C# que gere aleatoriamente o gabarito de uma prova com 10 questões de
        //    múltipla escolha. Considere que cada questão possui três alternativas numeradas de 1 a 3. Complete o código a seguir.
        static void Main(string[] args)
        {
        }
    }
}
