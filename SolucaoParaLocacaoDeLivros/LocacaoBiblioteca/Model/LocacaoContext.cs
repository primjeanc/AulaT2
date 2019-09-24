using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        public int IdContador { get; set; } = 1;//PRIVATE para impedir o programador adicionar ou alterar o ID de fora da classe
        public int IdLivroContador { get; set; } = 1;//
        public LocacaoContext()
        {
            #region RelacaoUsuarios
            ListaDeUsuarios = new List<Usuario>();// CONSTRUTOR
            ListaDeUsuarios.Add(new Usuario() //lista (um ou mais objetos)
            {
                Login = "Admin",
                Senha = "Admin",
                Ativo = true,
                Id = IdContador++//contador++ incrementa apos a acao . ID comecou no 1, salvaria 1, e mudaria a espera para 2.
                                 //"++contador" incrementa antes. ID comecou no 1, salvaria 2
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "HBSIS",
                Senha = "PROWAY",
                Ativo = true,
                Id = IdContador++
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "200902",
                Senha = "123456",
                Ativo = true,
                Id = IdContador++
            });
            #endregion
            #region RelacaoLivros
            ListaDeLivros = new List<Livro>();
            ListaDeLivros.Add(new Livro() //lista (um ou mais objetos)
            {
                Nome = "A ordem das batatas não altera a maionese",
                Id = IdLivroContador++,
                Ativo = true
            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Certo, errado ou XGH",
                Id = IdLivroContador++
            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Guia do mochileiro das Galáxias",
                Id = IdLivroContador++
            });
            #endregion
        }
        public List<Usuario> ListaDeUsuarios { get; set; }
        public List<Livro> ListaDeLivros { get; set; }//class tipo LISTA para guardar os Livros "private" para evitar uso separado dentro do programa
    }
}


