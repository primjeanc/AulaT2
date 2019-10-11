using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeLibrary.Model;
using BikeLibrary.Controller;
using System.Data.SqlClient;

namespace ViewBike
{
    class Program
    {
        static BikeController bikeController = new BikeController();
        static MarcaController marcaController = new MarcaController();
        static ModeloController modeloController = new ModeloController();
        static void Main(string[] args)
        {
            /*
            SqlConnection conn = null;
            SqlDataReader reader = null;
            conn = new SqlConnection("Data Source=(localdb);Initial Catalog=BikeLibrary.Model.BikeContext;Integrated Security=True");
            */
            MenuInicial();
            Console.ReadKey();

            /*
  
            // don't ever do this
            // SqlCommand cmd = new SqlCommand(
            // "select * from CLIENTES where BAIRRO = '" + _bairro + "'";
  
            // Criando o SqlCommand com parâmetro
            SqlCommand cmd = new SqlCommand(
                "select * from CLIENTES where BAIRRO = @Bairro ", conn);
             
             
             */

        }
        private static void BikeList()
        {
            string template = "ID: {0,-3} | Preço: {1,-12} | Modelo:{2,4}";
            bikeController.GetBikes().ToList<Bike>().ForEach(v =>
            Console.WriteLine(String.Format(template, v.Id, v.Valor.ToString("C2"), v.IdModelo)));

            var bikeQuerys = bikeController.GetBikes();
            //var modeloQuerys = modeloController.GetModelos();

            //var queryResult = from bike in bikeQuerys
            //                  join modelo in modeloQuerys on bike.IdModelo equals modelo.Id
            //                  select bike;

            //foreach (var item in queryResult)
            //{

            //}

        }
        private static void MarcaList()
        {
            string template = "ID: {0,-3} | Nome: {1,-25} | Ultima Atualização:{2,20}";
            marcaController.GetMarcas().ToList<Marca>().ForEach(v =>
            Console.WriteLine(String.Format(template, v.Id, v.Nome, v.DataAlteracao)));
        }
        private static void ModeloList()
        {
            string template = "ID: {0,-3} | Nome: {1,-25} | Ultima Atualização:{2,10}";
            modeloController.GetModelos().ToList<Modelo>().ForEach(v =>
            Console.WriteLine(String.Format(template, v.Id, v.Nome, v.DataAlteracao)));
        }
        public static void BikeAdd()
        {
            Console.WriteLine("Cadastrar Bicicleta em sistema:");
            ModeloList();
            Console.WriteLine("Informe o código do Modelo:");
            var novo = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Preço da Bicicleta:");
            var preco = double.Parse(Console.ReadLine());

            var resultado = bikeController.AddBike(new Bike()
            { IdModelo = novo, Valor = preco });
            if (resultado)
                Console.WriteLine("Cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar...");
        }
        public static void ModeloAdd()
        {
            Console.WriteLine("Cadastrar Modelo de Bicicleta em sistema:");
            Console.WriteLine("Informe o Modelo:");
            var novo = Console.ReadLine();
            MarcaList();
            Console.WriteLine("Informe o Codigo da Marca:");

            var codMarca = Console.ReadLine();

            var resultado = modeloController.AddModelo(new Modelo()
            { Nome = novo });
            if (resultado)
                Console.WriteLine("Cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar...");
        }
        public static void MarcaAdd()
        {
            Console.WriteLine("Cadastrar Marca de Bicicleta em sistema:");
            Console.WriteLine("Informe a Marca:");
            var novo = Console.ReadLine();

            var resultado = marcaController.AddMarca(new Marca()
            { Nome = novo });
            if (resultado)
                Console.WriteLine("Cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar...");
        }
        public static void BikeUpdate()
        {
            Console.WriteLine("Atualizar Bicicletas");
            BikeList();//mostra a lista para identificar o ID que sera alterado
            Console.WriteLine("Informe o ID da bicicleta a ser alterado:");
            var livId = int.Parse(Console.ReadLine());//informa ID para alterar

            //cria variavel para comparar e encontra ID
            var atualiz = bikeController.GetBikes().FirstOrDefault(x => x.Id == livId);
            if (atualiz == null)
            {
                Console.WriteLine("ID informado inválido");
                return;
            }
            Console.WriteLine("Informe o novo Valor:");
            atualiz.Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o novo código de Modelo:");
            atualiz.Id = int.Parse(Console.ReadLine());

            var resultado = bikeController.UpdateBike(atualiz);
            // apenas mostra mensagem ao final da tentativa de atualizar um produto
            if (resultado)
                Console.WriteLine("Atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar dados.");
        }
        public static void ModeloUpdate()
        {
            Console.WriteLine("Atualizar Modelos");
            ModeloList();//mostra a lista para identificar o ID que sera alterado
            Console.WriteLine("Informe o ID do Modelo a ser alterado:");
            var livId = int.Parse(Console.ReadLine());//informa ID para alterar
            //cria variavel para comparar e encontra ID
            var atualiz = modeloController.GetModelos().FirstOrDefault(x => x.Id == livId);
            if (atualiz == null)
            {
                Console.WriteLine("ID informado inválido");
                return;
            }
            Console.WriteLine("Informe a nova Descrição:");
            atualiz.Nome = Console.ReadLine();
            MarcaList();
            Console.WriteLine("Informe o código da Marca:");
            atualiz.IdMarca = int.Parse(Console.ReadLine());

            var resultado = modeloController.UpdateModelo(atualiz);
            // apenas mostra mensagem ao final da tentativa de atualizar um produto
            if (resultado)
                Console.WriteLine("Atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar dados.");
        }
        public static void MarcaUpdate()
        {
            Console.WriteLine("Atualizar Marcas");
            MarcaList();//mostra a lista para identificar o ID que sera alterado
            Console.WriteLine("Informe o ID da Marca a ser alterada:");
            var livId = int.Parse(Console.ReadLine());//informa ID para alterar
            //cria variavel para comparar e encontra ID
            var atualiz = marcaController.GetMarcas().FirstOrDefault(x => x.Id == livId);
            if (atualiz == null)
            {
                Console.WriteLine("ID informado inválido");
                return;
            }
            Console.WriteLine("Informe a nova Descrição:");
            atualiz.Nome = Console.ReadLine();

            var resultado = marcaController.UpdateMarca(atualiz);
            // apenas mostra mensagem ao final da tentativa de atualizar um produto
            if (resultado)
                Console.WriteLine("Atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar dados.");
        }
        private static void BikeRemove()
        {
            Console.WriteLine("Remoção de registro");
            BikeList();//chama o metodo que ja mostrava lista 
            Console.WriteLine("Informe o ID a ser desativado:");
            var buscaId = int.Parse(Console.ReadLine());

            bikeController.RemoveBike(buscaId);
            Console.WriteLine("Removido!");//retorna mensagem apos remover/desativar usuario
            Console.ReadKey();
        }
        private static void ModeloRemove()
        {
            Console.WriteLine("Remoção de registro");
            ModeloList();//chama o metodo que ja mostrava lista 
            Console.WriteLine("Informe o ID a ser desativado:");
            var buscaId = int.Parse(Console.ReadLine());

            modeloController.RemoveModelo(buscaId);
            Console.WriteLine("Removido!");//retorna mensagem apos remover/desativar usuario
            Console.ReadKey();
        }
        private static void MarcaRemove()
        {
            Console.WriteLine("Remoção de registro");
            MarcaList();//chama o metodo que ja mostrava lista 
            Console.WriteLine("Informe o ID a ser desativado:");
            var buscaId = int.Parse(Console.ReadLine());

            marcaController.RemoveMarca(buscaId);
            Console.WriteLine("Removido!");//retorna mensagem apos remover/desativar usuario
            Console.ReadKey();
        }
        private static void BikeMenu()
        {
            var opcao = int.MinValue;//variavel iniciada com menor valor de int possivel
            while (opcao != 0)//Menu em LOOP até que aperte 0 "zero"
            {
                Console.Clear();
                Console.WriteLine("SISTEMA BIKESHOP 1.0");//Mostras as opcoes do menu em sistema
                Console.WriteLine("Menu Sistema:");
                Console.WriteLine("1 - Listar Bicicletas");
                Console.WriteLine("2 - Cadastrar Bicileta");
                Console.WriteLine("3 - Atualizar Bicicletas");
                Console.WriteLine("4 - Remover Bicicleta");
                Console.WriteLine("0 - Retornar");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {
                    case 1:
                        BikeList(); Console.ReadKey();
                        break;
                    case 2:
                        BikeAdd();
                        break;
                    case 3:
                        BikeUpdate();
                        break;
                    case 4:
                        BikeRemove();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }

        }
        private static void ModeloMenu()
        {
            var opcao = int.MinValue;//variavel iniciada com menor valor de int possivel
            while (opcao != 0)//Menu em LOOP até que aperte 0 "zero"
            {
                Console.Clear();
                Console.WriteLine("SISTEMA BIKESHOP 1.0");//Mostras as opcoes do menu em sistema
                Console.WriteLine("Menu Sistema:");
                Console.WriteLine("1 - Listar Modelos");
                Console.WriteLine("2 - Cadastrar Modelo");
                Console.WriteLine("3 - Atualizar Modelos");
                Console.WriteLine("4 - Remover Modelo");
                Console.WriteLine("0 - Retornar");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {
                    case 1:
                        ModeloList(); Console.ReadKey();
                        break;
                    case 2:
                        ModeloAdd();
                        break;
                    case 3:
                        ModeloUpdate();
                        break;
                    case 4:
                        ModeloRemove();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }

        }
        private static void MarcaMenu()
        {
            var opcao = int.MinValue;//variavel iniciada com menor valor de int possivel
            while (opcao != 0)//Menu em LOOP até que aperte 0 "zero"
            {
                Console.Clear();
                Console.WriteLine("SISTEMA BIKESHOP 1.0");//Mostras as opcoes do menu em sistema
                Console.WriteLine("Menu Sistema:");
                Console.WriteLine("1 - Listar Marcas");
                Console.WriteLine("2 - Cadastrar Marca");
                Console.WriteLine("3 - Atualizar Marcas");
                Console.WriteLine("4 - Remover Marca");
                Console.WriteLine("0 - Retornar");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {
                    case 1:
                        MarcaList(); Console.ReadKey();
                        break;
                    case 2:
                        MarcaAdd();
                        break;
                    case 3:
                        MarcaUpdate();
                        break;
                    case 4:
                        MarcaRemove();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }

        }
        private static void MenuInicial()
        {
            var opcao = int.MinValue;//variavel iniciada com menor valor de int possivel
            while (opcao != 0)//Menu em LOOP até que aperte 0 "zero"
            {
                Console.Clear();
                Console.WriteLine("SISTEMA BIKESHOP 1.0");//Mostras as opcoes do menu em sistema
                Console.WriteLine("Menu Sistema:");
                Console.WriteLine("1 - Marcas");
                Console.WriteLine("2 - Modelos");
                Console.WriteLine("3 - Biciletas");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {
                    case 1:
                        MarcaMenu(); 
                        break;
                    case 2:
                        ModeloMenu();
                        break;
                    case 3:
                        BikeMenu();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }

        }
    }
}
