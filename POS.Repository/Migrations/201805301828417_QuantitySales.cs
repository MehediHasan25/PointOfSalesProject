namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuantitySales : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "Quantity");
        }
    }
}
