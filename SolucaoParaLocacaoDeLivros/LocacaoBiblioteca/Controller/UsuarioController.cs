using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metodos de usuarios do sistema
    /// </summary>
    public class UsuarioController
    {
        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();
            ListaDeUsuarios.Add(new Usuario() //lista (um ou mais objetos)
            {
                Login = "Admin",
                Senha = "Admin",
                Ativo = true,
                Id = 000001
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "HBSIS",
                Senha = "PROWAY",
                Ativo = true,
                Id = 000002
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "200902",
                Senha = "123456",
                Ativo = true,
                Id = 000003
            });
        }

        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar login padrao use:
        /// Login: Admin
        /// Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Ususario como parametro</param>        
        /// <returns>Retorna verdadeiro quando existir o usuario com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)//Usuarios= id,login,senha etc
        {
            //como a lista ja foi inicializada e salva na memoria na propria classe, o teste na LISTA de USUARIOS fica mais simples
            return ListaDeUsuarios.Exists(u => u.Login == usuarios.Login && u.Senha == usuarios.Senha);
            /*if (usuarios.Login == "Admin" && usuarios.Senha == "Admin")
                return true;
            else
                return false;*/// antigo teste
        }
        public List<Usuario> ListaDeUsuarios { get; set; }//lista de usuarios na classe
        public void AdicionaUsuario()
        {
            Usuario usuario = new Usuario();// inicia objeto'usuario' (lista)
            Console.WriteLine("Login a ser cadastrado:");
            usuario.Login = Console.ReadLine();
            Console.WriteLine("Senha a ser cadastrada:");
            usuario.Senha = Console.ReadLine();
            ListaDeUsuarios.Add(new Usuario() //lista (um ou mais objetos)
            {
                Login = usuario.Login,
                Senha = usuario.Senha,
                Ativo = true,
                Id = ListaDeUsuarios.Count+1
            });

        }
    }
}
