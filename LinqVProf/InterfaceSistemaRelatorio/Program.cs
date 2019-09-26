using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            MostraMenuRelatorio();
            vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));
            //ImprimeInformacoes(vendas);
            Console.ReadKey();

        }
        private static void MostraMenuRelatorio()
        {
            Console.Clear();
            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            Console.WriteLine("Menu de relatórios:");
            Console.WriteLine("1 - Relatório por período mensal");
            Console.WriteLine("0 - Sair");

            var opcao = int.MinValue;
            while (opcao != 0)
            {
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês do relatório desejado. [0] - Anual)");
                            var mes = int.Parse(Console.ReadLine());
                            vendasController.GetVendas(mes).ForEach(i => ImprimeInformacoes(i));

                            var totalMes = vendasController.GetVendas(mes).Sum(x => x.Valor * x.Quantidade);
                            Console.WriteLine($"Total de vendas em {mes}/2019 foi {totalMes.ToString("C2")}");
                            var mediaMes = vendasController.GetVendas(mes).Sum(x => x.Valor * x.Quantidade);
                            Console.WriteLine($"Média de vendas em {mes}/2019 foi {mediaMes.ToString("C2")}");
                            Console.ReadKey();

                        }
                        break;




                }

            }


        }
       
        public static void ImprimeInformacoes(Venda vendas)
        {            
            Console.WriteLine(string.Format("Id {0,3} Carro {1,-36} Valor {2,5} Quantidade {3,3} Data {4,10}", vendas.Id, vendas.Carro, vendas.Valor.ToString("C2"), vendas.Quantidade, vendas.Data.ToShortDateString()));

        }

    }
}
