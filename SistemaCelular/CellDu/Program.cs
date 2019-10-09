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
                Console.WriteLine("[2] wtf");
                Console.WriteLine("[0] Sair");
                //informar opcao
                opcao = int.Parse(Console.ReadLine());
                //opcao escolhida
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        AdicionarCelular();
                        break;

                    case 2:
                        break;
                    default://caso informe opcao invalida
                        Console.WriteLine("Opção Inválida ");
                        break;

                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                Console.ReadKey(true);
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

        //remover

        //listar

    }
}
