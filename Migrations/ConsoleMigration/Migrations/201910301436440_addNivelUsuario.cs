﻿namespace ConsoleMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNivelUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Nivel", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Nivel");
        }
    }
}
