namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sales : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expenses", "ReasonsOfExpense", c => c.String());
            AddColumn("dbo.SalesDetails", "SalesPrice", c => c.Double(nullable: false));
            DropColumn("dbo.Sales", "SalePrice");
            DropColumn("dbo.Sales", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Sales", "SalePrice", c => c.Double(nullable: false));
            DropColumn("dbo.SalesDetails", "SalesPrice");
            DropColumn("dbo.Expenses", "ReasonsOfExpense");
        }
    }
}
