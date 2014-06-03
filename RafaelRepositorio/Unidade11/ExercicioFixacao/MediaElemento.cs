using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.ExercicioFixacao
{
    class MediaElemento
    {
        public static Random randNum = new Random();
        static void Main321(string[] args)
        {
            int media = 0;
            int[] Nums = new int[20];
            for (int i = 0; i < Nums.Length; i++)
            {
                Nums[i] = randNum.Next(1, 100);
                media += Nums[i] / Nums.Length;
                Console.WriteLine("total atual: " + media);
            }
        }
    }
}
