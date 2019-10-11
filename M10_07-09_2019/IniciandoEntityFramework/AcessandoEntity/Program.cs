using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoaController = new PessoaController();
        static void Main(string[] args)
        {
            AddPessoa();

            //pessoaController.AddPessoa(new Pessoa() { Nome = "motocicleiton" });

            MostraLista();


            Console.ReadKey();
        }
        /// <summary>
        /// Listar os nomes salvos na tabela do Banco de Dados/programa
        /// </summary>
        public static void MostraLista()
        {
            pessoaController.GetPessoas().ToList<Pessoa>().ForEach(x => Console.WriteLine(x.Nome));
        }
        public static void AddPessoa()
        {
            Pessoa pessoa = new Pessoa { Nome = "Jean" };//
            pessoaController.AddPessoa(pessoa);

        }
    }
}
