using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoasVProf.Controller;
using ListandoPessoasVProf.Model;

namespace ListandoPessoasVProf
{
    class Program
    {
        static void Main(string[] args)
        {
            //aqui carregamos nossa caixa de ferramentas de pessoas, podendo assim listar e usar demais funcionalidades de dentro da classe
            PessoaController pessoaController = new PessoaController();
            //inicia em memoria                    //iniciamos o construtor
            pessoaController.ListaDePessoasPublica.ForEach(i => MostraInformacoes(i));
            MostraIdentificador("Ordem Crescente Nascimento+");
            pessoaController.GetPessoasOrdenadasAsc().ForEach(i => MostraInformacoes(i));
            MostraIdentificador("Ordem Descresente Nascimento+");            
            pessoaController.GetPessoasOrdenadasDescNasc().ForEach(i => MostraInformacoes(i));
            MostraIdentificador("Filtro Carteira 500+");
            pessoaController.GetPessoasCarteiraGorda().ForEach(i => MostraInformacoes(i));
            MostraIdentificador($"Filtro: Idade Maior que {18} anos ");//caso fosse informar entrada de filtro de idade
            pessoaController.GetPessoasIdadeMaiorD().ForEach(i => MostraInformacoes(i));
            MostraIdentificador($"Filtro: Idade Menor que {16} anos ");
            pessoaController.GetPessoasIdadeMenorD().ForEach(i => MostraInformacoes(i));


            Console.ReadKey();
        }
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("---- {0,20} -----------------", nomeAcao));
        }

        /// <summary>
        /// Metodo que mostra no onsole formatado nosso objeto pessoa
        /// </summary>
        /// <param name="pessoa"></param>
        private static void MostraInformacoes(Pessoa pessoa)
        {
            string template = "Id {0,-3} Nome {1,10} Nascimento {2,10} Carteira {3,8}";//usar '-'(menos/negativo) formata o dado a esquerda
            string textoFormatado = //string.Format é usado para formatar as string deixando o texto organizado
                string.Format(template, pessoa.Id, pessoa.Nome,pessoa.DataNascimento.ToShortDateString(),pessoa.Carteira.ToString("C2"));
            Console.WriteLine(textoFormatado);
            #region comentarios stringFormat
            //em {0,-3} {1,..}.. o 0,1 etc é a variavel retornada que foi declarada em 
            //textoFormatado( template, pessoa.Id, pessoa.Nome,...)pessoaID eh "0", Nome eh "1" etc
            //ToShortDate.. oculta hh/mm/ss da data original
            //ToString("C2") fixa 2 casas decimais e formata como dinheiro na impressao
            //n precisava quebrar a WriteLine assim, mas fica visualmente mais claro
            #endregion
        }
    }
}
