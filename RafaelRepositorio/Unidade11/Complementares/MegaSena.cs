using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.Complementares
{
    internal class MegaSena
    {
        public static Random sorteado = new Random();
        public static int[] NumerosSortedos = new int[6];
        public static int[] NumerosEscolhidos = new int[6];
        public static void Main()
        {
            int acertos = 0;
            SortearNumeros();
            JogarNaMega();
            Resultado(acertos);
        }

        public static void Verifica(int[]sort,int[]apostas)
        {
            int aux = 0;
            for (int i = 0; i < sort.Length; i++)
            {
                for (int j = 0; j < apostas.Length; j++)
                {
                    if (sort[i] == apostas[j])
                    {
                        aux++;
                    }
                }
            }

        }

        public static void Resultado(int acertos)
        {
            if (acertos == 1)
            {
                Console.WriteLine("Só acertou 1 numero" + acertos);
            } if (acertos == 2)
            {
                Console.WriteLine("Acertou 2 numeros " + acertos);
            } if (acertos == 3)
            {
                Console.WriteLine("Acertou 3 numeros " + acertos);
            } if (acertos == 4)
            {
                Console.WriteLine("Acertou 4 numeros" + acertos);
            }
            if (acertos == 5)
            {
                Console.WriteLine("Acertou 5 numeros QUINA! parabéns" + acertos);
            }
            if (acertos == 6)
            {
                Console.WriteLine("Ganhou na megasena parabens! " + acertos);
            }
            if (acertos == 0)
            {
                Console.WriteLine("Nenhum acerto try again " + acertos);
            }
        }

        public static void JogarNaMega()
        {
            for (int i = 1; i < NumerosEscolhidos.Length; i++)
            {
                Console.WriteLine("Informe o numero "+ i +"de 6 que você escolha: ");
                NumerosEscolhidos[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        public static void SortearNumeros()
        {
            for (int i = 0; i < NumerosSortedos.Length ;i++)
            {
               NumerosSortedos[i] = sorteado.Next(1, 61);
            }           
        }
    }
}
