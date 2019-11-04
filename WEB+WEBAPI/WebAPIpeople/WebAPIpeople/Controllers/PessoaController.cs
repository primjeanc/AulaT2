using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPIpeople.Models;

namespace WebAPIpeople.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PessoaController : ApiController
    {
        PeopleContext contextDB = new PeopleContext();

        public IQueryable<Pessoa> GetPessoas()
        {
            return contextDB.Pessoas.Where(x => x.Ativo == true);
        }
        [HttpGet]
        [Route("api/Pessoa/Order")]
        public IQueryable<Pessoa> PessoasOrder()
        {
            return contextDB.Pessoas.OrderBy(x=>x.Idade).Where(x => x.Ativo == true);
        }

        //public bool AddPessoas(Pessoa item)
        //{
        //    if (item.Idade <= 0)//impede valores 0 ou negativos
        //        return false;
        //    if (string.IsNullOrWhiteSpace(item.Nome))// metodo que identifica espacos em branco
        //        return false;
        //    contextDB.Pessoas.Add(item);// parte final do adicionar, ela insere na tabela e salva com o comando abaixo
        //    contextDB.SaveChanges();
        //    return true;
        //}

        //List<Pessoa> pessoas = new List<Pessoa>()
        //{
        //new Pessoa() { Nome = "Breno" , Idade=120},
        //new Pessoa() { Nome = "Motocicleiton" , Idade=80},
        //new Pessoa() { Nome = "Ku Li Pin" , Idade=28},
        //new Pessoa() { Nome = "Ku Sujin" , Idade=30},
        //new Pessoa() { Nome = "Furijoh" , Idade=50},
        //new Pessoa() { Nome = "Lendario" , Idade=18},
        //new Pessoa() { Nome = "n7" , Idade=21},
        //new Pessoa() { Nome = "n8" , Idade=22},
        //new Pessoa() { Nome = "n9" , Idade=23},
        //new Pessoa() { Nome = "n10" , Idade=24}
        //};

        //public List<Pessoa> Get()
        //{
        //    return contextDB.Pessoas;
        //}
        //public Pessoa Post(Pessoa item)
        //{
        //    pessoas.Add(item);
        //}
        public Pessoa Post(Pessoa values)
        {
            contextDB.Pessoas.Add(values);
            contextDB.SaveChanges();            
            return values;           

        }
    }
}
