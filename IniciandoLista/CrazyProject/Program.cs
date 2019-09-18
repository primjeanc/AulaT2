using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyProject
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public static void MinhaArvoreFeia()
        {
            Console.Clear();

            Console.WriteLine(@"  
                 @@@@,
       ,,,.   ,@@@@@@/@@,  .oo8888o.
    ,&%%&%&&%,@@@@@/@@@@@@,8888\88/8o
   ,%&\%&&%&&%,@@@\@@@/@@@88\88888/88'
   %&&%&%&/%&&%@@\@@/ /@@@88888\88888'        
   %&&%/ %&%%&&@@\ V /@@' `88\8 `/88'         _._
   `&%\ ` /%&'    |.|        \ '|8'        .-'66||        ,;'
       |o|        | |         | |         (O  ,:|/.----..;'
       |.|        | |         | |           `=' \_  ____  |      
       | |        | |         | |                |||   |||
    \\/ ._\//_/__/  ,\_//__\\/.  \_//__/_        mm'   mm'        |");
     
            Limpeza();

        }
        public static void CalculoAQuad()
        {
            Console.Clear();
            Console.WriteLine("Cálculo de área do Quadrado");
            Console.WriteLine("Informe dimensão:");
            var lado = double.Parse(Console.ReadLine());
            var areaT = lado * lado;
            Console.WriteLine($"Área Total {areaT} m²");
            Limpeza();

        }
        public static void ListaCervejas()
        {
            Console.Clear();
            var minhaLista = new List<string>();

            minhaLista.Add("Budweiser");
            minhaLista.Add("Corona");
            minhaLista.Add("Stella Artois");
            minhaLista.Add("Franziskaner");
            minhaLista.Add("Original");

            minhaLista.ForEach(i => Console.WriteLine(i)); //foreach simplificado para lista/coleções
            Limpeza();

        }
        public static void ListaCarros()
        {
            Console.Clear();
            var minhaLista = new List<string>();

            minhaLista.Add("Toyota");
            minhaLista.Add("Honda");
            minhaLista.Add("Ford");
            minhaLista.Add("Hyundai");
            minhaLista.Add("Nissan");
            minhaLista.Add("Volkswagen");

            minhaLista.ForEach(i => Console.WriteLine(i)); //foreach simplificado para lista/coleções
            Limpeza();
        }
        public static void Limpeza()
        {
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        /*Crazy project - Um projeto

1 - Metodo que mostra a arvore
2 - Metodo de calculo de área de um quadrado 
3 - Metodo para Listar as cervejas "nem preciso falar nada né pessoal"
4 - Metodo para Listar 5 marca de carros no minimo
*/

    }
}
