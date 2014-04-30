using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6
{
    class Complementar6Exe5
    {
        public static int idade, numero,caixas;
        public static double  salario;
        public static void Trabalhadores()
        {
            Console.WriteLine("Informe o numero do trabalhador: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a idade do trabalhador: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de caixas colhidas: ");
            caixas = Convert.ToInt32(Console.ReadLine());
            if (caixas <= 5)
            {                
                salario = caixas * 2.00;
            }else 
                if (caixas <= 10 && caixas >= 6)
                {
                    salario = caixas * 2.50;
                }else
                 if(caixas <= 20 && caixas >= 11){
                        salario = caixas * 3.50;
                 }else
                  if (caixas >= 21) {
                      salario = caixas * 5.00;        
                  }
            if(idade >= 18 && idade <= 45){
                salario = salario * 0.10;
            }else
                if (idade > 45 && idade <= 65)
                {
                    salario = salario * 0.20;
                }
            Console.WriteLine("Quantidade de caixas colhidas: " + caixas);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Numero do trabalhador: " + numero);
            Console.WriteLine("salario com adicional e por quantidade de caixas : " + salario);
        }
        static void Main111(string[] args)
        {
            Trabalhadores();
        }
    }
}
