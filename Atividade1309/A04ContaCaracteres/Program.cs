using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A04ContaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Criar um console app que apresente a quantidade total de caracteres que contém em um texto informado
            pelo usuário.*/
            TextoEntrada();
            string textoCompleto = string.Empty;
            textoCompleto = Console.ReadLine();
            var contaEsp = 0;
            int i = 0;
            while (i < (textoCompleto.Length))
            {
                var palavraBusca = textoCompleto[i].ToString();
                i++;
                if (palavraBusca == " ")
                    contaEsp++;
            }               
            Console.WriteLine($"A informação inserida possui {textoCompleto.Length} caracteres considerando espaços em branco");
            Console.WriteLine($"A informação inserida possui {(textoCompleto.Length-contaEsp)} sem espaços em branco");
            TextoSaida();
        }
        public static void TextoEntrada()
        {
            Console.WriteLine("///Criar um console app que apresente a quantidade total de caracteres que contém em um texto informado pelo usuário.");
            Console.WriteLine("Informe uma letra, número, palavra ou texto:");
        }
        public static void TextoSaida()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
