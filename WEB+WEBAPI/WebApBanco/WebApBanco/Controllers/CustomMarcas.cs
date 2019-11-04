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
using WebApBanco.Models;

namespace WebApBanco.Controllers
{
    public partial class MarcasController
    {
        [HttpGet]
        [Route("Api/Marcas/OnlyNames")]
        public object CustomCarrosQuery()
        {
            var lista = db.Marcas.ToList();
            var retornoLista = from ab in lista
                               select new { NomeMarca = ab.Nome };
            return retornoLista;
        }
    }
}