using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Texto informativo para consultar o livro pelo numero de registro do sistema
            Console.WriteLine("Informe o livro a ser consultado:");
            /*Parte do codigo que recebe as informações de registro do livro */
            var numeroDoLivro = Console.ReadLine();
            //Aqui realizo a comparação das informações do livro informado com o disponível em estoque
            if (numeroDoLivro == "123456")
            {
                //Informo que este livro já está locado
                Console.WriteLine("Livro Indisponível");
                Console.ReadKey();
                //Finaliza o método
                return;
            }
            else
            {
                Console.WriteLine("Deseja locar o livro? (1)sim (2)não");
                var resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    Console.WriteLine("Livro locado");
                    Console.ReadKey();
                    return;
                }
            }
            
                        
            
        }
    }
}
