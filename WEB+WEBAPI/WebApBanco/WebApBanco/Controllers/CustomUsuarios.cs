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
    public partial class UsuariosController
    {
        [HttpGet]
        [Route("Api/Usuarios/OnlyNames")]
        public object CustomUsuariosQuery()
        {
            var lista = db.Usuarios.ToList();
            var retornoLista = from ab in lista
                               select new { NomeUsuario = ab.Usuario1 };
            return retornoLista;
        }
    }
}