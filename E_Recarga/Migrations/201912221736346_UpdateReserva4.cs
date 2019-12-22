namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReserva4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservas", "Custo", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservas", "Custo", c => c.Int(nullable: false));
        }
    }
}
