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
        private static void MenuClasses()//menu usando biblioteca de classes
        {
            var escolha = string.Empty;
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
                    { MyFuckingTree.StupidTree(); } 
                    break;
                case "2":
                    { CalculoArea(); MenuClasses(); }
                    break;
                case "3":
                    { Cervejas.ClasseListaCervejas(); }                    
                    break;
                case "4":
                    { MontadorasCarros.ClasseListaCarros(); }
                    break;
                case "5":
                    {
                        Console.WriteLine("Saindo...");
                        return;
                    }                    
                default:
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
