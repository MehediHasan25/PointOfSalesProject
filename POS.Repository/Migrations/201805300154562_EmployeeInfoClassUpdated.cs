namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeInfoClassUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeInfoes", "Code", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "ContactNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeInfoes", "ContactNo");
            DropColumn("dbo.EmployeeInfoes", "Code");
        }
    }
}
