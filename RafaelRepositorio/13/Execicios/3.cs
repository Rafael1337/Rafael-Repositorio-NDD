using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar.Execicios
{
    class _3
    {
        public static List<string> listagem = new List<string>();
        static void Main124(string[] args)
        {
            Console.WriteLine("Informe a quantidade de nomes a inserir: ");
            int nomes = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nomes; i++)
            {
                Console.WriteLine("Informe o nome: ");
                string nome = Console.ReadLine();
                listagem.Add(nome);                
            }
            listagem.Sort();
            foreach (var item in listagem)
            {
                Console.WriteLine(item);
            } Console.ReadKey();
        }      
    }
}
