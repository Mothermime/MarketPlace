namespace MarketPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeighKeyPropertiesToMarket : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Markets", name: "Category_Id", newName: "CategoryId");
            RenameColumn(table: "dbo.Markets", name: "Organiser_Id", newName: "OrganiserId");
            RenameIndex(table: "dbo.Markets", name: "IX_Organiser_Id", newName: "IX_OrganiserId");
            RenameIndex(table: "dbo.Markets", name: "IX_Category_Id", newName: "IX_CategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Markets", name: "IX_CategoryId", newName: "IX_Category_Id");
            RenameIndex(table: "dbo.Markets", name: "IX_OrganiserId", newName: "IX_Organiser_Id");
            RenameColumn(table: "dbo.Markets", name: "OrganiserId", newName: "Organiser_Id");
            RenameColumn(table: "dbo.Markets", name: "CategoryId", newName: "Category_Id");
        }
    }
}
