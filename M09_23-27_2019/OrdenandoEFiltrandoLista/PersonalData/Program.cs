using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalData
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lista1
            var listaPessoas = new List<Pessoa>();

            listaPessoas.Add(new Pessoa()
            {
                Id = 1,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("07/11/2004"),
                Carteira = 846.96
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 2,
                Nome = "Swanson",
                DataNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 3,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 4,
                Nome = "Gregory",
                DataNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 469.01
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 5,
                Nome = "Olson",
                DataNascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 6,
                Nome = "Garza",
                DataNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 7,
                Nome = "Sweet",
                DataNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 8,
                Nome = "Cline",
                DataNascimento = DateTime.Parse("26/03/2002"),
                Carteira = 484.51
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 9,
                Nome = "Oliver",
                DataNascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 10,
                Nome = "Vang",
                DataNascimento = DateTime.Parse("10/07/2000"),
                Carteira = 271.05
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 11,
                Nome = "Maddox",
                DataNascimento = DateTime.Parse("29/05/2004"),
                Carteira = 783.97
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 12,
                Nome = "Garrett",
                DataNascimento = DateTime.Parse("03/06/2006"),
                Carteira = 154.11
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 13,
                Nome = "Mcintosh",
                DataNascimento = DateTime.Parse("06/07/2006"),
                Carteira = 902.80
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 14,
                Nome = "Yang",
                DataNascimento = DateTime.Parse("29/04/2005"),
                Carteira = 550.48
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 15,
                Nome = "Hendricks",
                DataNascimento = DateTime.Parse("05/09/2003"),
                Carteira = 410.56
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 16,
                Nome = "Cain",
                DataNascimento = DateTime.Parse("12/01/2002"),
                Carteira = 221.13
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 17,
                Nome = "Blackburn",
                DataNascimento = DateTime.Parse("10/05/2000"),
                Carteira = 135.67
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 18,
                Nome = "Howe",
                DataNascimento = DateTime.Parse("27/09/2005"),
                Carteira = 360.14
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 19,
                Nome = "Pratt",
                DataNascimento = DateTime.Parse("18/09/2000"),
                Carteira = 991.83
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 20,
                Nome = "Sherman",
                DataNascimento = DateTime.Parse("20/02/2003"),
                Carteira = 667.00
            });
            #endregion
            listaPessoas.OrderBy(x => x.Nome).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}| Data de Nascimento: {i.DataNascimento.ToShortDateString()} | Carteira: R$ {i.Carteira}"));
            Console.WriteLine("----Ordem Crescente por Nome-----------------------------------------------------");
            listaPessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}| Data de Nascimento: {i.DataNascimento.ToShortDateString()} | Carteira: R$ {i.Carteira}"));
            Console.WriteLine("----Ordem Decrescente por Data de Nascimento-------------------------------------");

            (from temDinheiro in listaPessoas
             where temDinheiro.Carteira > 500
             select temDinheiro).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}| Data de Nascimento: {i.DataNascimento.ToShortDateString()} | Carteira: R$ {i.Carteira}"));
            Console.WriteLine("----Carteira com saldo 500+------------------------------------------------------");

            
            (from cadeiaOk in listaPessoas
             where cadeiaOk.DataNascimento < (DateTime.Parse("23/09/2001"))//compara lista copiada com peso >100 e imprime se atender a regra de peso
             select cadeiaOk).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}| Data de Nascimento: {i.DataNascimento.ToShortDateString()} | Carteira: R$ {i.Carteira}"));
            Console.WriteLine("----18 anos + -------------------------------------------------------------------");

            (from cadeiaNao in listaPessoas
             where cadeiaNao.DataNascimento > (DateTime.Parse("22/09/2003"))//compara lista copiada com peso >100 e imprime se atender a regra de peso
             select cadeiaNao).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}| Data de Nascimento: {i.DataNascimento.ToShortDateString()} | Carteira: R$ {i.Carteira}"));
            Console.WriteLine("----Menor de 16 anos ------------------------------------------------------------");
            Console.ReadKey();


        }
        

    }
}
