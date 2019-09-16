using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoOList
{
    class Program
    {
        static List<string> minhaListaPulgmatica = new List<string>() //criação de lista
        {
            "Felipe",
            "Irineu",
            "Motocicleiton"
        };
        static void Main(string[] args)
        {
            //ListaInformacoes();
            //var listaOri = minhaListaPulgmatica.Count();
            AdicionarItensALista();
            //var listaAtual = minhaListaPulgmatica.Count();
            /*
            for (int i = listaOri; i < listaAtual; i++)
            {
                Console.WriteLine(minhaListaPulgmatica.ElementAt(i));
            }*/
            ListaInformacoes();
            Console.ReadKey();
        }

        /// <summary>
        /// Método que adiciona item a lista
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("Informe um nome:");
            minhaListaPulgmatica.Add(Console.ReadLine());
            //Console.WriteLine($"{minhaListaPulgmatica.LastOrDefault()} adicionado a lista");
            //LastOrDefault          

            Console.WriteLine("Deseja informar mais valores? sim (S) /não (N)");
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AdicionarItensALista();   
                            
        }
        /// <summary>
        /// Lista original
        /// </summary>
        private static void ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados alista");
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine($"{item} foi adicionado");
        }
    }
}
