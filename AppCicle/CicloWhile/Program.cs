using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0;

            while (AskToContinue() == 1)//perguntas comprimidas em metodos
            {
                nome = AskName();
                idade = AskAge();
            }
            Console.WriteLine($"Suas informações > Nome: {nome} e sua idade: {idade}");
            Console.ReadKey();
        }
        /// <summary>
        /// Método para mostrar texto inicial do sistema ForeverAlone
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("-------------------");
        }
        /// <summary>
        /// Método para realizar a pergunta Se deseja continuar
        /// </summary>
        /// <returns></returns>
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim(1) não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());//KeyChar le o valor da tecla utilizada,ReadKey le apenas'tecla'.
            //'int.Parse' converte para INT
        }
        private static int AskAge()//VOID n possui 'return' pois apenas executa a tarefa mas nao guarda resultado
        {
            Console.WriteLine("Quantos anos você tem?");
            int idadeP = int.Parse(Console.ReadLine());//intParse pega a String e retorna numero
            if (idadeP >= 18)
            {
                Console.WriteLine("Já pode beber então kkkkk");
            }
            else
                Console.WriteLine("Menor de idade? Melhor tomar um refri, desde que não seja da marca que não podemos citar kkkkk");
            return idadeP;
        }
        /// <summary>
        /// Pergunta nome
        /// </summary>
        /// <returns>retorna nome informado</returns>
        private static string AskName()
        {
            Console.WriteLine("Qual seu nome?");
            return Console.ReadLine();
        }
    }
}
