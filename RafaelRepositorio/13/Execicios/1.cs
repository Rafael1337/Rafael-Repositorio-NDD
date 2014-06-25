using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar.Execicios
{
    class _1
    {
        public static Random randNum = new Random();
        public static ArrayList _ArrayList = new ArrayList();
        static void Main11(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                _ArrayList.Add(randNum.Next(1, 100));                
            }
            _ArrayList.Sort();
            foreach(var item in _ArrayList){                
                Console.WriteLine(item);
            }

            _ArrayList.Reverse();

            foreach (var item in _ArrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
