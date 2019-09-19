using CarSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarSys
{
    class Program
    {
        public static List<Carro> ListaCarro = new List<Carro>(); //Lista carInfo recebe Class List. Carro
        static void Main(string[] args)
        {
            Console.WriteLine("Aperte [1] para novo cadastro.");

            ListaCarro = CadastraCarro(); //carInfo recebe dados de [Cadastro]
            
            Listagem(ListaCarro); //[listagem] busca informacoes de carInfo
        }
        /// <summary>
        /// Metodo de Lista para cadastro de veiculos
        /// </summary>
        /// <returns></returns>
        public static List<Carro> CadastraCarro()
        {
            
            Console.WriteLine("Informe a marca do veículo:");
            var marca = Console.ReadLine();            
            Console.WriteLine("Informe o modelo:");
            var modelo = Console.ReadLine();
            Console.WriteLine("Informe o ano de fabricação:");
            var ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do veículo:");
            var valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Placa [ ABC 1234 ] contendo 3 letras / 4 digitos");
            var placa = Console.ReadLine();        


            Console.Clear();

            ListaCarro.Add(new Carro()
            {
                Marca = marca,
                Modelo = modelo,
                Ano = ano,
                Valor = valor,
                Placa = placa
            }) ;
            ListaCarro.ForEach(i => Console.WriteLine($"Marca: {i.Marca} | Modelo: {i.Modelo} | Ano de Fabricação: {i.Ano} | Valor: R${i.Valor} | Placa:{i.Placa}"));
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Aperte [1] para novo cadastro ou [2] para sair do sistema.");
            var entrada = int.Parse(Console.ReadKey().KeyChar.ToString());
            if (entrada == 1)
            {
                CadastraCarro();
            }
            return ListaCarro;
        }
        /// <summary>
        /// Lista final contendo todo o cadastro de informações
        /// </summary>
        /// <param name="dataInfo"></param>
        public static void Listagem(List<Carro> car)
        {
            Console.Clear();
            car.ForEach(i => Console.WriteLine($"Marca: {i.Marca} | Modelo: {i.Modelo} | Ano de Fabricação: {i.Ano} | Valor: R${i.Valor}"));
            Console.ReadKey();
        }

        private static void MenuInicial()
        {
            Console.WriteLine("Sistema de Cadastro de Veículos.");
            Console.WriteLine("Aperte [1] para novo cadastro.");
            Console.WriteLine("Aperte [2] para listar veículos cadastrados.");
            var entrada = int.Parse(Console.ReadKey().KeyChar.ToString());
            while (entrada == 1)
            {
                CadastraCarroDD();
            }
            Listagem(ListaCarro);
        }
        /// <summary>
        /// Importado 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool EPlacaValida(string placa)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");

            if (regex.IsMatch(placa))
            {
                return true;
            }

            return false;
        }

        public static List<Carro> CadastraCarroDD()//aplica as informacoes direto nos objetos da classe Carro
        {
            Carro carro = new Carro(); //carro recebe classe(lista) Carro
            Console.WriteLine("Sistema de Cadastro Pessoal");
            Console.WriteLine("Informe a marca do veículo:");
            carro.Marca = Console.ReadLine();
            Console.WriteLine("Informe o modelo:");
            carro.Modelo = Console.ReadLine();
            Console.WriteLine("Informe o ano de fabricação:");
            carro.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do veículo:");
            carro.Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Placa [ ABC 1234 ] contendo 3 letras / 4 digitos");
            carro.Placa = Console.ReadLine();
            
            Console.Clear();
            ListaCarro.Add(carro);//carro recebe carInfo
           
            ListaCarro.ForEach(i => Console.WriteLine($"Marca: {i.Marca} | Modelo: {i.Modelo} | Ano de Fabricação: {i.Ano} | Valor: R${i.Valor} | Placa:{i.Placa}"));
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Aperte [1] para novo cadastro ou [2] para sair do sistema.");
            var entrada = int.Parse(Console.ReadKey().KeyChar.ToString());
            if (entrada == 1)
            {
                CadastraCarro();
            }


            return ListaCarro;
        }
    }
}
