namespace MarketPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMarketTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Venue = c.String(),
                        MarketName_Id = c.String(maxLength: 128),
                        Type_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.MarketName_Id)
                .ForeignKey("dbo.Types", t => t.Type_Id)
                .Index(t => t.MarketName_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Markets", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Markets", "MarketName_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Markets", new[] { "Type_Id" });
            DropIndex("dbo.Markets", new[] { "MarketName_Id" });
            DropTable("dbo.Types");
            DropTable("dbo.Markets");
        }
    }
}
