using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10.ExercicioComplementares
{
    class Idades
    {
        public static Random Rand = new Random();
        public static int _Idades(int i)
        {
            int[] idade = new int[20];
            for (i = 0; i <= 20; i++)
            {
                idade[i] = Rand.Next(1, 90);

            }
            return idade[i];
        }

        public static int Maior(int i, int maior, int[] idade)
        {

            maior = 0;
            if (idade[i] > maior)
            {
                maior = idade[i];

            }
            return maior;
        }

        public static int Menor(int i, int menor, int[] idade)
        {
            menor = 0;
            if (idade[i] > menor)
            {
                menor = idade[i];
            }
            return menor;
        }

        public static double Media(int i, int media, int[] idade)
        {
            
            media += idade[i] / 20;
            return media;
        }

        public static string Exibir(int[] idade, int i)
        {
           return "Idades: " + idade[i];
        }
        static void Main(string[] args)
        {
            int i = 0;
            int maior = 0;
            int[]idade =  new int[20];
            int menor = 0;
            int media = 0;
            _Idades(i);
            Maior(maior,i,idade);
            Menor(menor,i,idade);
            Media(media,i,idade);
            Exibir(idade,i);

        }
    }
}