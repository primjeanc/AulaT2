using Apresentacao.Controller;
using Apresentacao.Model;
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
            //veiculoController.RetornaListaVeiculos()
            //    .ForEach(i => Console.WriteLine($"ID: {i.Id} | Carro: {i.Carro} | Valor: {i.Valor} | Quantidade: {i.Quantidade} | Data: {i.Data.ToShortDateString()}"));
            string template = "ID: {0,-3} | Carro: {1,-25} | Valor: {2,10} | Qtde: {3,4} | Data: {4,10}";
            veiculoController.RetornaListaVeiculos().ForEach(v => Console.WriteLine(String.Format(template, v.Id, v.Carro, v.Valor.ToString("C2"), v.Quantidade, v.Data.ToShortDateString())));
        }
        private static void MostraMenuSistema()
        {

            var opcao = int.MinValue;//variavel iniciada com menor valor de int possivel

            while (opcao != 0)//Menu em LOOP até que aperte 0 "zero"
            {
                Console.Clear();
                Console.WriteLine("REGISTRO DE VENDAS 2019");
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
            Console.WriteLine(veiculoController.contextDB.ListaVeiculo.Sum(x => (x.Quantidade * x.Valor)).ToString("C2"));
            //Console.WriteLine(venda.Sum(x=> (x.Quantidade*x.Valor)));
        }
        private static void MediaDeVendas()
        {
            Console.WriteLine($"Média de vendas para 2019:");
            Console.WriteLine(veiculoController.contextDB.ListaVeiculo.Average(x => (x.Quantidade * x.Valor)).ToString("C2"));
            //Console.WriteLine(venda.Average(x=> (x.Quantidade*x.Valor)));
        }
        public static void RelatorioDeVendasMensal()
        {
            Console.WriteLine("Informe o mês");
            var mes = int.Parse(Console.ReadLine());            
            var listaTotal = veiculoController.RetornaListaVeiculosMes(mes);
            listaTotal.ForEach(w => Console.WriteLine());
            ImprimeDados(listaTotal);
            Console.WriteLine($"Total de vendas para {mes}/2019:");
            Console.WriteLine(listaTotal.Sum(x => (x.Quantidade * x.Valor)).ToString("C2"));

            Console.WriteLine($"Média de vendas para {mes}/2019:");
            Console.WriteLine(listaTotal.Average(x => (x.Valor)).ToString("C2"));
            //Console.WriteLine(venda.Sum(x=> (x.Quantidade*x.Valor)));
        }
        public static void ListarVeiculos()
        {
            ImprimeDados(veiculoController.RetornaListaVeiculos());
        }
        public static void ImprimeDados(List<Veiculo> listaTotal)
        {
            string template = "ID: {0,-3} | Carro: {1,-25} | Valor: {2,10} | Qtde: {3,4} | Data: {4,10}";
            listaTotal.ForEach(v => Console.WriteLine(String.Format(template, v.Id, v.Carro, v.Valor.ToString("C2"), v.Quantidade, v.Data.ToShortDateString())));
        }


    }
}
