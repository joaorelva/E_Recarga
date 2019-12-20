namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEstacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estacaos",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Postoes", "EstacaoId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Postoes", "EstacaoId");
            AddForeignKey("dbo.Postoes", "EstacaoId", "dbo.Estacaos", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Postoes", "EstacaoId", "dbo.Estacaos");
            DropIndex("dbo.Postoes", new[] { "EstacaoId" });
            DropColumn("dbo.Postoes", "EstacaoId");
            DropTable("dbo.Estacaos");
        }
    }
}
