using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoasVProf.Model;

namespace ListandoPessoasVProf.Controller
{
    class PessoaController
    {
        /// <summary>
        /// lista que contem as pessoas para a atividade
        /// </summary>
        private List<Pessoa> ListaDePessoas { get; set; }
        /// <summary>
        /// O metodo construtor ajuda a iniciar nossa classe para utilizarmos de maneira
        /// correta as informações internas, com isso podemos iniiar nossa lista
        /// sem depender de usuario/programador na interface ".program"
        /// </summary>
        public PessoaController()
        {
            ListaDePessoas = new List<Pessoa>();//iniciamos a lsita de pessoas dentro do metodo construtor

            #region Ocultando lista de informações das pessoas cadastradas
            ListaDePessoas.Add(new Pessoa() { Id = 1, Nome = "Spears   ", DataNascimento = DateTime.Parse("07/11/2004"), Carteira = 846.96 });
            ListaDePessoas.Add(new Pessoa() { Id = 2, Nome = "Swanson  ", DataNascimento = DateTime.Parse("20/06/2003"), Carteira = 233.09 });
            ListaDePessoas.Add(new Pessoa() { Id = 3, Nome = "Gay      ", DataNascimento = DateTime.Parse("03/12/2001"), Carteira = 911.92 });
            ListaDePessoas.Add(new Pessoa() { Id = 4, Nome = "Gregory  ", DataNascimento = DateTime.Parse("02/01/2000"), Carteira = 469.01 });
            ListaDePessoas.Add(new Pessoa() { Id = 5, Nome = "Olson    ", DataNascimento = DateTime.Parse("18/07/2001"), Carteira = 261.90 });
            ListaDePessoas.Add(new Pessoa() { Id = 6, Nome = "Garza    ", DataNascimento = DateTime.Parse("01/04/2000"), Carteira = 360.41 });
            ListaDePessoas.Add(new Pessoa() { Id = 7, Nome = "Sweet    ", DataNascimento = DateTime.Parse("12/03/2003"), Carteira = 312.76 });
            ListaDePessoas.Add(new Pessoa() { Id = 8, Nome = "Cline    ", DataNascimento = DateTime.Parse("26/03/2002"), Carteira = 484.51 });
            ListaDePessoas.Add(new Pessoa() { Id = 9, Nome = "Oliver   ", DataNascimento = DateTime.Parse("05/07/2004"), Carteira = 513.76 });
            ListaDePessoas.Add(new Pessoa() { Id = 10, Nome = "Vang     ", DataNascimento = DateTime.Parse("10/07/2000"), Carteira = 271.05 });
            ListaDePessoas.Add(new Pessoa() { Id = 11, Nome = "Maddox   ", DataNascimento = DateTime.Parse("29/05/2004"), Carteira = 783.97 });
            ListaDePessoas.Add(new Pessoa() { Id = 12, Nome = "Garrett  ", DataNascimento = DateTime.Parse("03/06/2006"), Carteira = 154.11 });
            ListaDePessoas.Add(new Pessoa() { Id = 13, Nome = "Mcintosh ", DataNascimento = DateTime.Parse("06/07/2006"), Carteira = 902.80 });
            ListaDePessoas.Add(new Pessoa() { Id = 14, Nome = "Yang     ", DataNascimento = DateTime.Parse("29/04/2005"), Carteira = 550.48 });
            ListaDePessoas.Add(new Pessoa() { Id = 15, Nome = "Hendricks", DataNascimento = DateTime.Parse("05/09/2003"), Carteira = 410.56 });
            ListaDePessoas.Add(new Pessoa() { Id = 16, Nome = "Cain     ", DataNascimento = DateTime.Parse("12/01/2002"), Carteira = 221.13 });
            ListaDePessoas.Add(new Pessoa() { Id = 17, Nome = "Blackburn", DataNascimento = DateTime.Parse("10/05/2000"), Carteira = 135.67 });
            ListaDePessoas.Add(new Pessoa() { Id = 18, Nome = "Howe     ", DataNascimento = DateTime.Parse("27/09/2005"), Carteira = 360.14 });
            ListaDePessoas.Add(new Pessoa() { Id = 19, Nome = "Pratt    ", DataNascimento = DateTime.Parse("18/09/2000"), Carteira = 991.83 });
            ListaDePessoas.Add(new Pessoa() { Id = 20, Nome = "Sherman  ", DataNascimento = DateTime.Parse("20/02/2003"), Carteira = 667.00 });
            #endregion
            
        }
        /// <summary>
        /// Retorna nossa lista, com apenas GET, liberamos as informacoes da classe apenas como leitura, 
        /// sem dar acesso para alterar informacoes
        /// </summary>
        public List<Pessoa> ListaDePessoasPublica
        {
            get { return ListaDePessoas; }
        }
        /// <summary>
        /// Metodo que retorna lista de Pessoa ordenada de forma Crescente pelo Nome
        /// </summary>
        /// <returns>Retorna lista ja ordenada</returns>
        public List<Pessoa> GetPessoasOrdenadasAsc()
        {
            return ListaDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>();
            //ListaDePessoas - nossa lista, Orderby(...Nome) ordena crescente(ascendente) por 'Nome', 
            //ToList(Pessoa) retorna o tipo para lista pessoas
        }
        /// <summary>
        /// Metodo que retorna lista de Pessoa ordenada de forma Decrescente por DataNascimento
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> GetPessoasOrdenadasDescNasc()
        {
            return ListaDePessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>();
            //ListaDePessoas - nossa lista, Orderby(...Data) ordena decrescente por 'Nome', 
            //ToList(Pessoa) retorna o tipo para lista pessoas
        }
        /// <summary>
        /// Metodo que retorna Pessoas com saldo em Carteira 
        /// (500+) caso nao informe nada, ou inserir valor no programa
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> GetPessoasCarteiraGorda(double valor = 500)
        {
            return ListaDePessoas.FindAll(x => x.Carteira > valor).OrderBy(x=> x.Carteira).ToList<Pessoa>();
            //ListaDePessoas - nossa lista, Orderby(...Carteira) ordena decrescente por 'Nome', 
            //ToList(Pessoa) retorna o tipo para lista pessoas
        }
        /// <summary>
        /// Metodo que filtra Pessoa por Idade
        /// caso nao informado idade de filtro, retorna 18+
        /// </summary>
        /// <param name="idade"></param>
        /// <returns></returns>
        public List<Pessoa> GetPessoasIdadeMaiorD(int idade = 18)
        {
            return ListaDePessoas.FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) >= idade);
            
        }

        /// <summary>
        /// Metodo que retorna Pessoa com idade menor do que informada
        /// Idade padrao é 16
        /// </summary>
        /// <param name="idade"></param>
        /// <returns></returns>
        public List<Pessoa> GetPessoasIdadeMenorD(int idade = 16)
        {
            return ListaDePessoas.FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) < idade);

        }


    }
}
