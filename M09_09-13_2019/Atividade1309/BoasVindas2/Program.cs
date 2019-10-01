using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoasVindas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Criar um console app que apresente as boas vindas, solicite o nome do usuário. completo e
            //mostre uma mensagem de boas vindas com o nome do usuário.
            SBemVindo();          
            var nomeCompleto = Console.ReadLine();
            Console.WriteLine($"Olá {nomeCompleto}");
            Console.ReadKey();
        }
        public static void SBemVindo()
        {
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("Qual seu nome?");
        }
      
    }
}
