namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificarTablas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materia", "Programa", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materia", "Programa");
        }
    }
}
