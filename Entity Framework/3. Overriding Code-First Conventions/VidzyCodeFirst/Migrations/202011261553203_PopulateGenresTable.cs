namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres VALUES (2, 'Adventure')");
            Sql("INSERT INTO Genres VALUES (3, 'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
