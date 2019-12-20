namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSaldo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Saldo", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Saldo");
        }
    }
}
