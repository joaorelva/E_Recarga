namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatereserva3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservas", "PostoId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Reservas", "PostoId");
            AddForeignKey("dbo.Reservas", "PostoId", "dbo.Postoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "PostoId", "dbo.Postoes");
            DropIndex("dbo.Reservas", new[] { "PostoId" });
            DropColumn("dbo.Reservas", "PostoId");
        }
    }
}
