namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseReceivingDetails", "ItemId", "dbo.Items");
            DropIndex("dbo.PurchaseReceivingDetails", new[] { "ItemId" });
            AlterColumn("dbo.PurchaseReceivingDetails", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.PurchaseReceivingDetails", "ItemId");
            AddForeignKey("dbo.PurchaseReceivingDetails", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseReceivingDetails", "ItemId", "dbo.Items");
            DropIndex("dbo.PurchaseReceivingDetails", new[] { "ItemId" });
            AlterColumn("dbo.PurchaseReceivingDetails", "ItemId", c => c.Int());
            CreateIndex("dbo.PurchaseReceivingDetails", "ItemId");
            AddForeignKey("dbo.PurchaseReceivingDetails", "ItemId", "dbo.Items", "Id");
        }
    }
}
