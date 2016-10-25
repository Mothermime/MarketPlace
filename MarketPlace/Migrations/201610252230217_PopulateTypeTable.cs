namespace MarketPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Types(Id , Name) VALUES(1, 'Craft') ");
            Sql("INSERT INTO Types(Id , Name) VALUES(2, 'Farmers') ");
            Sql("INSERT INTO Types(Id , Name) VALUES(3, 'School Fair') ");
            Sql("INSERT INTO Types(Id , Name) VALUES(4, 'Food') ");
            Sql("INSERT INTO Types(Id , Name) VALUES(5, 'Antique') ");
            Sql("INSERT INTO Types(Id , Name) VALUES(6, 'General') ");
            Sql("INSERT INTO Types(Id , Name) VALUES(7, 'Twilight') ");
            Sql("INSERT INTO Types(Id , Name) VALUES(8, 'Medieval') ");
        }                                          
        
        public override void Down()
        {
            Sql("DELETE FROM Types WHERE Id IN (1,2,3,4,5,6,7,8,");
        }
    }
}
