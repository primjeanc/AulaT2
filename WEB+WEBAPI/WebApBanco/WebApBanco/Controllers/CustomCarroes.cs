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
    public partial class CarroesController
    {
        [HttpGet]
        [Route("Api/Carroes/CustomQuery")]
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();
            var retornoCarros = from cr in listaDeCarros
                                select new { NomeCarro = cr.Modelo, CarroId = cr.Id };
            return retornoCarros;
        }
        [HttpGet]
        [Route("Api/Carroes/CarrosComMarcas")]
        public object CustomCarrosOnMarcas()
        {
            var listaCarros = db.Carros.ToList();
            var listaMarcas = db.Marcas.ToList();
            var conteudoRetorno = from mar in listaMarcas
                                  join car in listaCarros
                                  on mar.Id equals car.Marca
                                  select new
                                  {
                                      CarroId = car.Id,
                                      CarroNome = car.Modelo,
                                      MarcaId = mar.Id,
                                      MarcaNome = mar.Nome
                                  };
            return conteudoRetorno;
        }
        [HttpGet]
        [Route("Api/Carroes/{id}/CarrosUsuarios")]
        public object CustomCarrosOnUsuarios(int id)
        {
            var lista1 = db.Carros.ToList();
            var lista2 = db.Usuarios.ToList();
            var conteudoRetorno = from usu in lista2
                                  join car in lista1
                                  on usu.Id equals car.Marca
                                  where car.Id == id
                                  select new
                                  {
                                      CarroId = car.Id,
                                      UsuarioId = usu.Id,
                                      UsuarioNome = usu.Usuario1
                                  };
            return conteudoRetorno;
        }
    }
}