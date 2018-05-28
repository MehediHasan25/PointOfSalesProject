namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpenseCategory_Added : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Branches", name: "OrganizationId", newName: "OrganizationsId");
            RenameIndex(table: "dbo.Branches", name: "IX_OrganizationId", newName: "IX_OrganizationsId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Branches", name: "IX_OrganizationsId", newName: "IX_OrganizationId");
            RenameColumn(table: "dbo.Branches", name: "OrganizationsId", newName: "OrganizationId");
        }
    }
}
