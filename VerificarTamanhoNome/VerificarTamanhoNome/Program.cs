using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarTamanhoNome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar nome");
            var nomeLeng = Console.ReadLine();
            Console.WriteLine($"O tamanho deste nome é: {nomeLeng.Replace(" ","").Length}");
            //.Length ler quantidade de caracteres na string
            //.Replace(" ","") substitui espacos ou outra informacoes conforme informados
            Console.ReadKey();
        }
    }
}
