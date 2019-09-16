using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSplitList();
        }
        private static void CarSplitList()
        {
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuários cadastrados no sistema:");
            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');
                var carro = informacoesSplit[0].Split(':')[1];
                var marca = informacoesSplit[1].Split(':')[1];
                var fabric = informacoesSplit[2].Split(':')[1];

                if (carro == nomeBusca)
                {
                    Console.WriteLine($"O {carro} da marca {marca} foi fabricado em {fabric}.");
                }
            }
            Console.ReadKey();
        }
    }
}
