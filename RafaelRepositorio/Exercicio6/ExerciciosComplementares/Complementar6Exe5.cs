using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6
{
    class Complementar6Exe5
    {
        public static int Idade, Numero, Caixas;
        public static double Salario;
        public static void Trabalhadores()
        {
            Console.WriteLine("Informe o numero do trabalhador: ");
            Numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a idade do trabalhador: ");
            Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de caixas colhidas: ");
            Caixas = Convert.ToInt32(Console.ReadLine());
            if (Caixas <= 5)
            {                
                Salario = Caixas * 2.00;
            }
            else
                if (Caixas <= 10 && Caixas >= 6)
                {
                    Salario += (Caixas * 2.50);
                }
                else
                    if (Caixas <= 20 && Caixas >= 11)
                    {
                        Salario += (Caixas * 3.50);
                    }
                    else
                        if (Caixas >= 21)
                        {
                            Salario = Caixas * 5.00;
                        }
            if (Idade >= 18 && Idade <= 45)
                {
                    Salario += (Caixas * 2.50);
                }else
                 if(Caixas <= 20 && Caixas >= 11){
                        Salario += (Caixas * 3.50);
                 }else
                  if (Caixas >= 21) {
                      Salario = Caixas * 5.00;        
                  }
            if(Idade >= 18 && Idade <= 45){
                Salario += (Salario * 0.10);
            }else
                if (Idade > 45 && Idade <= 65)
                {
                    Salario +=(Salario * 0.20);
                }
            Console.WriteLine("Quantidade de caixas colhidas: " + Caixas);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Numero do trabalhador: " + Numero);
            Console.WriteLine("salario com adicional e por quantidade de caixas : " + Salario);
            Console.ReadKey();
        }
        static void Main111(string[] args)
        {
            Trabalhadores();
        }
    }
}
