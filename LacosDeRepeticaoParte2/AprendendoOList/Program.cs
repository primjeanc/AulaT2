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
            var listaOri = minhaListaPulgmatica.Count();
            Console.Clear();
            AdicionarItensALista();

            ListaInformacoes(listaOri);
            Console.ReadKey();
        }

        /// <summary>
        /// Método que adiciona item a lista
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("Informe o nome a ser cadastrado:");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.WriteLine($"{minhaListaPulgmatica.LastOrDefault()} adicionado a lista");
            //LastOrDefault chama ultimo valor atual da lista         

            Console.WriteLine("Deseja informar mais valores? sim (S) /não (N)");
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AdicionarItensALista();   
                            
        }
        /// <summary>
        /// Lista original
        /// </summary>
        private static void ListaInformacoes(int listaOri)
        {
            Console.Clear();
            Console.WriteLine("Lista Atual:");
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine(item);
            
            var listaAtual = minhaListaPulgmatica.Count();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Adicionados recentemente:");
            for (int i = listaOri; i < listaAtual; i++)
            {
                Console.WriteLine(minhaListaPulgmatica.ElementAt(i));
            }
        }
    }
}
