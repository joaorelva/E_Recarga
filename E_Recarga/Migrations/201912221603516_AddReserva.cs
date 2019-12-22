namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReserva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostoId = c.Byte(nullable: false),
                        Posto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Postoes", t => t.Posto_Id)
                .Index(t => t.Posto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "Posto_Id", "dbo.Postoes");
            DropIndex("dbo.Reservas", new[] { "Posto_Id" });
            DropTable("dbo.Reservas");
        }
    }
}
