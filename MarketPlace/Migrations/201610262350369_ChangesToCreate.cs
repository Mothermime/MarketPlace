namespace MarketPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesToCreate : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Markets", name: "MarketName_Id", newName: "Organiser_Id");
            RenameIndex(table: "dbo.Markets", name: "IX_MarketName_Id", newName: "IX_Organiser_Id");
            AddColumn("dbo.Markets", "MarketName", c => c.String());
            DropColumn("dbo.Markets", "Organiser");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Markets", "Organiser", c => c.String());
            DropColumn("dbo.Markets", "MarketName");
            RenameIndex(table: "dbo.Markets", name: "IX_Organiser_Id", newName: "IX_MarketName_Id");
            RenameColumn(table: "dbo.Markets", name: "Organiser_Id", newName: "MarketName_Id");
        }
    }
}
