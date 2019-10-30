namespace ConsoleMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaaaaSeed : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "Ativo");
            DropColumn("dbo.Usuarios", "UsuarioCriacao");
            DropColumn("dbo.Usuarios", "UsuarioAlteracao");
            DropColumn("dbo.Usuarios", "DataCriacao");
            DropColumn("dbo.Usuarios", "DataAlteracao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "DataAlteracao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Usuarios", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Usuarios", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "Ativo", c => c.Boolean(nullable: false));
        }
    }
}
