using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTest.Model;
using CodeFirstTest.Controller;

namespace GambCodeFirst
{
    class Program
    {
        static CervejaController controllerDb = new CervejaController();
        static void Main(string[] args)
        {
            controllerDb.AddCerveja(new Cerveja { Nome = "Rhas Ga Kul", Teor = 0 });
            
            
            //controllerDb.Cervejas.ToList<Cerveja>().ForEach(x => Console.WriteLine($"Nome: {x.Nome} Teor: {x.Teor}"));

            Console.ReadKey();
        }
    }
}
