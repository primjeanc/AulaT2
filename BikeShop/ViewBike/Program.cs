using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeLibrary.Model;
using BikeLibrary.Controller;

namespace ViewBike
{
    class Program
    {
        static BikeController controller = new BikeController();
        static void Main(string[] args)
        {

        }
        private static void BikeList()
        {            
            string template = "ID: {0,-3} | Nome: {1,-35} | Ultima Atualização:{2,20}";
            controller.GetBikes().ToList<Bike>().ForEach(v =>
            Console.WriteLine(String.Format(template, v.Id, v.Nome, v.DataAlteracao)));
        }
        public static void BikeAdd()
        {
            Console.WriteLine("Cadastrar Bicicleta em sistema:");
            Console.WriteLine("Informe o Modelo:");
            var novo = Console.ReadLine();

            var resultado = controller.AddBike(new Bike()
            { Nome = novo });
            if (resultado)
                Console.WriteLine("Livro cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar...");
        }
        public static void AtualizarLivro()
        {
            Console.WriteLine("Atualizar Modelo");
            BikeList();//mostra a lista para identificar o ID que sera alterado
            Console.WriteLine("Informe o ID da bicicleta a ser alterado:");
            var livId = int.Parse(Console.ReadLine());//informa ID para alterar
            //cria variavel para comparar e encontra ID
            var atualiz = controller.GetBikes().FirstOrDefault(x => x.Id == livId);


            if (atualiz == null)
            {
                Console.WriteLine("ID informado inválido");
                return;
            }
            Console.WriteLine("Informe o Nome do exemplar:");
            atualiz.Nome = Console.ReadLine();

            var resultado = controller.UpdateBike(atualiz);
            // apenas mostra mensagem ao final da tentativa de atualizar um produto
            if (resultado)
                Console.WriteLine("Exemplar Atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar exemplar.");

        }
    }
}
