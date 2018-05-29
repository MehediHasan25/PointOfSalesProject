namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_database : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.EmployeeInfoes", new[] { "EmployeeInfosId" });
            AlterColumn("dbo.EmployeeInfoes", "EmployeeInfosId", c => c.Int());
            CreateIndex("dbo.EmployeeInfoes", "EmployeeInfosId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.EmployeeInfoes", new[] { "EmployeeInfosId" });
            AlterColumn("dbo.EmployeeInfoes", "EmployeeInfosId", c => c.Int(nullable: false));
            CreateIndex("dbo.EmployeeInfoes", "EmployeeInfosId");
        }
    }
}
