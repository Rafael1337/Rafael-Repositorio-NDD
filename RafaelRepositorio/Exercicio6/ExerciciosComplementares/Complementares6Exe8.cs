using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementares6
{
    class Complementares6Exe8
    {
        
        public static int q_nomes;

        public static void Nomes()
        {
            Console.WriteLine("Informe a quantidade de nomes: ");
                q_nomes = Convert.ToInt32(Console.ReadLine());
                
                string[] Nomes = new string[q_nomes]; 
                for (int i = 0;i <= Nomes.Length; i++)
                {
                    Console.WriteLine("Informe o nome: ");
                    Nomes[i] = Console.ReadLine();

               }
                for (int i = 0; i <= Nomes.Length; i++)
                {
                    var t_nomes = Nomes[i].Split();
                    Console.Write(t_nomes[t_nomes.Length].ToUpper());

                    for (int h = 0; h <= Nomes.Length; h++)
                    {
                        Console.Write(Nomes[h]);
                    }
                }
        }
        static void Main111(string[] args)
        {
            Nomes();
        }
    }
}
