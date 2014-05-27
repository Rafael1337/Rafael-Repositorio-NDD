using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAfebre7
{
    class Program
    {
        public static double ContadorM,ContadorF;
        public static double PorcentagemM, PorcentagemF;
        public static Random RandNum = new Random();
        public static bool[] Adulto = new bool[50];
        public static int[] Novos = new int[50];
        public static int[] Idade = new int[50];
        public static string[] Nome = new string[50];
        public static string[] SexResp = new string[50];
        public static char[] Sexo = new char[] { 'M', 'F' };
        public static double[] Altura = new double[50];
        public static double[] MaisAlto = new double[50];
        public static double[] Maiores = new double[1];
        public static double[] Menores = new double[1];
        public static int[] Velhos = new int[50];
        public static double[] qtMasc = new double[1];
        public static double[] qtFem = new double[1];

        
        public static void PopulaCampos()
        {
            for (int i = 0; i < Nome.Length; i++)
            {
                Nome[i] = "teste" + i;         

                Altura[i] = RandNum.NextDouble() + 1;                
                Idade[i] = RandNum.Next(1, 99);                
                Adulto[i] = CalculaAdulto(Idade[i]);
                MaisAlto[i] = CalculaAltura(Altura[i]);
                Maiores[i] = CalculaMaiores(Maiores[i]);
                Menores[i] = CalculaMenores(Maiores[i]);
                Velhos[i] = MaisVelhos(Velhos[i]);
                Novos[i] = MaisNovos(Novos[i]);
              
                 

            }
        }
        public static int MaisVelhos(int velho)
        {
            
            velho = 0;
            for (int i = 0; i < 50; i++)
            {
                if (Idade[i] > velho)
                {
                    velho = Idade[i];
                    
                }
            }
            return velho;
        }
        public static int MaisNovos(int novos)
        {
            novos = 0;
            for (int i = 0; i < 50; i++)
            {
                if (Idade[i] < novos)
                {
                    novos = Idade[i];
                    
                }
            }
            return novos;
        }
        public static double CalculaMenores(double menor)
        {
            menor = 0;
            for (int i = 0; i < 50; i++)
            {
                if (Altura[i] < menor)
                {
                    menor = Altura[i];
                  
                }
            }
            return menor;
        }
        public static double CalculaMaiores(double maior)
        {
            
            maior = 0;
            for (int i = 0; i < 50; i++)
            {
                if (Altura[i] > maior)
                {
                    maior = Altura[i];
                    
                }
            }
            return maior;
        }
        public static double CalculaAltura(double altura)
        {
            int countAlto = 0;
            double porcentoAlto = 0;
            if (altura > 1.70)
            {
                countAlto = countAlto + 1;
               return porcentoAlto = (countAlto * 50) / 100;
            }
            else
               return 0;
        }

        public static void SexoContador()
        {

            for(int i = 0; i < 50;i++){
            int indice = RandNum.Next(0, Sexo.Length);
                SexResp[i] = Sexo[i].ToString();

                if (Sexo[i] == 'M')
                {
                    ContadorM = ContadorM + 1;    
                    PorcentagemM = (ContadorM * 50) / 100;
                    Console.WriteLine("Quantidade Masculina: " + ContadorM);
                    Console.WriteLine("Porcentagem Masculina: " + PorcentagemM);

                }
                else
                     if (Sexo[i] == 'F')
                    {
                        ContadorF = ContadorF + 1;                        
                        PorcentagemF = (ContadorF * 50) / 100;
                        Console.WriteLine("Quantidade feminina: " + ContadorF);
                        Console.WriteLine("Porcentagem feminina: " + PorcentagemF);
                    }   
            }
        }

        public static bool CalculaAdulto(int idade)
        {
            if (idade >= 18)
            {
                return true;
            }
            else
                return false;
            
        }
        static void Main(string[] args)
        {

           PopulaCampos();
        }
    }
}
