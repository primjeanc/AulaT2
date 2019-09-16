using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplitLista();
        }
        /// <summary>
        /// Metodo que mostra como podemos utilizar o foreach para andar sobre
        /// uma array de caracteres, ou seja um texto, palavra etc...
        /// </summary>
        private static void IniciandoForeach01()
        {
            Console.WriteLine("Informar o texto:");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e')
                    continue; //pula caractere e retorna verificacao no proximo caractere
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static void ForeachComSplit()
        {
            var conteudoDoTexto = "Aqui vou colocar meu nome Felipe para realizar a busca";
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';');//separa o texto por 'espacos' nesse caso
            //separando o texto em palavras, onde cada palavra vira um item do indice ao inves de um caractere

            foreach (var item in conteudoTextoSplit)
            {
                if(palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Split separando o texto por ';', informando seu nome criando uma lista de palavras
        /// </summary>
        private static void ForeachComSplit2()
        {
            Console.WriteLine("Informe seu nome");
            var seunome = Console.ReadLine();
            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe;vamos;colocar;isto;{seunome};para;depois;usar;com;o;replace";
            Console.WriteLine("Informe a palavra para realizar a busca");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';');//separa o texto por 'espacos' nesse caso
            //separando o texto em palavras, onde cada palavra vira um item do indice ao inves de um caractere

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Usando REGEX para testar e contar numero de vezes que a 'palavra' de entrada é usada
        /// </summary>
        /// <param name="seunome"></param>
        private static void ForeachComSplit3()
        {
            Console.WriteLine("Informe seu nome");
            var seunome = Console.ReadLine();
            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe;vamos;colocar;isto;{seunome};para;depois;usar;com;o;replace";
            Console.WriteLine("Informe a palavra para realizar a busca");
            var palavra = Console.ReadLine();

            Regex testeRegex = new Regex(palavra);//funcao para testar e contar palavra/caractere
            Console.WriteLine($"Palavra '{palavra}' encontrada {testeRegex.Matches(conteudoDoTexto).Count.ToString()} vez(es)");
            //'''testeRegex.Matches(conteudoDoTexto).Count.ToString()''' 
            Console.ReadKey();
            
        }
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";
            var listaDeInformacoes = conteudo.Split(';');//primeiro split separa usuarios por ;

            Console.WriteLine("Usuários cadastrados no sistema:");
            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);//segundo split separa as informacoes de cada um com ,
            }
            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();
            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');
                var nome = informacoesSplit[0].Split(':')[1];// esse split separa o 'nome:Gilmar' pelo ':' chamando [1] giomar 
                var idade = informacoesSplit[1].Split(':')[1];// esse split separa o 'idade:75' pelo ':'
                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
                }
            }
            Console.ReadKey();
        }
        private static void CarSplitList()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";
            var listaDeInformacoes = conteudo.Split(';');
        }
    }
}
