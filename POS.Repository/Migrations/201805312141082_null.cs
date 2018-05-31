namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _null : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", "dbo.PurchaseReceivings");
            DropIndex("dbo.PurchaseReceivingDetails", new[] { "PurchaseReceivingId" });
            AlterColumn("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", c => c.Int(nullable: false));
            CreateIndex("dbo.PurchaseReceivingDetails", "PurchaseReceivingId");
            AddForeignKey("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", "dbo.PurchaseReceivings", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", "dbo.PurchaseReceivings");
            DropIndex("dbo.PurchaseReceivingDetails", new[] { "PurchaseReceivingId" });
            AlterColumn("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", c => c.Int());
            CreateIndex("dbo.PurchaseReceivingDetails", "PurchaseReceivingId");
            AddForeignKey("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", "dbo.PurchaseReceivings", "Id");
        }
    }
}
