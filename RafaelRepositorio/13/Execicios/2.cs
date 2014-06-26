using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UnidadeComplementar.Execicios
{
    class _2
    {
        public static Random randNum = new Random();
        public static List<int> _Lista = new List<int>();
        static void Main123(string[] args)
        {
            
            for (int i = 0; i < 80; i++)
            {
                _Lista.Add(randNum.Next(1,1000));
                
            }
            Console.WriteLine("Media: "+ _Lista.Average());
            Console.WriteLine("Soma de todos: " + _Lista.Sum());
                Console.WriteLine("Maior valor"+ _Lista.Max());           
                Console.WriteLine("Menor valor" + _Lista.Min());
                Console.ReadKey();         
        }
    }
}
