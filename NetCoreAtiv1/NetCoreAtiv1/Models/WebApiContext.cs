using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAtiv1.Models
{
    public class WebApiContext:DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {


        }
        public DbSet<Calculadora> Calculadoras { get; set; }
    }
}
