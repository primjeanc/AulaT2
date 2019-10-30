namespace ConsoleMigration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleMigration.Model.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsoleMigration.Model.MigrationContext";
        }

        protected override void Seed(ConsoleMigration.Model.MigrationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Usuarios.AddOrUpdate(x=>x.Nome,new Model.Usuario()
            {
                Nome = "Felipe",
                Login = "admin",
                Senha = "admin",
                Email = "admin@admin.com.br",
                Nivel = Model.Nivel.Administrador
            });
            context.SaveChanges();
        }
    }
}
