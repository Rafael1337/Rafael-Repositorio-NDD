using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6
{
    class Complementar6Exe2
    {
        public static string Nome, Senha,Versenha;
        public static int Dia,Mes,Ano;
        public static void Cadastro()
        {
            Console.WriteLine("Informe o nome de usuario: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Informe a senha: ");
            Senha = Console.ReadLine();

            Console.WriteLine("informe o dia: ");
            Dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o mes: ");
            Mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o ano: ");
            Ano = Convert.ToInt32(Console.ReadLine()); 
        }
        public static void Acesso()
        {             
            
            Console.WriteLine("INFORME A SENHA DO LOGIN");
            Console.WriteLine("Senha: ");
            Versenha = Console.ReadLine();

            System.DateTime dt = new System.DateTime(Ano, Mes , Dia);
            int dt2 =  DateTime.Now.Day;
            if (dt2 - Dia >= 15)
            {
                Console.WriteLine("Senha Expirada");
                Cadastro();
                Acesso();
            }else
            if (Senha == Versenha)
            {
                Console.WriteLine("Acesso permitido");
            }
            else
                Console.WriteLine("Acesso negado");
            
        }
        static void Main4141(string[] args)
        {
            Cadastro();
            Acesso();

        }
    }
}
