using Apresentacao.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Apresentacao
{
    class Program
    {
        static VeiculoController veiculoController = new VeiculoController();
        static void Main(string[] args)
        {
            MostraMenuSistema();
            

            Console.ReadKey();

        }
        private static void ListagemVeiculo()
        {
            Console.WriteLine("-------------- Lista completa de veículos cadastrados ----------------");
            veiculoController.RetornaListaVeiculos()
                .ForEach(i => Console.WriteLine($"ID: {i.Id} | Carro: {i.Carro} | Valor: {i.Valor} | Quantidade: {i.Quantidade} | Data: {i.Data.ToShortDateString()}"));
        }
        private static void MostraMenuSistema()
        {

            var opcao = int.MinValue;//variavel iniciada com menor valor de int possivel

            while (opcao != 0)//Menu em LOOP até que aperte 0 "zero"
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");
                //Mostras as opcoes do menu em sistema
                Console.WriteLine("Menu Sistema:");
                Console.WriteLine("1 - Lista Geral de Veículos");
                Console.WriteLine("2 - Relatório Mensal");
                Console.WriteLine("3 - Relatório Geral");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {

                    case 1:
                        ListagemVeiculo(); Console.ReadKey();
                        break;
                    case 2:
                        RelatorioDeVendasMensal(); Console.ReadKey();
                        break;
                    case 3:
                        SomaTotalDeVendas(); MediaDeVendas(); Console.ReadKey();
                        break;

                    case 0:
                        return;
                    default:
                        break;
                }

            }

        }
        private static void SomaTotalDeVendas()
        {            
            Console.WriteLine($"Total de vendas para 2019:");
            Console.WriteLine(veiculoController.contextDB.ListaVeiculo.Sum(x => (x.Quantidade * x.Valor)));
            //Console.WriteLine(venda.Sum(x=> (x.Quantidade*x.Valor)));
        }
        private static void MediaDeVendas()
        {
            Console.WriteLine($"Média de vendas para 2019:");
            Console.WriteLine(veiculoController.contextDB.ListaVeiculo.Average(x => (x.Quantidade * x.Valor)));
            //Console.WriteLine(venda.Average(x=> (x.Quantidade*x.Valor)));
        }
        public static void RelatorioDeVendasMensal()
        {
            Console.WriteLine("Informe o mês");
            var mes = int.Parse(Console.ReadLine());            
            var listaTotal = veiculoController.contextDB.ListaVeiculo.Where(m => m.Data.Month == mes);

            Console.WriteLine($"Total de vendas para {mes}/2019:");
            Console.WriteLine(listaTotal.Sum(x => (x.Quantidade * x.Valor)));

            Console.WriteLine($"Média de vendas para {mes}/2019:");
            Console.WriteLine(listaTotal.Average(x => (x.Quantidade * x.Valor)));
            //Console.WriteLine(venda.Sum(x=> (x.Quantidade*x.Valor)));
        }


    }
}
