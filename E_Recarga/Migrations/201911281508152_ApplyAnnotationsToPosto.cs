namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToPosto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Postoes", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Postoes", "Name", c => c.String());
        }
    }
}
