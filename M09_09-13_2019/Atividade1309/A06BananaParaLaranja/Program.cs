using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A06BananaParaLaranja
{
    class Program
    {
        static void Main(string[] args)
        {
            TextoEntrada();
            TrocaFruta();
            TextoSaida();

        }
        public static void TextoEntrada()
        {
            Console.WriteLine("///Criar um console app que quando informado o texto contendo banana ele troque esta informação por laranja.");
            Console.WriteLine("Informe uma frase ou texto contendo a palavra 'banana'");
        }
        public static void TextoSaida()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para finalizar");
            Console.ReadKey();
        }
        public static void TrocaFruta()
        {
            var textoBanana = string.Empty;
            var textoLaranja = string.Empty;
            textoBanana = Console.ReadLine();
            textoLaranja = (textoBanana.Replace("banana", "laranja").Replace("Banana", "Laranja"));

            Console.WriteLine("Entendi, mas como eu prefiro laranjas, tomei a libertade de corrigir seu texto.");
            Console.WriteLine(textoLaranja);
        }
    }
}
