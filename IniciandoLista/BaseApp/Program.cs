using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblicoteca;

namespace BaseApp
{//Interação BaseApp e CrazyProject // BaseApp e classes
    class Program
    {
        static void Main(string[] args)
        {
            MenuClasses();//versao classe

        }
        /// <summary>
        /// Menu de opcoes utlizando classes
        /// </summary>
        private static void MenuClasses()//menu usando biblioteca de classes
        {
            var escolha = string.Empty;
            Console.WriteLine("*#*#*#*#*#*#*#*#*#*#**#*#*#*#*");
            Console.WriteLine("Menu de Opções disponíveis:");
            Console.WriteLine("[1]Árvore");
            Console.WriteLine("[2]Área de Quadrado");
            Console.WriteLine("[3]Listas Cadastradas");
            //Console.WriteLine("[4]Marcas de Carros mais procurados:");
            Console.WriteLine("[4]Sair:");
            escolha = Console.ReadKey().KeyChar.ToString();

            switch (escolha)
            {
                case "1":
                    { MyFuckingTree.StupidTree(); MenuClasses(); } //arvore
                    break;
                case "2":
                    { CalculoArea(); MenuClasses(); }//calc area quadrado
                    break;
                case "3":
                    { Console.Clear(); ListaMarcas(); }    //abre sub menu de listas cerveja/carro                
                    break;
                /*case "4":
                    { MontadorasCarros.ClasseListaCarros(); }
                    break;*/
                case "4":
                    {
                        Console.WriteLine("Saindo...");
                        return;
                    }
                default:
                    { Console.Clear(); MenuClasses(); }
                    break;
            }

        }
        private static void ListaMarcas()
        {
            var escolha = string.Empty;
            Console.WriteLine("*#*#*#*#*#*#*#*#*#*#**#*#*#*#*");
            Console.WriteLine("Menu de Opções disponíveis:");
            Console.WriteLine("[1]Listar Cervejas cadastradas");
            Console.WriteLine("[2]Listar Marcas de carro cadastradas");            
            Console.WriteLine("[3]Retonar ao menu inicial:");
            escolha = Console.ReadKey().KeyChar.ToString();

            switch (escolha)
            {
                case "1":
                    { ListaDeMarcas.ClasseListaCervejas(); ListaMarcas(); }
                    break;
                case "2":
                    { ListaDeMarcas.ClasseListaCarros(); ListaMarcas(); }
                    break;
                case "3":
                    {
                        Console.WriteLine("Retornar ao menu inicial");
                        MenuClasses();
                        break;
                    }
                default:
                    { Console.Clear(); ListaMarcas(); }
                    break;
            }

        }
        /// <summary>
        /// Chama classe para calculo de área e retorna resultado
        /// </summary>
        public static void CalculoArea()
        {
            Console.WriteLine("Informe o lado do quadrado:");
            var ladoQuad = double.Parse(Console.ReadLine());
            var bibliotecaCalculos = new CalculoDeArea();

            Console.WriteLine($"Minha área é {bibliotecaCalculos.CalculaAreaQuad(ladoQuad)} unid²");
            Console.ReadKey();
        }
        /// <summary>
        /// tudo isso vai no main se n usar classes
        /// </summary>
        public static void MenuMain()//Este seria o MAIN caso use ''apenas'' os metodos!!!
        {
            var escolha = string.Empty;
            while (escolha != "5")
            {
                Console.WriteLine("*#*#*#*#*#*#*#*#*#*#**#*#*#*#*");
                Console.WriteLine("Menu de Opções disponíveis:");
                Console.WriteLine("[1]Árvore");
                Console.WriteLine("[2]Área de Quadrado");
                Console.WriteLine("[3]Lista de Cervejas");
                Console.WriteLine("[4]Marcas de Carros mais procurados:");
                Console.WriteLine("[5]Sair:");
                escolha = Console.ReadKey().KeyChar.ToString();

                switch (escolha)
                {
                    case "1":
                        CrazyProject.Program.MinhaArvoreFeia();
                        break;
                    case "2":
                        CrazyProject.Program.CalculoAQuad();
                        break;
                    case "3":
                        CrazyProject.Program.ListaCervejas();
                        break;
                    case "4":
                        CrazyProject.Program.ListaCarros();
                        break;
                    default:
                        break;
                }

            }
        }

    }
}
