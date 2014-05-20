using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_9
{
    class _8
    {
        static void Main(string[] args)
        {
            int[,] Array = new int[10, 10];
            for (int i = 0; i <  10; i++)
            {
                for (int h = 0; h <  10; h++)
                {
                    Array[i, h] = i * h;
                   Console.WriteLine("Esse aqui: "+i + "X esse: " +h+ " = "+Array[i,h]);               
                }
            }
        }
    }
}
