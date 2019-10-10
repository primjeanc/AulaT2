using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floricultura.Model;
using Floricultura.Controller;

namespace ViewFlor
{
    class Program
    {
        static FlorController controller = new FlorController();
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
                Console.WriteLine("Floricultura Seu Botão");
                Console.WriteLine("1 - Listar Flores Cadastradas");
                Console.WriteLine("2 - Cadastrar Flor");
                Console.WriteLine("3 - Inventário Geral");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {
                    case 1:
                        ListaFlores(); Console.ReadKey();
                        break;                    
                    case 2:
                        AdicionarFLor(); Console.ReadKey();
                        break;
                    case 3:
                        {
                            RelatorioGeral();
                            Console.ReadKey();
                        }
                       
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }

        }
        public static void AdicionarFLor()
        {
            Console.WriteLine("Cadastrar Nome em sistema:");
            Console.WriteLine("Informe o Nome da Flor:");
            var novoN = Console.ReadLine();
            Console.WriteLine("Informe a quantidade:");
            var novoQ = int.Parse(Console.ReadLine());
            var resultado = controller.AddFlor(new Flor()
            { Nome = novoN, Quantidade = novoQ });
            if (resultado)
                Console.WriteLine("Cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar...");
        }

        /// <summary>
        /// Metodo para listar flores cadastrados
        /// </summary>
        public static void ListaFlores()
        {
            string template = "ID: {0,-3} | Nome: {1,-20} | Quantidade {2,5}";
            controller.GetFlores().ToList<Flor>().ForEach(v =>
            Console.WriteLine(String.Format(template, v.Id, v.Nome, v.Quantidade)));

        }
        public static void RelatorioGeral()
        {
            string template = "ID: {0,-3} | Nome: {1,-20} | Quantidade {2,-3}";
            controller.GetFlores().OrderByDescending(x => x.Quantidade).ToList<Flor>().ForEach(v =>
            Console.WriteLine(String.Format(template, v.Id, v.Nome, v.Quantidade)));

            var totalFlores = controller.GetFlores().Sum(x => x.Quantidade);
            Console.WriteLine($"Total de flores em estoque {totalFlores} unidades");

        }

    }
}
