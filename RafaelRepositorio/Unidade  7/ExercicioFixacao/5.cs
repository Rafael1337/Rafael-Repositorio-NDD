using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade__7.ExercicioFixacao
{
    class _5
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            
            int[] vet = new int[6];
            for (int i = 0; i <= 100; i++)
            {
                int valor = rand.Next(1, 6);

                switch (valor)
                {
                    case 1:
                        vet[0] += 1;
                        break;
                    case 2:
                        vet[1] += 1;
                        break;
                    case 3:
                        vet[2] += 1;
                        break;
                    case 4:
                        vet[3] += 1;
                        break;
                    case 5:
                        vet[4] += 1;
                        break;
                    case 6:
                        vet[5] += 1;
                        break;
                }                
            }
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("A posição "+(i + 1)+ " aparece "+vet[i]+ "x", (i + 1), vet[i]);
            }
        }
    }
}
