namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newchanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Stocks", "AvgPrice");
            DropColumn("dbo.Stocks", "CategoryFullPath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stocks", "CategoryFullPath", c => c.String());
            AddColumn("dbo.Stocks", "AvgPrice", c => c.Double(nullable: false));
        }
    }
}
