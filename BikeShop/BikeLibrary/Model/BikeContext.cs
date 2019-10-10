using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeLibrary.Model
{
    class BikeContext:DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
    }
}
