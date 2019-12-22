namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateposto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservas", "PostoId", "dbo.Postoes");
            DropIndex("dbo.Reservas", new[] { "PostoId" });
            DropPrimaryKey("dbo.Postoes");
            AddColumn("dbo.Reservas", "Posto_Id", c => c.Int());
            AlterColumn("dbo.Postoes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Postoes", "Id");
            CreateIndex("dbo.Reservas", "Posto_Id");
            AddForeignKey("dbo.Reservas", "Posto_Id", "dbo.Postoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "Posto_Id", "dbo.Postoes");
            DropIndex("dbo.Reservas", new[] { "Posto_Id" });
            DropPrimaryKey("dbo.Postoes");
            AlterColumn("dbo.Postoes", "Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Reservas", "Posto_Id");
            AddPrimaryKey("dbo.Postoes", "Id");
            CreateIndex("dbo.Reservas", "PostoId");
            AddForeignKey("dbo.Reservas", "PostoId", "dbo.Postoes", "Id", cascadeDelete: true);
        }
    }
}
