using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.ExerciciosComplementares
{
    class _1
    {
        public static Random Rand = new Random();
        public static int aux;
        public static void Prova()
        {
            int[] Escolha = new int[10];
            int[] Gabarito = new int[10];
                     
                for (int i = 0; i < Escolha.Length; i++)
                {
                    Gabarito[i] = Rand.Next(1, 4);
                    Console.WriteLine("Informe uma das opções de 1 a 3: ");
                    Escolha[i] = Convert.ToInt32(Console.ReadLine());
                    if (Escolha[i] > 3)
                    {
                        Console.WriteLine("Opção invalida refaça a prova");
                        break;
                    }
                
                    if (Escolha[i] == Gabarito[i])
                    {
                        aux = aux + 1;
                    }                    
                    Console.WriteLine("Opção: " + Escolha[i] + "\n" + "Opção certa: "+Gabarito[i]);
                    Console.WriteLine("Sua nota: " + aux);        
                }
                for (int i = 0; i < Gabarito.Length; i++)
                {
                    Console.WriteLine(" GABARITO ");
                    Console.WriteLine(Gabarito[i]);
                }
 
            
            
        }
        //Considere um programa de computador que corrige provas de múltipla escolha. Esse programa deve armazenar em um array o 
        //    gabarito de uma prova. Implemente um programa em C# que gere aleatoriamente o gabarito de uma prova com 10 questões de
        //    múltipla escolha. Considere que cada questão possui três alternativas numeradas de 1 a 3. Complete o código a seguir.
        static void Main33(string[] args)
        {
            Prova();
        }
    }
}
