namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adkj : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseReceivings", "ItemId", "dbo.Items");
            DropIndex("dbo.PurchaseReceivings", new[] { "ItemId" });
            DropColumn("dbo.PurchaseReceivings", "ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseReceivings", "ItemId", c => c.Int());
            CreateIndex("dbo.PurchaseReceivings", "ItemId");
            AddForeignKey("dbo.PurchaseReceivings", "ItemId", "dbo.Items", "Id");
        }
    }
}
