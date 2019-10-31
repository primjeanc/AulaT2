using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using InnerJoinWEBAPI.Models;

namespace InnerJoinWEBAPI.Controllers
{
    public partial class CarrosController
    {
        [HttpGet]
        [Route("Api/Carros/CarrosMarca")]
        public object CustomCarrosOnMarcas()
        {
            var lista1 = db.Carros.ToList();
            var lista2 = db.Marcas.ToList();
            var conteudoRetorno = from ca in lista1
                                  join ma in lista2
                                  on ca.Marca equals ma.Id                                  
                                  select new
                                  {
                                      CarroId = ca.Id,
                                      Marca = ma.Nome,
                                      Carro = ca.Modelo
                                  };
            return conteudoRetorno;
        }
    }
}