namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLocalizacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Postoes", "Location", c => c.String());
            DropColumn("dbo.Estacaos", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Estacaos", "Location", c => c.String());
            DropColumn("dbo.Postoes", "Location");
        }
    }
}
