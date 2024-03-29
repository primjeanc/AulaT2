﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaPessoas();
        }
        private static void IniciandoForeach01()
        {
            Console.WriteLine("Informar o texto:");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e')
                    continue;

                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo de busca com split e informando o nome
        /// </summary>
        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe o seu nome:");

            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";

            Console.WriteLine("Informe a palavra para realizar a busca:");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';');

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }

            Console.ReadKey();
        }
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuários cadastrados no sistema:");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var inforacoesSplit = item.Split(',');

                var nome = inforacoesSplit[0].Split(':')[1];
                var idade = inforacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
                }
            }

            Console.ReadKey();
        }

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
        private static string ObterValor(string colecao)
        {
            return colecao.Split(':')[1];
        }
        //versao para pessoas
        //
        //
        //
        private static void ConsultaPessoas()
        {
            //Base de informações
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

            ListarValoresMaiorIdade(conteudo);

            Console.WriteLine("Digite o nome para a busca:");
            var nomePessoa = Console.ReadLine();

            var pessoaSelecionado = RetornaPessoa(conteudo, nomePessoa);

            Console.WriteLine(string.Format("{0} possui {1} anos de idade",
                ObterValor(pessoaSelecionado, "nome"),
                ObterValor(pessoaSelecionado, "idade")));

            Console.ReadKey();
        }
        private static void ListarValoresMaiorIdade(string conteudo)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');
                var nomePessoa = separandoInformacoes[0].Split(':')[1];
                var idadePessoa = int.Parse(separandoInformacoes[1].Split(':')[1]);
                if (idadePessoa >=18)
                Console.WriteLine($"Nome : {nomePessoa}");
            }
        }
        private static string[] RetornaPessoa(string conteudo, string nomePessoa)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');

                var nomeDaPessoa = ObterValor(separandoInformacoes[0]);
                var idadeDaPessoa = int.Parse(ObterValor(separandoInformacoes[1]));
                
                if (nomeDaPessoa == nomePessoa)
                    return separandoInformacoes;

            }

            return new string[0];
        }
        private static string ObterValor(string[] colecao, string tipo)
        {
            foreach (var item in colecao)
            {
                var quebrandoInformacao = item.Split(':');

                if (quebrandoInformacao[0] == tipo)
                    return quebrandoInformacao[1];
            }

            return string.Empty;
        }

    }
}