using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03NomeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3 - Criar um console app que solicite o nome e a idade, e após informar nome e idade o mesmo
            deverá apresentar quando maior ou igual a 18 anos a seguinte informação:
            "Parabéns {nome} você já esta na fase adulta."
            caso menor de 18 anos o mesmo deverá apresentar a seguinte informação:
            "Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade."*/
            SBemVindo();
            string nome = string.Empty;
            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            AskAge(nome);
            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();

        }
        /// <summary>
        /// Mensagem Bem Vindo
        /// </summary>
        public static void SBemVindo()
        {
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("Você poderia me informar alguns dados?");
        }
        private static int AskAge(string nome)//VOID n possui 'return' pois apenas executa a tarefa mas nao guarda resultado
        {
            Console.WriteLine("Quantos anos você tem?");
            int idadeP = int.Parse(Console.ReadLine());//intParse pega a String e retorna numero
            if (idadeP >= 18)
            {
                Console.WriteLine($"Parabéns {nome} você já esta na fase adulta.");
            }
            else
                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");
            return idadeP;
        }
       
    }
}
