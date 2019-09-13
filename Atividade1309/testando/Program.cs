using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testando
{
    class Program
    {
        static void Main(string[] args)
        {
            TextoEntrada();
            var textoV = string.Empty;
            textoV = Console.ReadLine().ToLower();
            int contZ = 0;
            string caracZ;

            Console.WriteLine("Informe o caracter/vogal a ser contado:");
            for (int i = 0; i < textoV.Length; i++)
            {
                
                caracZ = Console.ReadLine();

                if (textoV[i].ToString() == caracZ)
                    contZ++;
                   
            }

            Console.WriteLine("Segue relação de vogais informadas na palavra/texto:}");
            Console.WriteLine($"{caracZ}:{contZ}");


            TextoSaida();
        }
        public static void TextoEntrada()
        {
            Console.WriteLine("///Criar um console app conte a quantidade de vogais ('a'e'i'o'u') dentro de um texto informado pelo usuário..");
            Console.WriteLine("Informe uma frase ou texto");
        }
        public static void TextoSaida()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
