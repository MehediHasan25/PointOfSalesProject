namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpeneWork : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExpenseDetails", "Description", c => c.String());
            AddColumn("dbo.ExpenseDetails", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExpenseDetails", "Amount");
            DropColumn("dbo.ExpenseDetails", "Description");
        }
    }
}
