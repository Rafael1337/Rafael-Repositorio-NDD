using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;


namespace Unidade12.ArrayList_e_List
{
    class Arrays
    {
        public static Random Rand = new Random();
        //static void Main1(string[] args)
        //{
        //    List<int> lista = new List<int>();
        //    for (int i = 0; i < 7; i++)
        //    {
        //        lista.Add(Rand.Next(1, 100));
        //        Console.WriteLine(lista[i]);                
        //    }
        //    Console.WriteLine("Maior valor: " + lista.Max());
        //}

        //    public static int i;        
        //    static void Main2(string[] args)
        //    {
        //        List<int> lista1 = new List<int>();
        //        List<int> lista2 = new List<int>();

        //        for (i = 0; i < 12; i++)
        //        {
        //            lista1.Add(Rand.Next(0, 10));
        //            Console.WriteLine("Valores do primeiro vetor: " + lista1[i]);

        //        }
        //        Console.WriteLine("");
        //        for (i = 0; i < 12; i++)
        //        {
        //            if (lista1[i] == 0)
        //            {
        //                lista2[i] = 1;
        //            }
        //            else
        //                lista2[i] = lista1[i];

        //            Console.WriteLine("Valores do Segundo vetor: " + lista2[i]);
        //        }
        //    }


        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();
            int fil = 0;
            int qt = 0;
            Console.WriteLine("Informe a quantidade de filmes locado pelo cliente: ");
            fil = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < fil; i++)
            {
                Console.WriteLine("Filme: " + i);
                string titulos = Console.ReadLine();
                AL.Add(titulos[i]);                
                if (i >= 10)
                {
                    qt++;

                    Console.WriteLine("Numeros de filmes gratuitos " + qt);
                }
             }
            for (int i = 0; i < fil; i++)
            {
                Console.WriteLine("Titulos locados pelo cliente");
                Console.WriteLine(AL[i]);
            }
            }            
        }      
    }
