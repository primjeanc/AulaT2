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
    public partial class VendasController
    {
        [HttpGet]
        [Route("Api/Vendas/OnlyNames")]
        public object CustomVendasQuery()
        {
            var lista = db.Vendas.ToList();
            var retornoLista = from ab in lista
                               select new { VendaId = ab.Id,VendaValor = ab.Valor };
            return retornoLista;
        }
    }
}