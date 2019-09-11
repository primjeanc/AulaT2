using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactarTEXTO
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Oi meu nome Felipe e logo eu Felipe tenho vontade de codar muito porque eu " +
                "Felipe gosto de codar durante minha vida";
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");

            primeiroTexto = primeiroTexto
                .Replace("Felipe", "1")
                .Replace("codar","2");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");
            Console.ReadKey();
            Console.WriteLine("Retornando texto ao original.");
            Console.ReadKey();
            primeiroTexto = primeiroTexto
                .Replace("1", "Felipe")
                .Replace("2", "codar");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");
            Console.ReadKey();

        }
    }
}
