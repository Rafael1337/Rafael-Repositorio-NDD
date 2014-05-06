using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6
{
    class Complementar6Exe6
    {
       public static string[] Nomes = new string[400];
            

           public static double[] Altura = new double[400];
           public static int Qt_mocas;
        public static double  Mais_Alta;
        public static void LerDados()
        {
            for (int i = 1; i <= 400;i++ )
            {
                Console.WriteLine("Informe o nome");
                Nomes[i] = Console.ReadLine();
                Console.WriteLine("informe a altura: ");
                    Altura[i] = Convert.ToDouble(Console.ReadLine());
                    if (Nomes[i].ToLower() == "fim")
                    {
                        i = 401;
                    }
                    Qt_mocas = Qt_mocas + 1;
                    Console.WriteLine("Quantidade de moças: " + Qt_mocas);
                    Console.WriteLine("Nomes: " + Nomes[i]);
            }            
        }

        public static void Comparador()
        {
            for(int i = 1;i <= 400; i++){
                if(Nomes[i] != null){
                    Mais_Alta = Altura[i]++; 
                }
            } 
        }
        static void Main213(string[] args)
        {
            LerDados();
            Comparador();
        }
    }
}
