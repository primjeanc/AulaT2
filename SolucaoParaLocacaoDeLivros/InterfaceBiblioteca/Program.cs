using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {              
        static LivroController livros = new LivroController();
        static UsuarioController usuarios = new UsuarioController();

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");
            TrocaDeUsuario();
            MostraMenuSistema();
            Console.ReadKey();

        }
        private static void TrocaDeUsuario()// chama o teste de usuario, caso login/senha INVALIDOS, fica travado no login e acessa MENU
        {
            while (!RealizaLoginSistema())
                Console.WriteLine("Login ou senha inválido.");
        }

        /// <summary>
        /// Mostra no Console o Menu apos logar em sistema
        /// </summary>
        private static void MostraMenuSistema()
        {
            
            var opcao = int.MinValue;//variavel iniciada com menor valor de int possivel
            
            while (opcao != 0)//Menu em LOOP até que aperte 0 "zero"
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");
                //Mostras as opcoes do menu em sistema
                Console.WriteLine("Menu Sistema:");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Usuários");
                Console.WriteLine("4 - Cadastrar Livros");
                Console.WriteLine("5 - Troca de Usuário");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {

                    case 1:
                        ListagemUsuarios();
                        break;
                    case 2:
                        ListagemLivros(); Console.ReadKey();
                        break;
                    case 3:
                        CadastraUsuario(); Console.ReadKey();
                        break;
                    case 4:
                        ListagemLivros(); Console.ReadKey();//ainda nao cadastra livros
                        break;
                    case 5:
                        TrocaDeUsuario(); 
                        break;

                    case 0:
                        return;
                    default:
                        break;
                }         
            
        }             

        }
        /// <summary>
        /// Realiza login em sistema [entrando login/senha]. Retorna teste TRUE/FALSE do login [validação]
        /// </summary>
        /// <returns>Returna  TRUE-FALSE quando informado login e senha</returns>
        private static bool RealizaLoginSistema()
        {
            
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login");
            var loginDoUsuario = Console.ReadLine();
            Console.WriteLine("Senha");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();//esse cara esta RESETANDO A LISTA NA HORA DE VALIDAR NOVOSO USUARIOS
            //o sistema cadastra usuarios e lista eles, mas quando vai LOGAR, os novos logins nao funcionam
            Usuario usuario = new Usuario();//objeto usuario recebe Classe Usuario inicializada 'new'
            usuario.Login = loginDoUsuario;//atribui Login ao loginDoUsuario
            usuario.Senha = senhaDoUsuario;//item para senhaDo...

            return usuarioController.LoginSistema(usuario);
            
        }
        private static void ListagemLivros()
        {
            livros.ListaDeLivros.ForEach(l => Console.WriteLine($"ID: {l.Id} -- Nome: {l.Nome}"));//imprime todos os livros cadastrados
        }
        private static void ListagemUsuarios()
        {
            //mostra a lista de usuarios ja cadastrados
            Console.Clear();
            usuarios.ListaDeUsuarios.ForEach(i => Console.WriteLine($"ID: {i.Id} -- Login: {i.Login}"));
            Console.ReadKey();
        }
        private static void CadastraUsuario()
        {
            usuarios.AdicionaUsuario();
        }

    }
}
