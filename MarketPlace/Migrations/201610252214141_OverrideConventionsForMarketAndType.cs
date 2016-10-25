namespace MarketPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForMarketAndType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Markets", "MarketName_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Markets", "Type_Id", "dbo.Types");
            DropIndex("dbo.Markets", new[] { "MarketName_Id" });
            DropIndex("dbo.Markets", new[] { "Type_Id" });
            AlterColumn("dbo.Markets", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Markets", "MarketName_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Markets", "Type_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Types", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Markets", "MarketName_Id");
            CreateIndex("dbo.Markets", "Type_Id");
            AddForeignKey("dbo.Markets", "MarketName_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Markets", "Type_Id", "dbo.Types", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Markets", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Markets", "MarketName_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Markets", new[] { "Type_Id" });
            DropIndex("dbo.Markets", new[] { "MarketName_Id" });
            AlterColumn("dbo.Types", "Name", c => c.String());
            AlterColumn("dbo.Markets", "Type_Id", c => c.Byte());
            AlterColumn("dbo.Markets", "MarketName_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Markets", "Venue", c => c.String());
            CreateIndex("dbo.Markets", "Type_Id");
            CreateIndex("dbo.Markets", "MarketName_Id");
            AddForeignKey("dbo.Markets", "Type_Id", "dbo.Types", "Id");
            AddForeignKey("dbo.Markets", "MarketName_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
