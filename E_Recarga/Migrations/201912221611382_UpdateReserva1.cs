namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReserva1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservas", "PostoId", c => c.Byte(nullable: false));
            AddColumn("dbo.Reservas", "Posto_Id", c => c.Int());
            CreateIndex("dbo.Reservas", "Posto_Id");
            AddForeignKey("dbo.Reservas", "Posto_Id", "dbo.Postoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "Posto_Id", "dbo.Postoes");
            DropIndex("dbo.Reservas", new[] { "Posto_Id" });
            DropColumn("dbo.Reservas", "Posto_Id");
            DropColumn("dbo.Reservas", "PostoId");
        }
    }
}
