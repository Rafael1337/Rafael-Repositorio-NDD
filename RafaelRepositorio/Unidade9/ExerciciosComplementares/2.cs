using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.ExerciciosComplementares
{
    class _2
    {
        public static Random Estacionado = new Random();
        //Considere um programa de computador que controla as vagas de um estacionamento. Esse programa deve armazenar em uma tabela (array de arrays) a situação das vagas 
        //    (ocupada ou livre) por andar. Implemente um programa em C# que defina aleatoriamente
        //    a situação das vagas de um estacionamento de quatro andares numerados de 1 a 4. Considere que a capacidade de cada andar é de 10 vagas. Complete o código a seguir.
        static void Main13(string[] args)
        {
            int[,] Vagas = new int[10, 4];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Vagas[i,j] = Estacionado.Next(0,2);
                    if (Vagas[i, j] == 1)
                    {
                        Console.WriteLine("Estacionado no andar: " + i + " Na vaga: " + j);
                    }
                    else
                        if (Vagas[i, j] == 0)
                        {
                            Console.WriteLine("Vaga livre no andar: " + i + " Na vaga: " + j);
                        }
                }
            }
        }
    }
}
