using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAtividade.Model;
using EntityAtividade.Controller;


namespace View
{
    class Program
    {
        static AlunoController alunoController = new AlunoController();//liga controller ao program
        //o Banco de dados está ligado ao Context e classe Alunos, que estao ligados ao controller
        static void Main(string[] args)
        {
            MostraMenuSistema();
           
            
        }
        public static void MostraLista()
        {
            //alunoController.GetAlunos().OrderBy(x => x.Nome).ToList<Alunos>()
            //    .ForEach(x => Console.WriteLine($"ID: {x.Id} |Nome {x.Nome} | Idade: {x.Idade}"));

            string template = "ID: {0,-3} | Nome: {1,-30} | Idade: {2,5} ";
            alunoController.GetAlunos().OrderBy(x => x.Nome).ToList<Alunos>()
                .ForEach(v => Console.WriteLine(String.Format(template, v.Id, v.Nome, v.Idade)));
        }
        public static void AddAluno()
        {
            Alunos aluno = new Alunos();
            Console.WriteLine("Informe nome do Aluno");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Informe Idade do Aluno");
            aluno.Idade = int.Parse(Console.ReadLine());
            alunoController.AddAluno(aluno);

        }
        private static void MostraMenuSistema()
        {

            var opcao = int.MinValue;//variavel iniciada com menor valor de int possivel

            while (opcao != 0)//Menu em LOOP até que aperte 0 "zero"
            {
                Console.Clear();
                Console.WriteLine("ALUNOS 1.0");
                //Mostras as opcoes do menu em sistema
                Console.WriteLine("Menu Sistema:");
                Console.WriteLine("1 - Listar Alunos");
                Console.WriteLine("2 - Adicionar Aluno");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {

                    case 1:
                        Console.Clear();
                        MostraLista(); Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        AddAluno(); 
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }

            }

        }
    }
}
