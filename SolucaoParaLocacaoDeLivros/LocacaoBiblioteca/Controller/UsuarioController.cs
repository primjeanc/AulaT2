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
        private int IdContador = 1;//PRIVATE para impedir o programador adicionar ou alterar o ID de fora da classe
        public UsuarioController()
        {
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
        private List<Usuario> ListaDeUsuarios { get; set; }//lista PRIVADA de usuarios na classe, sera chamada em um metodo publico para mostrar no programa sem alterar
        public void AdicionaUsuario(Usuario usuario)//cadastro de usuario na lista criada acima "ListaDeUsuarios"
        {
            usuario.Id = IdContador++;
            ListaDeUsuarios.Add(usuario);
        }
        /// <summary>
        /// Metodo publico pra mostrar ListaDeUsuarios ATIVOS(que esta privada na CLASSE para evitar acesso externo)
        /// </summary>
        /// <returns></returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            return ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Metodo que desativa um regstro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="intentificadoID">intendifica usuario a ser desativado</param>
        public void RemoverUsuarioPorID(int intentificadoID)
        {
            //aqui usamos FirstOrDefault para localiza nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            ListaDeUsuarios.FirstOrDefault(x => x.Id == intentificadoID).Ativo = false;
        }
    }
}
