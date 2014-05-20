using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.Complementares
{
    class _3
    {
       public static Random RandNum = new Random();
        public static int apartamento,aux;
        static void Main(string[] args)
        {             
            int i = 1;
            do
            {
                int o = 1;
                do 
                {
                    int p = 1;
                    do{
                       int n;
                        apartamento = (o * 10) + p;
                        Console.WriteLine("bloco : " + i );
                        Console.WriteLine("andar: " + o );
                        Console.WriteLine("apartamento: " + apartamento);

                        aux++;
                        n = RandNum.Next(1,300);
                        Console.WriteLine("total de cartões: " + aux);
                        Console.WriteLine("Numero do seu cartão: "+n);
                        p++;                        
                    }while(p <= 4);
                    o++;
                }while(o <= 9);
                i++;
            } while (i <= 3);           
        }
    }
}

