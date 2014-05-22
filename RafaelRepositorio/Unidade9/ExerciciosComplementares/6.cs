using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.ExerciciosComplementares
{
    class _6
    {
        public static void Locadora()
        {
            
            int fil = 0;
            int qt = 0;
            Console.WriteLine("Informe a quantidade de filmes locado pelo cliente: ");
            fil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fil);
            int[] filmes = new int[fil];
            string[] titulos = new string[fil];
            for (int i = 0; i < filmes.Length; i++)
            {
                Console.WriteLine("Filme: "+i);
                titulos[i] = Console.ReadLine();
                if (i >= 10)
                {                    
                    qt++;               

                    Console.WriteLine("Numeros de filmes gratuitos " + qt);
                }
            }
            Console.ReadKey();
        }
        static void Main11(string[] args)
        {
            Locadora();
        }
    }
}
