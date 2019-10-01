using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;


namespace ListarCarrosDoAmigo
{
    class Program
    {
        static CarroController carroController = new CarroController();//inicializa e cria ligacao com controller
        static void Main(string[] args)
        {
            ImprimeCarros();
            Console.ReadKey();

        }
        private static void ImprimeCarros()//metodo para mostrar dados da lista da classe
        {
            carroController.ListagemCarros().ForEach(i => Console.WriteLine($"Id {i.Id} Marca {i.Marca} Modelo {i.Modelo} Ano{i.Ano} Cilindrada {i.Cilindradas} Portas {i.Portas}"));
        }


    }
}
