using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.MedindoAfebreV
{
    class _9MedindoAfebre
    {
        public static string nome;
        public static int qt_adquirida;
        public static double preco_unit,total_pagar,desconto,total;

        public static void Produto()
        {
            Console.WriteLine("Informe o nome do produto: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a quantidade adquirida: ");
            qt_adquirida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o preco da unidade: ");
            preco_unit = Convert.ToInt32(Console.ReadLine());
            total_pagar = qt_adquirida * preco_unit;
            if(qt_adquirida <= 5){
                desconto = total_pagar * 0.02;
                total = total_pagar - desconto;

            }else
                if(qt_adquirida >5  && qt_adquirida <= 10){
                    desconto = total_pagar * 0.03;
                    total = total_pagar - desconto ;
                }else
                    if (qt_adquirida > 10)
                    {
                        desconto = total_pagar * 0.05; 
                        total = total_pagar - desconto;
                    }
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine("Quantidade : " + qt_adquirida);
            Console.WriteLine("Preco unit: " + preco_unit);
            Console.WriteLine("total a pagar com desconto incluso: " + total);
            
        }
        static void Main1231312(string[] args)
        {
            Produto();
        }
    }
}
