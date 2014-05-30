using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajuda
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("##############   MENU AJUDA (?)  #################");
            Console.WriteLine("Selecione uma das opções abaixo para obter ajuda sobre a funcionalidade");
            Console.WriteLine("1 - CADASTRO DE PROVAS");
            Console.WriteLine("2 - GERAR GABARITOS");
            Console.WriteLine("3 - EXIBIR QUESTÕES OBJETIVAS");
            Console.WriteLine("4 - EXIBIR QUESTÕES DESCRITIVAS");
            Console.WriteLine("5 - EXIBIR GABARITO");
            Console.WriteLine("6 - EDITAR OBJETIVAS");
            Console.WriteLine("7 - EDITAR DESCRITIVAS");
            Console.WriteLine("8 - REMOVER ENUNCIADO DESCRITIVAS");
            Console.WriteLine("9 - REMOVER ENUNCIADO OBJETIVAS");
            Console.WriteLine("10 - EXIBIR EXEMPLO DE PROVAS");
            Console.WriteLine("0 - RETORNAR AO MENU PRINCIPAL");
            Console.WriteLine("");
            Console.WriteLine("Informe a opção que deseja: ");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Realiza o cadastro da prova que deseja a partir de descritivas com seu enunciados, e objetivas com seus enunciados suas alternativas de A a E com uma opção correta.");
                    break;
                case 2:
                    Console.WriteLine("Gera o gabarito das provas objetivas cadastradas e sua opção certa, e também gera a resposta das descritivas.");
                    break;
                case 3:
                    Console.WriteLine("Exibe as questões objetivas anteriormente cadastradas pelo usuário (Questões objetivas possuem enunciado e opções de A a E e possuem somente uma correta)");
                    break;
                case 4:
                    Console.WriteLine("Exibe as questões descritivas anteriormente cadastradas pelo usuário (Possuem um enunciado da pergunta e uma resposta descrita)");
                    break;
                case 5:
                    Console.WriteLine("Exibe gabarito com respostas das questões objetivas respectivamente opontadas com uma opção de A a E , e descritivas com a resposta escrita");
                    break;
                case 6:
                    Console.WriteLine("Edita as respostas lternativas (A a E) colocadas como correta na resposta da questão");
                    break;
                case 7:
                    Console.WriteLine("Edita as respostas nas perguntas descritivas colocadas anteriormente");
                    break;
                case 8:
                    Console.WriteLine("Remove o enunciado da questão descritiva, a pergunta anteriormente posta");
                    break;
                case 9:
                    Console.WriteLine("Remove o enunciado da questão objetiva, a pergunta anteriormente posta");
                    break;
                case 10:
                    Console.WriteLine("Exibir provas ja elaboradas staticamente de exemplo");
                    break;
                case 0:
                    MostraMenu();
                    break;

            }

        }
    }
}
