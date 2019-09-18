using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiBlioteca;

namespace AcessandoDllDoAmiguinho
{
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
                    { AnimacoesEmFrames.Arvoree(); MenuClasses(); } //arvore
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
                    { listaDeCervejas.listaAmbev(); ListaMarcas(); }
                    break;
                case "2":
                    { ListaDeCarros.Listacar(); ListaMarcas(); }
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
            var ladoQuad = int.Parse(Console.ReadLine());
            var bibliotecaCalculos = new CalculosDeArea();

            Console.WriteLine($"Minha área é {bibliotecaCalculos.CalculaAreaDoQuadrado(ladoQuad)} unid²");
            Console.ReadKey();
        }
        /// <summary>
        /// tudo isso vai no main se n usar classes
        /// </summary>
        

    }
}
