namespace cinepolicial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class startproject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cines",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sala = c.String(),
                        hora = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cines");
        }
    }
}
