namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Description");
        }
    }
}
