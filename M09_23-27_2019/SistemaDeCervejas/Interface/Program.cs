using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;
using ListagemDeCervejas.Controller;


namespace Interface
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            MostraListaCervejas();
            ValorTotalCervejas();
            LitrosTotalCervejas();

            Console.WriteLine("Aperte qualquer tecla para adicionar cerveja consumida");
            Console.ReadKey();
            AdicionaCerveja();
            Console.WriteLine("Aperte qualquer tecla para Listar novamente as cervejas consumidas");
            Console.ReadKey();
            MostraListaCervejas();
            Console.WriteLine("Aperte qualquer tecla para Listar novamente Valor e Litros consumidos");
            Console.ReadKey();
            ValorTotalCervejas();
            LitrosTotalCervejas();
            var weight =0;
            var gender = 0;
            TesteLeiSeca(gender,weight);
            Console.ReadKey();

        }

        public static void AdicionaCerveja()
        {
            Cerveja cerveja = new Cerveja();
            Console.WriteLine("Informe os dados da Cerveja consumida");
            Console.WriteLine("Informe o nome da Cerveja:");
            cerveja.Nome = Console.ReadLine();
            Console.WriteLine("Informe o volume em Litros da Cerveja (Ex: LongNeck 355ml = 0.355):");
            cerveja.Litros = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o teor de Álcool da Cerveja(Ex: 5.5):");
            cerveja.Alcool = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor em R$ da Cerveja:");
            cerveja.Valor = double.Parse(Console.ReadLine());

            cervejaController.AddCerveja(cerveja);

        }
        private static void MostraListaCervejas()
        {
            cervejaController.GetCervejas().ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome} | Litros {i.Litros}L | Alcool {i.Alcool}% | Valor {i.Valor.ToString("C2")}"));
        }
        private static void ValorTotalCervejas()
        {
            Console.WriteLine($"Total gasto em Cerveja: {cervejaController.SomaValorCerveja().ToString("C2")}");
        }
        private static void LitrosTotalCervejas()
        {
            Console.WriteLine($"Total de litros consumido: {cervejaController.SomaLitrosCerveja()}L");
        }
        private static void TesteLeiSeca(double gender, double weight)
        {
            Console.WriteLine("Vamos ver se você pode dirigir depois das bebidas que tomou?");
            Console.WriteLine("Informe seu genero [m/f]");
            var teste = Console.ReadKey().KeyChar;
            Console.WriteLine("Informe seu peso em kilos");
            weight = double.Parse(Console.ReadLine());
            switch (teste)
            {
                case 'm':
                    {
                        gender = 0.7;
                    }
                    break;
                case 'f':
                    {
                        gender = 0.6;
                    }
                    break;
            }
            
            if (cervejaController.LeiSeca(gender,weight) == true)
                Console.WriteLine("Nível de Álcool no sangue exede permitido conforme a Lei Seca");
            else Console.WriteLine("Saiu e não bebeu? Why!!! Why, Why...whyyyyyyy!");
        }
    }
}
