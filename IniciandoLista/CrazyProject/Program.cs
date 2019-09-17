using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaArvoreFeia();
            CalculoAQuad();
            ListaCervejas();
        }
        public static void MinhaArvoreFeia()
        {
            Console.WriteLine("     |");
            Console.WriteLine("    (|)");
            Console.WriteLine("   ((|))");
            Console.WriteLine(" ()()|()()");
            Console.WriteLine("(()()|()())");
            Console.WriteLine(" ()()|()()");
            Console.WriteLine("     |");
            Console.WriteLine("     |");
            Console.WriteLine(" __//|\\__");

            Console.ReadKey();
        }
        public static void CalculoAQuad()
        {
            Console.WriteLine("Cálculo de área do Quadrado");
            Console.WriteLine("Informe dimensão:");
            var lado = double.Parse(Console.ReadLine());
            var areaT = lado * lado;
            Console.WriteLine($"Área Total {areaT} m²");
            Console.ReadKey();
        }
        private static void ListaCervejas()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("Budweiser");
            minhaLista.Add("Corona");
            minhaLista.Add("Stella Artois");
            minhaLista.Add("Franziskaner");
            minhaLista.Add("Original");

            minhaLista.ForEach(i => Console.WriteLine(i)); //foreach simplificado para lista/coleções
            Console.ReadKey();
        }
        /*Crazy project - Um projeto

1 - Metodo que mostra a arvore
2 - Metodo de calculo de área de um quadrado 
3 - Metodo para Listar as cervejas "nem preciso falar nada né pessoal"
4 - Metodo para Listar 5 marca de carros no minimo
*/

    }
}
