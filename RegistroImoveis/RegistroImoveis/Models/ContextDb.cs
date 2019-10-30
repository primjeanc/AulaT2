using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistroImoveis.Models
{
    public class ContextDb:DbContext
    {
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }

    }
}