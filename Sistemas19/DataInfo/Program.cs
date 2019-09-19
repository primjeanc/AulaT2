using DataInfo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInfo
{
    class Program
    {
        
        public static List<Pessoa> ListaPessoa = new List<Pessoa>();//variavel global
        //declarando a lista fora "global" ela se mantem ao inves de resetar a cada entrada de cadastro
        static void Main(string[] args)
        {
            
            /*
            ListaPessoa = Cadastramento();
            Listagem(ListaPessoa);*/

        }
        static void Hebeficar(int idade)
        {
            idade = 16000;
        }
        /// <summary>
        /// Cadastro de informações
        /// </summary>
        /// <returns></returns>
        public static List<Pessoa> Cadastramento()
        {
            Console.WriteLine("Sistema de Cadastro Pessoal");
            Console.WriteLine("Informe o nome a ser cadastrado:");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o idade:");
            var idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura [0,00]:");
            var altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o sexo (m/f):");
            var genero = Console.ReadKey().KeyChar;
            Console.Clear();

            ListaPessoa.Add(new Pessoa()
            {
                Name = nome,
                Gender = genero,
                Age = idade,
                Height = altura
            });
            /*--versao que gera nova lista ou imprime lista geral se os dados foram todos inseridos dentro do programa
            dataInfo = new List<Pessoa>
            {
                new Pessoa()
                {
                    Name = nome,
                    Gender = genero,
                    Age = idade,
                    Height = altura
                },
            };*/
            ListaPessoa.ForEach(i => Console.WriteLine($"Nome: {i.Name} | Genero: {i.Gender} | Idade: {i.Age} anos| Altura:{i.Height} m"));
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Aperte [1] para novo cadastro ou [2] para sair do sistema.");
            var entrada = int.Parse(Console.ReadKey().KeyChar.ToString());
            if (entrada == 1)
            {
                Cadastramento();
            }


            return ListaPessoa;

        }

        public static void Listagem(List<Pessoa> dataInfo)
        {
            Console.Clear();
            Console.WriteLine("Lista Atualizada:");
            dataInfo.ForEach(i => Console.WriteLine($"Nome: {i.Name} | Genero: {i.Gender} | Idade: {i.Age} anos| Altura:{i.Height} m"));
            Console.ReadKey();
        }
    }
}
