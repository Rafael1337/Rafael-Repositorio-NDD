using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.Complementares
{
    internal class MegaSena
    {
        public static int acertos;
        public static Random sorteado = new Random();
        public static int[] NumerosSortedos = new int[6];
        public static int[] NumerosEscolhidos = new int[6];

        public static void Menores()
        {
            int menor = 0;
            for (int i = 0; i < 6; i++)
            {
                if (menor < NumerosEscolhidos[i])
                {
                    menor = NumerosEscolhidos[i];                   
                }
                Console.WriteLine(NumerosEscolhidos[i]);
            }
        }
        public static void Verifica(int[]sort,int[]apostas)
        {
            acertos = 0;
            for (int i = 0; i < sort.Length; i++)
            {
                for (int j = 0; j < apostas.Length; j++)
                {
                    if (sort[i] == apostas[j])
                    {
                        acertos++;
                    }
                }
            }
        }

        public static void Resultado()
        {            
            if (acertos == 1)
            {
                Console.WriteLine("Só acertou 1 numero " + acertos);
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
                Console.WriteLine("Acertou 5 numeros QUINA! parabéns " + acertos);
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
            for (int i = 0; i < NumerosEscolhidos.Length; i++)
            {
                Console.WriteLine("Informe a sua joga de numero " + i + " de 6, 61 numeros de sua escolha: ");
                NumerosEscolhidos[i] = Convert.ToInt32(Console.ReadLine());                
            }

        }

        public static void SortearNumeros()
        {
            for (int i = 0; i < NumerosSortedos.Length ;i++)
            {
               NumerosSortedos[i] = sorteado.Next(1, 61);
               Console.WriteLine("Numero sorteado " + NumerosSortedos[i]);
               
            }           
        }
        public static void Main()
        {
           
            JogarNaMega();
            SortearNumeros();
            Verifica(NumerosSortedos,NumerosEscolhidos);
            Resultado();
            Menores();
           
        }
    }
}
