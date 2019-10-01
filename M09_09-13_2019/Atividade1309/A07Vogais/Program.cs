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
            textoV = Console.ReadLine().ToLower();
            int contA = textoV.Split('a').Length - 1;//split para encontrar e contar caractere
            int contE = textoV.Split('e').Length - 1;
            int contI = textoV.Split('i').Length - 1;
            int contO = textoV.Split('o').Length - 1;
            int contU = textoV.Split('u').Length - 1;

            /*  versao mais burra mas que atende acentuação
            for (int i = 0; i < textoV.Length; i++)
            {
                Console.WriteLine("Informe o caracter/vogal a ser contado:");


                if (textoV[i].ToString() == "a"|| textoV[i].ToString() == "á"|| textoV[i].ToString() == "â"|| textoV[i].ToString() == "ã")
                    contA++;

                else
                    if (textoV[i].ToString() == "e"|| textoV[i].ToString() == "é"|| textoV[i].ToString() == "ê")
                {
                    contE++;
                     }
                else
                        if (textoV[i].ToString() == "i"|| textoV[i].ToString() == "í")
                {
                    contI++;
                          }
                else
                        if (textoV[i].ToString() == "o"|| textoV[i].ToString() == "ó"|| textoV[i].ToString() == "ô"|| textoV[i].ToString() == "õ")
                        {
                              contO++;
                        }
                else
                        if (textoV[i].ToString() == "u"|| textoV[i].ToString() == "ú"|| textoV[i].ToString() == "ü")
                         {
                             contU++;
                         }
            }*/

            Console.WriteLine("Segue relação de vogais informadas na palavra/texto:}");
            Console.WriteLine($"a:{contA}");
            Console.WriteLine($"e:{contE}");
            Console.WriteLine($"i:{contI}");
            Console.WriteLine($"o:{contO}");
            Console.WriteLine($"u:{contU}");
            int somaVog;
            somaVog = (contA + contE + contI + contO + contU);
            Console.WriteLine($"Total de vogais:{somaVog}");
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
