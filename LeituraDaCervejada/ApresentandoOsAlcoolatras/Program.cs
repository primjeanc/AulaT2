using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;


namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            Cerveja cerveja = new Cerveja();            
            
            cerveja.Nome = "aaaaaah";            
            cerveja.Litros = 0.750;            
            cerveja.Alcool = 5.5;            
            cerveja.Valor = 5.95;

            cervejaController.AddCerveja(cerveja);

            cervejaController.GetCervejas().ForEach(i => Console.WriteLine($"ID{i.Id} Nome {i.Nome} Litros {i.Litros} Álcool {i.Alcool} Valor {i.Valor.ToString("C2")}"));

            Console.ReadKey();
            Console.WriteLine(cervejaController.SomaValorCervejas().ToString("C2"));            
            Console.WriteLine(cervejaController.SomaCervejasEmLitros());

            Console.ReadKey();





        }
    }
}
