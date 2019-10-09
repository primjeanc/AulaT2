using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class CelularesContextDB : DbContext //definindo heranca e herdando todas as funcoes de ENtityFramework
    {
        public DbSet<Usuario> Usuarios { get; set; }//tabela usuarios

        public DbSet<Celular> Celulares { get; set; }//tabela Celulares

    }
}
