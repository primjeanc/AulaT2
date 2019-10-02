using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> venda = new List<Venda>()
            {
                new Venda()
                {
                    Produto = "XIAOMI Lite 6 quad Core 128gb 32px frontal",
                    Quantidade = 8,
                    Valor = 1200.75
                },
                new Venda()
                {
                    Produto = "SLIM 3500 APP",
                    Quantidade = 5,
                    Valor = 2800.96
                },
                new Venda()
                {
                    Produto = "IPHONE FOGÃO 3 BOCAS",
                    Quantidade = 1,
                    Valor = 9999.99
                }

            };
            Console.WriteLine("Média de produtos vendidos neste mês");
            Console.WriteLine(venda.Average(x=>x.Quantidade));
            Console.WriteLine("Média total de vendas neste mês em R$");
            Console.WriteLine(venda.Average(x=> (x.Quantidade*x.Valor))); //tira media ja calculando de quant x preco de uma vez só
            Console.ReadKey();
        }
    }
}
