using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NomesLibrary.Model;
using NomesLibrary.Controller;

namespace View
{
    class Program
    {
        static NomeController controller = new NomeController();
        static void Main(string[] args)
        {
            MostraMenuSistema();

        }

        private static void MostraMenuSistema()
        {

            var opcao = int.MinValue;//variavel iniciada com menor valor de int possivel

            while (opcao != 0)//Menu em LOOP até que aperte 0 "zero"
            {
                Console.Clear();
                //Mostras as opcoes do menu em sistema
                Console.WriteLine("Menu Sistema:");
                Console.WriteLine("1 - Listar Nomes Cadastrados");
                Console.WriteLine("2 - Cadastrar Nome");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {
                    case 1:
                        ListaNomes();Console.ReadKey();
                        break;
                    case 2:
                        AdicionarNome(); Console.ReadKey();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }
            /// <summary>
            /// metodo que adiciona nomes ao bando de dados
            /// </summary>


        }

        public static void AdicionarNome()
        {
            Console.WriteLine("Cadastrar Nome em sistema:");
            Console.WriteLine("Informe o Nome:");
            var novo = Console.ReadLine();
            var resultado = controller.AddNome(new Nome()
            { NomeC = novo });
            if (resultado)
                Console.WriteLine("Nome cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar...");

        }

        /// <summary>
        /// Metodo para listar nomes cadastrados
        /// </summary>
        public static void ListaNomes()
        {
            string template = "ID: {0,-3} | Nome: {1,-35}";
            controller.GetNomes().ToList<Nome>().ForEach(v =>
            Console.WriteLine(String.Format(template, v.Id, v.NomeC)));

        }
    }
}
