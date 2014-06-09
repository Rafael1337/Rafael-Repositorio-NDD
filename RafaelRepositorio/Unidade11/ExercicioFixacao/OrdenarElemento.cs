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
        static void Main111(string[] args)
        {
            int troca = 0;
           
            int[] aux = new int[20];
            int[] Nums = new int[20];
            for (int i = 0; i < 20; i++)
            {
                aux[i] = randNum.Next(100,200);
                Nums[i] = randNum.Next(1, 100);
                    troca = Nums[i];
                aux[i] = troca;
                  
                }  
            }
        }
    }

