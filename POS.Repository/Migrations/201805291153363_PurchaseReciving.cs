namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseReciving : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", "dbo.PurchaseReceivings");
            DropForeignKey("dbo.PurchaseReceivingDetails", "ItemId", "dbo.Items");
            DropIndex("dbo.PurchaseReceivingDetails", new[] { "PurchaseReceivingId" });
            DropIndex("dbo.PurchaseReceivingDetails", new[] { "ItemId" });
            AddColumn("dbo.PurchaseReceivings", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseReceivings", "PurchasePrice", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseReceivings", "ItemId", c => c.Int());
            AlterColumn("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", c => c.Int());
            AlterColumn("dbo.PurchaseReceivingDetails", "ItemId", c => c.Int());
            CreateIndex("dbo.PurchaseReceivings", "ItemId");
            CreateIndex("dbo.PurchaseReceivingDetails", "PurchaseReceivingId");
            CreateIndex("dbo.PurchaseReceivingDetails", "ItemId");
            AddForeignKey("dbo.PurchaseReceivings", "ItemId", "dbo.Items", "Id");
            AddForeignKey("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", "dbo.PurchaseReceivings", "Id");
            AddForeignKey("dbo.PurchaseReceivingDetails", "ItemId", "dbo.Items", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseReceivingDetails", "ItemId", "dbo.Items");
            DropForeignKey("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", "dbo.PurchaseReceivings");
            DropForeignKey("dbo.PurchaseReceivings", "ItemId", "dbo.Items");
            DropIndex("dbo.PurchaseReceivingDetails", new[] { "ItemId" });
            DropIndex("dbo.PurchaseReceivingDetails", new[] { "PurchaseReceivingId" });
            DropIndex("dbo.PurchaseReceivings", new[] { "ItemId" });
            AlterColumn("dbo.PurchaseReceivingDetails", "ItemId", c => c.Int(nullable: false));
            AlterColumn("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", c => c.Int(nullable: false));
            DropColumn("dbo.PurchaseReceivings", "ItemId");
            DropColumn("dbo.PurchaseReceivings", "PurchasePrice");
            DropColumn("dbo.PurchaseReceivings", "Quantity");
            CreateIndex("dbo.PurchaseReceivingDetails", "ItemId");
            CreateIndex("dbo.PurchaseReceivingDetails", "PurchaseReceivingId");
            AddForeignKey("dbo.PurchaseReceivingDetails", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", "dbo.PurchaseReceivings", "Id", cascadeDelete: true);
        }
    }
}
