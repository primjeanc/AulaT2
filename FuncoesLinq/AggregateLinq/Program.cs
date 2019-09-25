using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "Giomar",
                "Euricledson",
                "Adagoberto",
                "Ezebio",
                "Irineudson"
            };
            var texto = listaDeNomes.Aggregate((nome1, nome2) => nome1 + ";" + nome2);
            //onde nome1 é o acumulado atual e nome2 agrega o proximo nome da lista, 'FElipe', 'FelipeGiomar', 'FelipeGiomarEuri...' etc
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
