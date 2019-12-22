namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReserva2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservas", "Posto_Id", "dbo.Postoes");
            DropIndex("dbo.Reservas", new[] { "Posto_Id" });
            DropPrimaryKey("dbo.Postoes");
            AlterColumn("dbo.Postoes", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Postoes", "Id");
            DropColumn("dbo.Reservas", "PostoId");
            DropColumn("dbo.Reservas", "Posto_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservas", "Posto_Id", c => c.Int());
            AddColumn("dbo.Reservas", "PostoId", c => c.Byte(nullable: false));
            DropPrimaryKey("dbo.Postoes");
            AlterColumn("dbo.Postoes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Postoes", "Id");
            CreateIndex("dbo.Reservas", "Posto_Id");
            AddForeignKey("dbo.Reservas", "Posto_Id", "dbo.Postoes", "Id");
        }
    }
}
