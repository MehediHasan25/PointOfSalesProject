namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SingleEmployeeInfoAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OfficialInfoes", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.EmployeeInfoes", "OfficialInfoId", "dbo.OfficialInfoes");
            DropForeignKey("dbo.EmployeeInfoes", "PersonalInfoId", "dbo.PersonalInfoes");
            DropIndex("dbo.EmployeeInfoes", new[] { "PersonalInfoId" });
            DropIndex("dbo.EmployeeInfoes", new[] { "OfficialInfoId" });
            DropIndex("dbo.OfficialInfoes", new[] { "BranchId" });
            AddColumn("dbo.EmployeeInfoes", "EmergencyContactNo", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "NationalId", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "FatherName", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "MotherName", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "PermanentAddress", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "PresentAddress", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "Name", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "JoiningDate", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "PersonalContactNo", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "Email", c => c.String());
            AddColumn("dbo.EmployeeInfoes", "Image", c => c.Binary());
            AddColumn("dbo.EmployeeInfoes", "EmployeeInfosId", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeInfoes", "BranchId", c => c.Int());
            CreateIndex("dbo.EmployeeInfoes", "EmployeeInfosId");
            CreateIndex("dbo.EmployeeInfoes", "BranchId");
            AddForeignKey("dbo.EmployeeInfoes", "BranchId", "dbo.Branches", "Id");
            AddForeignKey("dbo.EmployeeInfoes", "EmployeeInfosId", "dbo.EmployeeInfoes", "Id");
            DropColumn("dbo.EmployeeInfoes", "PersonalInfoId");
            DropColumn("dbo.EmployeeInfoes", "OfficialInfoId");
            DropTable("dbo.OfficialInfoes");
            DropTable("dbo.PersonalInfoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PersonalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmergencyContactNo = c.String(),
                        NationalId = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        PermanentAddress = c.String(),
                        PresentAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OfficialInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        JoiningDate = c.String(),
                        PersonalContactNo = c.String(),
                        Email = c.String(),
                        Image = c.Binary(),
                        BranchId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.EmployeeInfoes", "OfficialInfoId", c => c.Int());
            AddColumn("dbo.EmployeeInfoes", "PersonalInfoId", c => c.Int());
            DropForeignKey("dbo.EmployeeInfoes", "EmployeeInfosId", "dbo.EmployeeInfoes");
            DropForeignKey("dbo.EmployeeInfoes", "BranchId", "dbo.Branches");
            DropIndex("dbo.EmployeeInfoes", new[] { "BranchId" });
            DropIndex("dbo.EmployeeInfoes", new[] { "EmployeeInfosId" });
            DropColumn("dbo.EmployeeInfoes", "BranchId");
            DropColumn("dbo.EmployeeInfoes", "EmployeeInfosId");
            DropColumn("dbo.EmployeeInfoes", "Image");
            DropColumn("dbo.EmployeeInfoes", "Email");
            DropColumn("dbo.EmployeeInfoes", "PersonalContactNo");
            DropColumn("dbo.EmployeeInfoes", "JoiningDate");
            DropColumn("dbo.EmployeeInfoes", "Name");
            DropColumn("dbo.EmployeeInfoes", "PresentAddress");
            DropColumn("dbo.EmployeeInfoes", "PermanentAddress");
            DropColumn("dbo.EmployeeInfoes", "MotherName");
            DropColumn("dbo.EmployeeInfoes", "FatherName");
            DropColumn("dbo.EmployeeInfoes", "NationalId");
            DropColumn("dbo.EmployeeInfoes", "EmergencyContactNo");
            CreateIndex("dbo.OfficialInfoes", "BranchId");
            CreateIndex("dbo.EmployeeInfoes", "OfficialInfoId");
            CreateIndex("dbo.EmployeeInfoes", "PersonalInfoId");
            AddForeignKey("dbo.EmployeeInfoes", "PersonalInfoId", "dbo.PersonalInfoes", "Id");
            AddForeignKey("dbo.EmployeeInfoes", "OfficialInfoId", "dbo.OfficialInfoes", "Id");
            AddForeignKey("dbo.OfficialInfoes", "BranchId", "dbo.Branches", "Id");
        }
    }
}
