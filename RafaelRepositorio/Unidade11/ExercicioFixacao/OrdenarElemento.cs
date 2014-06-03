using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.ExercicioFixacao
{
    class OrdenarElemento
    {
        public static Random randNum = new Random();
        static void Main(string[] args)
        {
            int troca = 0;
            int menor = 0;
            int[] Nums = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Nums[i] = randNum.Next(1, 100);
                if (Nums[i] < menor)
                {
                    troca = Nums[i];
                    Console.WriteLine(troca);
                }  
            }
        }
    }
}
