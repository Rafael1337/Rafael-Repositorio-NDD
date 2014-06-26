using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar.Execicios
{
    internal class _2
    {
        public static Random randNum = new Random();
        public static List<int> _Lista = new List<int>();

        private static void Main123(string[] args)
        {
            for (int i = 0; i < 80; i++)
            {
                _Lista.Add(randNum.Next(1, 100));
            }
            Console.WriteLine("Media: " + _Lista.Average());
            Console.WriteLine("Soma de todos: " + _Lista.Sum());
            Console.WriteLine("Maior valor" + _Lista.Max());
            Console.WriteLine("Menor valor" + _Lista.Min());
            Console.ReadKey();
        }
    }
}