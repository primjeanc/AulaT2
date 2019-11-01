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
    public partial class VendasController
    {
        [HttpGet]
        [Route("Api/Vendas/VendasAno/{ano}")]
        public object CustomVendasAno(int ano)
        {
            var lista1 = db.Vendas.ToList();
            var lista2 = db.Carros.ToList();
            var conteudoRetorno = from ve in lista1
                                  join ca in lista2
                                  on ve.Carro equals ca.Id
                                  where ve.DatInc.Year == ano
                                  select new
                                  {
                                      VendaId = ve.Id,
                                      CarroVendido = ca.Modelo,
                                      ValorVenda = ve.Valor
                                  };
            return conteudoRetorno;
        }
        [HttpGet]
        [Route("Api/Vendas/VendasAnoUsu/{ano}")]
        public object CustomVendasAnoUsu(int ano)
        {
            var lista1 = db.Vendas.Where(x=>x.DatInc.Year==ano).ToList();
            var lista2 = db.Carros.ToList();
            var lista3 = db.Usuarios.ToList();
            var conteudoRetorno = from ve in lista1
                                  join ca in lista2
                                  on ve.Carro equals ca.Id
                                  join usu in lista3
                                  on ve.UsuInc equals usu.Id
                                  //where ve.DatInc.Year == ano
                                  orderby ve.DatInc.Year
                                  select new
                                  {
                                      VendaId = ve.Id,
                                      CarroVendido = ca.Modelo,
                                      ValorVenda = ve.Valor,
                                      Vendedor = usu.Usuario,
                                      Ano = ve.DatInc.Year
                                  };
            return conteudoRetorno;
        }
        [HttpGet]
        [Route("Api/Vendas/VendasMarca/{mar}")]
        public object CustomVendasMarca(string mar)
        {
            var lista1 = db.Vendas.ToList();
            var lista2 = db.Carros.ToList();
            var lista3 = db.Marcas.ToList();
            var lista4 = db.Usuarios.ToList();
            var conteudoRetorno = from ca in lista2
                                  join ve in lista1
                                  on ca.Id equals ve.Carro
                                  join ma in lista3
                                  on ca.Marca equals ma.Id
                                  join us in lista4
                                  on ca.UsuInc equals us.Id
                                  where ma.Nome == mar
                                  orderby ve.DatInc
                                  group new {ve} by new { ve.DatInc.Year, us.Usuario } into grp
                                  select new
                                  {
                                      Vendedor = grp.Key.Usuario,
                                      Ano = grp.Key.Year,
                                      Vendas = grp.Sum(x => x.ve.Quantidade)     
                                  };
            return conteudoRetorno;
        }
    }
}