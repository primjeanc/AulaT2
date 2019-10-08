using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisandoEntity.Model;
using RevisandoEntity.Controller;

namespace Interface
{
    class Program
    {
        //static CervejaContextDB context = new CervejaContextDB();
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            /*context.Cervejas.Add(new Cerveja() { Nome = "Original 600ml c/12", Teor = 5.1, Tipo = "Pilsen" });
            context.SaveChanges();*/

            //controller.Cervejas.ToList<Cerveja>().ForEach(x => Console.WriteLine($"Nome {x.Nome} Tipo {x.Tipo} Teor de Álcool {x.Teor}"));

            cerveja.AddCerveja(new Cerveja() { Nome = "Cerveja Skol", Teor = 4, Tipo = "Pilsen" });

            cerveja.GetCervejas().ToList<Cerveja>().ForEach(x => Console.WriteLine($"Nome {x.Nome}"));

            /*
             string template = "ID: {0,-3} | Nome: {1,-30} | Idade: {2,5} ";
            alunoController.GetAlunos().OrderBy(x => x.Nome).ToList<Alunos>()
                .ForEach(v => Console.WriteLine(String.Format(template, v.Id, v.Nome, v.Idade)));
             */

            Console.ReadLine();
        }
    }
}
