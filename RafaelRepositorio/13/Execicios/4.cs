using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UnidadeComplementar.Execicios
{
    class _4
    {
        public static Random randNum = new Random();
        public static ArrayList _ArrayList = new ArrayList();
        public static List<int> _ListInt = new List<int>();
        public static IList<int> _IListInt = new List<int>();
        public static Dictionary<int, int> _Dictionary = new Dictionary<int, int>();
        static void Main13(string[] args)
        {

            _Dictionary.Add(1, 4);
            _Dictionary.Add(2, 3);
            _Dictionary.Add(3, 5);
            _Dictionary.Add(4, 6);
            for (int i = 0; i < 10; i++)
            {
                _ArrayList.Add(randNum.Next(1, 100));
                _ListInt.Add(randNum.Next(1, 100));
                _IListInt.Add(randNum.Next(1, 100));                
            }
            foreach (var item in _ArrayList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in _ListInt)
            {
                Console.WriteLine(item);    
            }
            foreach (var item in _IListInt)
            {
                Console.WriteLine(item);
            }
            foreach(var item in _Dictionary){
                Console.WriteLine(item);
            } Console.ReadKey();
        }
    }
}
