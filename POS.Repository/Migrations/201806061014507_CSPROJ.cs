namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CSPROJ : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stocks", "AvgPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Stocks", "CategoryFullPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stocks", "CategoryFullPath");
            DropColumn("dbo.Stocks", "AvgPrice");
        }
    }
}
