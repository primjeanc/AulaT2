using DllPastaWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace InterfacePastaWin
{
    class Program
    {
        static DocumentsAutoGenerate documents = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {


            var pasta1 = string.Empty;
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Manutençao de Pastas");
                Console.WriteLine("1 - criar pastas");
                Console.WriteLine("2 - listar pastas");
                Console.WriteLine("3 - deletar pastas");
                Console.WriteLine("4 - Bonus Sextouuuu");



                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o Nome da pasta a ser criada");
                            pasta1 = Console.ReadLine();
                            documents.CriarPastaMeusDocumentos(pasta1);
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        {
                            documents.ObterPastasDiretorioMeuDocumentos().ForEach(i => Console.WriteLine(i));
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Informe o Nome da pasta a ser deletada");
                            pasta1 = Console.ReadLine();
                            documents.DeletarPastaMeusDocumentos(pasta1, true);
                            Console.WriteLine($"---------Deletado:{pasta1}");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            new HoraDoShow().Birllllllllll();
                        }
                        break;

                }

            }         
            
            Console.ReadKey();

        }
    }
}
