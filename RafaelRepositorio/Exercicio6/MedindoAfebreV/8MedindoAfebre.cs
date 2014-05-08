using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.MedindoAfebreV
{
    class _8MedindoAfebre
    {
        public static int opc,contador;
        public static int hora,minutos,segundos;
        public static void PessoasEntrando()
        {
            Console.WriteLine("PESSOA ENTROU - 1 ");
            Console.WriteLine("EXIT - 0");
            opc = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (opc)
                {
                    case 1:
                        hora = DateTime.Now.Hour;
                        minutos = DateTime.Now.Minute;
                        segundos = DateTime.Now.Second;
                        Console.WriteLine("Hora: " + hora + "Minuto: " + minutos + "Segundos: " + segundos);
                        if (hora >= 10 && hora <= 16)
                        {
                            contador = contador + 1;
                            Console.WriteLine("Quantidade atual de pessoas que entraram no banco: " + contador);
                        }
                        else
                            Console.WriteLine("Horario estourado");
                        break;
                    case 0:
                        Console.WriteLine("Encerrando");
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            Console.WriteLine("PESSOA ENTROU - 1 ");
            Console.WriteLine("EXIT - 0");
            opc = Convert.ToInt32(Console.ReadLine());
            }
            while (opc != 0);
        }
        static void Main111(string[] args)
        {
            PessoasEntrando();
        }
    }
}
