namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalePrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "SalePrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "SalePrice");
        }
    }
}
