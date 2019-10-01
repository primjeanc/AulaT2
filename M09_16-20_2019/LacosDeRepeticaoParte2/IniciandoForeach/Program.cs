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
            ConsultaCarros(); //VP versao professor, recap
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
        /// <summary>
        /// Consulta para carros, *texto ja inserido
        /// </summary>
        private static void ConsultaCarros()
        {
            //Base de informações
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";

            ListarInformacoesPorNome(conteudo);

            Console.WriteLine("Digite o nome do carro para a busca:");
            var nomeCarro = Console.ReadLine();

            var veiculoSelecionado = RetornaVeiculo(conteudo, nomeCarro);

            Console.WriteLine(string.Format("O carro {0} é da marca {1} fabricado no ano {2}", veiculoSelecionado));

            Console.ReadKey();
        }
        private static void ConsultaPessoa()
        {
            //Base de informações
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

            ListarInformacoesPorNome(conteudo);

            Console.WriteLine("Digite o nome do carro para a busca:");
            var nomePessoa = Console.ReadLine();

            var pessoaSelecionado = RetornaVeiculo(conteudo, nomePessoa);

            Console.WriteLine(string.Format("O carro {0} é da marca {1} fabricado no ano {2}", pessoaSelecionado));

            Console.ReadKey();
        }
        /// <summary>
        /// listar veículos cadastrados
        /// </summary>
        /// <param name="conteudo"></param>
        private static void ListarInformacoesPorNome(string conteudo)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');
                var nomeCarro = separandoInformacoes[0].Split(':')[1];

                Console.WriteLine($"Nome do carro {nomeCarro}");
            }
        }
        private static string[] RetornaVeiculo(string conteudo, string nomeVeiculo)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');

                var nomeDoCarro = ObterValor(separandoInformacoes[0]);

                if (nomeDoCarro == nomeVeiculo)
                    return separandoInformacoes;
            }

            return new string[0];
        }
        private static string[] RetornaPessoa(string conteudo, string nomePessoa)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');

                var nomeDaPessoa = ObterValor(separandoInformacoes[0]);

                if (nomeDaPessoa == nomePessoa)
                    return separandoInformacoes;
            }

            return new string[0];
        }
        private static string ObterValor(string colecao)
        {
            return colecao.Split(':')[1];
        }
    }
}
