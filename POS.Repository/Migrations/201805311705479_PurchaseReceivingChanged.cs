namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseReceivingChanged : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PurchaseReceivings", "Quantity");
            DropColumn("dbo.PurchaseReceivings", "PurchasePrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseReceivings", "PurchasePrice", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseReceivings", "Quantity", c => c.Int(nullable: false));
        }
    }
}
