using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTestando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe sequência numérica");
            var textContent = Console.ReadLine();
            Console.WriteLine(textContent.Replace("3", "banana"));
            Console.ReadKey();
        }
    }
}
