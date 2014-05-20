using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_9
{
    class _7
    {
        static void Main11(string[] args)
        {
             int[,] vet = new int[3, 2];

            for (int i = 0; i < 3; i++)
			{
                for (int j = 0; j < 2; j++)
			    {
                    Console.Write("Informe numeros: ");
                    vet[i,j] = Convert.ToInt32(Console.ReadLine());
			    }
			}

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write( vet[i, j]);
                }
            }
        }
    }
}
    
