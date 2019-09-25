using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteiroPrimitivo();

            SomaInteirosLista();

            SomaBalasListaDeCriacas();

            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que cria colecao(lista simples) de inteiros e retorna a soma dos mesmos
        /// </summary>
        private static void SomarInteiroPrimitivo()
        {
            //quando utilizamos '[]' em um tipo 'primitivo' podemos criar uma colecao destes valores
            int[] colecaoInteiros = new int[5] { 1, 2, 3, 4, 5 }; // 'int[]...new int' aloca em memoria a colecao
            //int'[5]' eh a quantidade de memoria a ocupar e '{1,2,3,4,5}' aqui carregamos nossa colecao de valores

            Console.WriteLine(colecaoInteiros.Sum());//Sum sola os valores da colecao /lista
            
        }
        /// <summary>
        /// Metodo que usa SUM para somar valores da lista INT criada
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            //como na lista nao precisa determinar o tamanho alocado como em colecoes, podemos alterar a lista livremente
            Console.WriteLine(listaDeInteiros.Sum());
        }
        private static void SomaBalasListaDeCriacas()
        {
            List<Crianca> listaCrianca = new List<Crianca>()
            {
                new Crianca() { Nome = "Joazinho", Balas = 9 }, //em uma linha
                new Crianca()
                {
                    Nome = "Pedrinho",//ou formato padrao, tanto faz
                    Balas = 68
                }                
            };
            Console.WriteLine("Quantidade total de balas que as criacinhas compraram na venda ");
            Console.WriteLine(listaCrianca.Sum(x=> x.Balas));


        }
    }
}
