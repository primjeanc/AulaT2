namespace CodeFirstTest.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CervejaContextDb : DbContext
    {
        public CervejaContextDb(string conexao)
            : base(conexao)//aqui alteramos nosso construtor de " dbcontext para
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Cerveja> Cervejas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
