using System.Dynamic;

namespace MarketPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoriesTable : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO Categories (Id, Name) VALUES (1, 'General')");
            //Sql("INSERT INTO Categories (Id, Name) VALUES (2, 'Craft')");
            //Sql("INSERT INTO Categories (Id, Name) VALUES (3, 'Farmers')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (4, 'School Fair')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (5, 'Antiques')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (6, 'Twilight')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (7, 'Medieval')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (8, 'Community')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Categories WHERE Id IN (1,2,3,4,5,6,7,8)" );
        }
    }
}
