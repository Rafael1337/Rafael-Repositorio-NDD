using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6
{
    class Complementar6Exe4
    {
        public static Random randGol = new Random();
       
        public static int gremio, inter;
        public static void Partida()
        {
            gremio = randGol.Next(1, 5);
            inter = randGol.Next(1, 5);
            if (gremio > inter)// SEMPRE SERA
            {
                Console.WriteLine("Gremio WINS!");
                Console.WriteLine("Gremio: "+ gremio);
                Console.WriteLine("Inter: "+ inter);
            }else
                if (inter > gremio)
                {
                    Console.WriteLine("Inter ¬¬'");
                    Console.WriteLine("Gremio: "+ gremio);
                    Console.WriteLine("Inter: "+ inter);
                }else
                    if (gremio == inter)
                    {
                        Console.WriteLine("Empate");
                        Console.WriteLine("Gremio: "+ gremio);
                        Console.WriteLine("Inter: "+ inter);
                    }
                    else
                        Console.WriteLine("...");
        }
        static void Main11(string[] args)
        {
            Partida();
        }
    }
}
