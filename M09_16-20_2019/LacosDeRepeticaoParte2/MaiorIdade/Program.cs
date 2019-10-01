using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            PesSplitList();
        }
        private static void PesSplitList()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Cadastrados no sistema:");
            foreach (var item in listaDeInformacoes)
            {
                //if (item.Split(',')[1] >= 18)
            
                Console.WriteLine(item.Split(',')[0]);
            }
            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');
                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];
                

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} possui {idade} anos.");
                }
            }
            Console.ReadKey();
        }
    }
}
