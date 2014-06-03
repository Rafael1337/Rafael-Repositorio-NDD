using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.ExercicioFixacao
{
    class SomaElemento
    {
        public static Random randNum = new Random();
        static void Main12313(string[] args)
        {
            int soma = 0;
            int[] Nums = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Nums[i] = randNum.Next(1, 100);
                soma += Nums[i];
                Console.WriteLine("total atual: " + soma);
            } 
        }
    }
}
