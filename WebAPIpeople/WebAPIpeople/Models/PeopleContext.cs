using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIpeople.Models
{
    public class PeopleContext : DbContext
    {

        //public PeopleContext():base("name=PeopleContext")
        //{

        //}


        public DbSet<Pessoa> Pessoas { get; set; }
    }
}