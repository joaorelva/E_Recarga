namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReserva : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservas", "Posto_Id", "dbo.Postoes");
            DropIndex("dbo.Reservas", new[] { "Posto_Id" });
            AddColumn("dbo.Reservas", "UtilizadorId", c => c.Int(nullable: false));
            AddColumn("dbo.Reservas", "Custo", c => c.Int(nullable: false));
            DropColumn("dbo.Reservas", "PostoId");
            DropColumn("dbo.Reservas", "Posto_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservas", "Posto_Id", c => c.Int());
            AddColumn("dbo.Reservas", "PostoId", c => c.Byte(nullable: false));
            DropColumn("dbo.Reservas", "Custo");
            DropColumn("dbo.Reservas", "UtilizadorId");
            CreateIndex("dbo.Reservas", "Posto_Id");
            AddForeignKey("dbo.Reservas", "Posto_Id", "dbo.Postoes", "Id");
        }
    }
}
