using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05PrimeiroUltimo
{
    class Program
    {
        static void Main(string[] args)
        {
            TextoEntrada();
            string textoCompleto = string.Empty;
            textoCompleto = Console.ReadLine();
            string primeiroC;
            string segundoC;
            primeiroC = textoCompleto[0].ToString();
            segundoC = textoCompleto[(textoCompleto.Length -1)].ToString();
            Console.WriteLine($"O primeiro caractere informado foi: '{primeiroC}' e o segundo caractere foi: '{segundoC}'");
            TextoSaida();
        }
        public static void TextoEntrada()
        {
            Console.WriteLine("///Criar um console app que apresente o primeiro e o ultimo caractere de uma palavra informada.");
            Console.WriteLine("Informe uma letra, número, palavra ou texto:");
        }
        public static void TextoSaida()
        {
            Console.WriteLine("Aperte qualquer tecla para finalizar");
            Console.ReadKey();
        }
       
    }
}
