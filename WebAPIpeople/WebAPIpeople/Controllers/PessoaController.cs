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

        List<Pessoa> pessoas = new List<Pessoa>()
        {
        new Pessoa() { Nome = "Breno" , Idade=120},
        new Pessoa() { Nome = "Motocicleiton" , Idade=80},
        new Pessoa() { Nome = "Ku Li Pin" , Idade=28},
        new Pessoa() { Nome = "Ku Sujin" , Idade=30},
        new Pessoa() { Nome = "Furijoh" , Idade=50},
        new Pessoa() { Nome = "Lendario" , Idade=18},
        new Pessoa() { Nome = "n7" , Idade=21},
        new Pessoa() { Nome = "n8" , Idade=22},
        new Pessoa() { Nome = "n9" , Idade=23},
        new Pessoa() { Nome = "n10" , Idade=24}
        };

        public List<Pessoa> Get()
        {
            return pessoas;
        }
        public Pessoa Post(Pessoa values)
        {
            Pessoa pessoa = values;
            pessoas.Add(pessoa);
            return pessoa;           

        }
    }
}
