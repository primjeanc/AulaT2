using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;

namespace CellDu
{
    class Program
    {
        static CelularController controller = new CelularController();
        // start up console, referenciar classes, add entity (nuggets)
        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while (opcao != 0)//fica no menu inicial do programa
            {
                //menu inicial
                Console.WriteLine("Menu de Opções");
                Console.WriteLine("[1] Cadastrar Celular");
                Console.WriteLine("[2] Listar Produtos cadastrados");
                Console.WriteLine("[3] Atualizar Produtos");
                Console.WriteLine("[4] Remover Produtos");
                Console.WriteLine("[0] Sair");
                //informar opcao
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //opcao escolhida
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        AdicionarCelular();
                        break;

                    case 2:
                        Console.Clear();
                            MostraCelular();
                        break;
                    case 3:
                        Console.Clear();
                        AtualizarCelular();
                        break;
                    case 4:
                        Console.Clear();
                        RemoverCelular();
                        break;

                    default://caso informe opcao invalida
                        //Console.WriteLine("Opção Inválida ");
                        break;

                }
                Console.WriteLine("Pressione qualquer tecla ...");
                Console.ReadKey(true);
                Console.Clear();//limpar tela antes de voltar ao menu inicial
            }

        }

        //inserir
        /// <summary>
        /// Metodo para adicionar/cadastrar celular
        /// </summary>
        public static void AdicionarCelular()
        {
            Console.WriteLine("Cadastrar Celular");
            Console.WriteLine("Informe o Marca:");
            var marca = Console.ReadLine();
            Console.WriteLine("Informe o Modelo:");
            var modelo = Console.ReadLine();
            Console.WriteLine("Informe o Valor do aparelho:");
            var preco = double.Parse(Console.ReadLine());

            var resultado = controller.AddCelular(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });
            if (resultado)
                Console.WriteLine("Celular cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar aparelho...");

        }
        //atualizar
        public static void AtualizarCelular()
        {
            Console.WriteLine("Atualizar Celular");
            MostraCelular();//mostra a lista para identificar o ID que sera alterado
            Console.WriteLine("Informe o ID do produto a ser alterado:");
            var celId = int.Parse(Console.ReadLine());//informa ID para alterar
            //cria variavel para comparar e encontra ID
            var celular = controller.GetCelulares().FirstOrDefault(x => x.Id == celId);

            
            if (celular == null)
            {
                Console.WriteLine("ID informado inválido");
                return;
            }

            Console.WriteLine("Informe o Marca:");
            celular.Marca = Console.ReadLine();
            Console.WriteLine("Informe o Modelo:");
            celular.Modelo = Console.ReadLine();
            Console.WriteLine("Informe o Valor do aparelho:");
            celular.Preco= double.Parse(Console.ReadLine());

            var resultado = controller.AtualizarCelular(celular);
            // apenas mostra mensagem ao final da tentativa de atualizar um produto
            if (resultado)
                Console.WriteLine("Produto Atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar produto.");

            

        }
        //remover
        public static void RemoverCelular()
        {
            Console.WriteLine("Remover produto");
            MostraCelular();//mostra a lista para identificar o ID que sera alterado
            Console.WriteLine("Informe o ID do produto a ser removido:");
            var celId = int.Parse(Console.ReadLine());//informa ID para alterar

            var resultado = controller.RemoverCelular(celId);
            if(resultado)
                Console.WriteLine("Produto removido com sucesso!");
            else
                Console.WriteLine("Erro ao remover produto.");
            //MostraCelular();
            //Console.ReadKey();

        }

        //listar
        /// <summary>
        /// Lista todos os produtos cadastrados com status ativo
        /// </summary>
        public static void MostraCelular()
        {

            controller.GetCelulares().ToList<Celular>().ForEach(x => Console.WriteLine($"ID: {x.Id} Marca {x.Marca} Modelo {x.Modelo} Preço {x.Preco}"));

        }
    }
}
