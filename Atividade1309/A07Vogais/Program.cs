using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            TextoEntrada();
            var textoV = string.Empty;
            textoV = Console.ReadLine();
            int contA = 0;
            int contE = 0;
            int contI = 0;
            int contO = 0;
            int contU = 0;

            for (int i = 0; i < textoV.Length; i++)
            {

                if (textoV[i].ToString() == "a")
                    contA++;

                else
                    if (textoV[i].ToString() == "e")
                {
                    contE++;
                     }
                else
                        if (textoV[i].ToString() == "i")
                {
                    contI++;
                          }
                else
                        if (textoV[i].ToString() == "o")
                        {
                              contO++;
                        }
                else
                        if (textoV[i].ToString() == "u")
                         {
                             contU++;
                         }
            }
            Console.WriteLine("Segue relação de vogais informadas na palavra/texto:}");
            Console.WriteLine($"a:{contA}");
            Console.WriteLine($"e:{contE}");
            Console.WriteLine($"i:{contI}");
            Console.WriteLine($"o:{contO}");
            Console.WriteLine($"u:{contU}");
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
