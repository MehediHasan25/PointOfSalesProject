namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Expense : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Expenses", "ExpenseItemId", "dbo.ExpenseItems");
            DropForeignKey("dbo.Expenses", "EmployeeInfoId", "dbo.EmployeeInfoes");
            DropIndex("dbo.Expenses", new[] { "ExpenseItemId" });
            DropIndex("dbo.Expenses", new[] { "EmployeeInfoId" });
            AlterColumn("dbo.Expenses", "EmployeeInfoId", c => c.Int());
            CreateIndex("dbo.Expenses", "EmployeeInfoId");
            AddForeignKey("dbo.Expenses", "EmployeeInfoId", "dbo.EmployeeInfoes", "Id");
            DropColumn("dbo.Expenses", "ReasonsOfExpense");
            DropColumn("dbo.Expenses", "ExpenseItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Expenses", "ExpenseItemId", c => c.Int(nullable: false));
            AddColumn("dbo.Expenses", "ReasonsOfExpense", c => c.String());
            DropForeignKey("dbo.Expenses", "EmployeeInfoId", "dbo.EmployeeInfoes");
            DropIndex("dbo.Expenses", new[] { "EmployeeInfoId" });
            AlterColumn("dbo.Expenses", "EmployeeInfoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Expenses", "EmployeeInfoId");
            CreateIndex("dbo.Expenses", "ExpenseItemId");
            AddForeignKey("dbo.Expenses", "EmployeeInfoId", "dbo.EmployeeInfoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Expenses", "ExpenseItemId", "dbo.ExpenseItems", "Id", cascadeDelete: true);
        }
    }
}
