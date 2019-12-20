namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEstacao : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Estacaos (Id, Name, Location) VALUES (1, 'Cepsa', 'Cidreira')");
            Sql("INSERT INTO Estacaos (Id, Name, Location) VALUES (2, 'Repsol', 'Coimbra')");
            Sql("INSERT INTO Estacaos (Id, Name, Location) VALUES (3, 'Galp', 'Ançã')");
            Sql("INSERT INTO Estacaos (Id, Name, Location) VALUES (4, 'BP', 'Cantanhede')");
        }
        
        public override void Down()
        {
        }
    }
}
