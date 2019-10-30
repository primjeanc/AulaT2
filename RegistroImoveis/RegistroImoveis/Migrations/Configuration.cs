namespace RegistroImoveis.Migrations
{
    using RegistroImoveis.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistroImoveis.Models.ContextDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RegistroImoveis.Models.ContextDb";
        }

        protected override void Seed(RegistroImoveis.Models.ContextDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Proprietarios.AddOrUpdate(x => x.Nome, new Proprietario()
            {
                Nome = "Ribonocleitu",               
                DataNascimento = DateTime.Now.AddYears(-25),//DateTime.Parse("2010/05/06") seria o NAO XGH
                Email = "Ribon@xghplus.com.br"
               
            });
            //context.SaveChanges();
            // lambda 'new' cria um objeto para comparar com o new imovel, validando se ja existe
            context.Imoveis.AddOrUpdate(x=> new { x.Logradouro,x.Numero,x.Complemento},new Imovel()
            {
                Cep = "89033111",
                Logradouro = "Rua XGH de Novembro",
                Bairro = "Zueiros",
                Municipio = "dontKnow",
                Numero = 1000,
                Complemento = "cafofo",
                ProprietarioId = 1

            });
        }
    }
}
