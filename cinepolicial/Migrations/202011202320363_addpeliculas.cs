namespace cinepolicial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpeliculas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Peliculas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        clasificacion = c.String(),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Peliculas");
        }
    }
}
