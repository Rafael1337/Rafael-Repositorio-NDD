using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UnidadeComplementar
{
    class Program
    {        
        public static ArrayList _ArrayList = new ArrayList();
        public static List<int> _ListInt = new List<int>();
        public static IList<string> _IListInt = new List<string>();
        public static Dictionary<int, string> _Dictionary = new Dictionary<int, string>();

        static void Main13(string[] args)
        {
            //ADICIONAR
            _ArrayList.Add(1);
            _ArrayList.Add("Rafael");
            _ArrayList.Add(1.78);
            _ArrayList.Add('M');
            //REMOVER
            _ArrayList.Remove(1);
            _ArrayList.Insert(3, 1);
            int idex = _ArrayList.IndexOf(1); // MOSTRA A POSICAO
            int lastIndex = _ArrayList.LastIndexOf(1); // MOSTRA A ULTIMA POSICAO
            _ArrayList.RemoveAt(3); // REMOVE POR POSICAO
            _ArrayList.Sort(); // CRESCENTE
            _ArrayList.Reverse(); // DECRESCENTE
            _ArrayList.Clear(); // LIMPA A LISTA

            _ListInt.Add(12);
            _ListInt.Add(13);
            _ListInt.Add(56);
            _ListInt.Add(6);
            _ListInt.Add(2);
            foreach(var Item in _ListInt)
            {
                Console.WriteLine(Item);
            }

            
            
        }
    }
}
