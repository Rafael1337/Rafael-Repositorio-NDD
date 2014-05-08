using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.MedindoAfebreV
{
    class _7MedindoAfebre
    {
        public static int idade;
        public static Random nextRandom = new Random();
        public static string t_idade;
        public static void pessoa()
        {
             idade = nextRandom.Next(1,120);
             t_idade = idade >= 18 ? "Adulto" : "Nao é adulto";
             Console.WriteLine(idade);
             Console.WriteLine(t_idade);
        }
        static void Main123123(string[] args)
        {
            pessoa();            
        }
    }
}
