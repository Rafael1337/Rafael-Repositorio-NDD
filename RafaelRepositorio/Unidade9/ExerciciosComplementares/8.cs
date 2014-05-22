using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.ExerciciosComplementares
{
    class _8
    {
        public static int i,j,contador;
        public static Random Rand = new Random();
        static void Main(string[] args)
        {
            int[] Gaba = new int[13];
            int[] Resposta = new int[13];
            for (i = 0; i < Gaba.Length; i++)
            {
                Gaba[i] = Rand.Next(1, 4);
                if (Gaba[i] == 1)
                {
                    Console.WriteLine("FOI: "+  (i+1), Gaba[i]);
                }
                if (Gaba[i] == 2)
                {
                    Console.WriteLine("FOI: "+ (i+1), Gaba[i]);
                }
                if (Gaba[i] == 3)
                {
                    Console.WriteLine("FOI: "+ (i+1), Gaba[i]);
                }
            }

            for(j = 0;j < Resposta.Length;j++){
                int jog = 0;
                Console.WriteLine("jogador: " + jog );

                Resposta[j] = Rand.Next(1, 4);

                if (Resposta[j] == 1)
                {
                    Console.WriteLine("FOI: " + (j+1), Resposta[j]);
                }
                if (Resposta[j] == 2)
                {
                    Console.WriteLine("FOI: " + (j+1), Resposta[j]);
                }
                if (Resposta[j] == 3)
                {
                    Console.WriteLine("FOI: " + (j + 1), Resposta[j]);
                }
                if (Resposta[j] == Gaba[Gaba.Length - 1])
                {
                    contador++;
                }

            }


           

            if (contador == 13)
            {
                Console.WriteLine("Ganhaste um BAITA MILHÃO");
            }
            else
                Console.WriteLine("PERDEU AZARADO");
           
        }

    }

}
