namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpenseItemChangeswithDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExpenseItems", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExpenseItems", "Description");
        }
    }
}
