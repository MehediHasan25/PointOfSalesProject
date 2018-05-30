namespace POS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchCode = c.String(),
                        Name = c.String(),
                        ContactNo = c.String(),
                        Address = c.String(),
                        OrganizationsId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationsId)
                .Index(t => t.OrganizationsId);
            
            CreateTable(
                "dbo.ExpenseReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpenseCode = c.String(),
                        FromDate = c.String(),
                        ToDate = c.String(),
                        BranchId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.ExpenseReportDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Description = c.String(),
                        TotalExpense = c.Double(nullable: false),
                        ExpenseReportId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseReports", t => t.ExpenseReportId)
                .Index(t => t.ExpenseReportId);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpenseNumber = c.Int(nullable: false),
                        ExpenseDate = c.String(),
                        ReasonsOfExpense = c.String(),
                        ExpenseTotalAmount = c.Long(nullable: false),
                        ExpenseItemId = c.Int(nullable: false),
                        BranchId = c.Int(),
                        EmployeeInfoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.EmployeeInfoes", t => t.EmployeeInfoId, cascadeDelete: true)
                .ForeignKey("dbo.ExpenseItems", t => t.ExpenseItemId, cascadeDelete: true)
                .Index(t => t.ExpenseItemId)
                .Index(t => t.BranchId)
                .Index(t => t.EmployeeInfoId);
            
            CreateTable(
                "dbo.EmployeeInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmergencyContactNo = c.String(),
                        NationalId = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        PermanentAddress = c.String(),
                        PresentAddress = c.String(),
                        Name = c.String(),
                        Code = c.String(),
                        ContactNo = c.String(),
                        JoiningDate = c.String(),
                        PersonalContactNo = c.String(),
                        Email = c.String(),
                        Image = c.Binary(),
                        EmployeeInfosId = c.Int(),
                        BranchId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.EmployeeInfoes", t => t.EmployeeInfosId)
                .Index(t => t.EmployeeInfosId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.PurchaseReceivings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        PurchasePrice = c.Int(nullable: false),
                        PurchaseNumber = c.Int(nullable: false),
                        PurchaseDate = c.String(),
                        Remarks = c.String(),
                        PurchaseTotalAmount = c.Long(nullable: false),
                        ItemId = c.Int(),
                        BranchId = c.Int(),
                        PartyId = c.Int(),
                        EmployeeInfoId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.EmployeeInfoes", t => t.EmployeeInfoId)
                .ForeignKey("dbo.Items", t => t.ItemId)
                .ForeignKey("dbo.Parties", t => t.PartyId)
                .Index(t => t.ItemId)
                .Index(t => t.BranchId)
                .Index(t => t.PartyId)
                .Index(t => t.EmployeeInfoId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CostsPrice = c.Double(nullable: false),
                        SalesPrice = c.Double(nullable: false),
                        ItemCode = c.String(),
                        Image = c.Binary(),
                        ItemCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemCategories", t => t.ItemCategoryId)
                .Index(t => t.ItemCategoryId);
            
            CreateTable(
                "dbo.ItemCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ItemCategoryCode = c.String(),
                        Description = c.String(),
                        Image = c.Binary(),
                        ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemCategories", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Parties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.Binary(),
                        PartyCode = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        PartyType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PurchaseReceivingDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        PurchaseItemTotalPrice = c.Int(nullable: false),
                        PurchaseReceivingId = c.Int(),
                        ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId)
                .ForeignKey("dbo.PurchaseReceivings", t => t.PurchaseReceivingId)
                .Index(t => t.PurchaseReceivingId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.ExpenseDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ExpenseItemTotalPrice = c.Int(nullable: false),
                        ExpenseId = c.Int(),
                        ExpenseItemId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Expenses", t => t.ExpenseId)
                .ForeignKey("dbo.ExpenseItems", t => t.ExpenseItemId)
                .Index(t => t.ExpenseId)
                .Index(t => t.ExpenseItemId);
            
            CreateTable(
                "dbo.ExpenseItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        ItemCode = c.String(),
                        Image = c.Binary(),
                        ExpenseCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCategories", t => t.ExpenseCategoryId)
                .Index(t => t.ExpenseCategoryId);
            
            CreateTable(
                "dbo.ExpenseCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ItemCategoryCode = c.String(),
                        Description = c.String(),
                        Image = c.Binary(),
                        ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCategories", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.IncomeReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FromDate = c.String(),
                        ToDate = c.String(),
                        BranchId = c.Int(),
                        PurchaseReportId = c.Int(),
                        SalesReportId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.PurchaseReports", t => t.PurchaseReportId)
                .ForeignKey("dbo.SalesReports", t => t.SalesReportId)
                .Index(t => t.BranchId)
                .Index(t => t.PurchaseReportId)
                .Index(t => t.SalesReportId);
            
            CreateTable(
                "dbo.IncomeReportDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalPurchase = c.Double(nullable: false),
                        TotalSales = c.Double(nullable: false),
                        IncomeReportId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IncomeReports", t => t.IncomeReportId)
                .Index(t => t.IncomeReportId);
            
            CreateTable(
                "dbo.PurchaseReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchaseCode = c.String(),
                        FromDate = c.String(),
                        ToDate = c.String(),
                        BranchId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.PurchaseReportDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Description = c.String(),
                        PurchaseTotal = c.Double(nullable: false),
                        PartyId = c.Int(),
                        PurchaseReportId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parties", t => t.PartyId)
                .ForeignKey("dbo.PurchaseReports", t => t.PurchaseReportId)
                .Index(t => t.PartyId)
                .Index(t => t.PurchaseReportId);
            
            CreateTable(
                "dbo.SalesReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalesCode = c.String(),
                        FromDate = c.String(),
                        ToDate = c.String(),
                        BranchId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.SalesReportDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Description = c.String(),
                        SalesTotal = c.String(),
                        PartyId = c.Int(),
                        SalesReportId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parties", t => t.PartyId)
                .ForeignKey("dbo.SalesReports", t => t.SalesReportId)
                .Index(t => t.PartyId)
                .Index(t => t.SalesReportId);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OrganizationCode = c.String(),
                        ContactNo = c.String(),
                        Image = c.Binary(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalesNumber = c.Int(nullable: false),
                        SalesDate = c.String(),
                        VAT = c.Int(nullable: false),
                        Dicount = c.Int(nullable: false),
                        SalesTotalAmount = c.Long(nullable: false),
                        PartyId = c.Int(),
                        BranchId = c.Int(),
                        EmployeeInfoId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.EmployeeInfoes", t => t.EmployeeInfoId)
                .ForeignKey("dbo.Parties", t => t.PartyId)
                .Index(t => t.PartyId)
                .Index(t => t.BranchId)
                .Index(t => t.EmployeeInfoId);
            
            CreateTable(
                "dbo.SalesDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        SalesItemTotalPrice = c.Int(nullable: false),
                        SalesId = c.Int(),
                        ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId)
                .ForeignKey("dbo.Sales", t => t.SalesId)
                .Index(t => t.SalesId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.StockReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.StockReportDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryFullPath = c.String(),
                        AveragePrice = c.Double(nullable: false),
                        StockId = c.Int(),
                        ItemId = c.Int(),
                        StockReportId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId)
                .ForeignKey("dbo.Stocks", t => t.StockId)
                .ForeignKey("dbo.StockReports", t => t.StockReportId)
                .Index(t => t.StockId)
                .Index(t => t.ItemId)
                .Index(t => t.StockReportId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockQuantity = c.Int(nullable: false),
                        BranchId = c.Int(),
                        ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.Items", t => t.ItemId)
                .Index(t => t.BranchId)
                .Index(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockReportDetails", "StockReportId", "dbo.StockReports");
            DropForeignKey("dbo.StockReportDetails", "StockId", "dbo.Stocks");
            DropForeignKey("dbo.Stocks", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Stocks", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.StockReportDetails", "ItemId", "dbo.Items");
            DropForeignKey("dbo.StockReports", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.SalesDetails", "SalesId", "dbo.Sales");
            DropForeignKey("dbo.SalesDetails", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Sales", "PartyId", "dbo.Parties");
            DropForeignKey("dbo.Sales", "EmployeeInfoId", "dbo.EmployeeInfoes");
            DropForeignKey("dbo.Sales", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Branches", "OrganizationsId", "dbo.Organizations");
            DropForeignKey("dbo.IncomeReports", "SalesReportId", "dbo.SalesReports");
            DropForeignKey("dbo.SalesReportDetails", "SalesReportId", "dbo.SalesReports");
            DropForeignKey("dbo.SalesReportDetails", "PartyId", "dbo.Parties");
            DropForeignKey("dbo.SalesReports", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.IncomeReports", "PurchaseReportId", "dbo.PurchaseReports");
            DropForeignKey("dbo.PurchaseReportDetails", "PurchaseReportId", "dbo.PurchaseReports");
            DropForeignKey("dbo.PurchaseReportDetails", "PartyId", "dbo.Parties");
            DropForeignKey("dbo.PurchaseReports", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.IncomeReportDetails", "IncomeReportId", "dbo.IncomeReports");
            DropForeignKey("dbo.IncomeReports", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Expenses", "ExpenseItemId", "dbo.ExpenseItems");
            DropForeignKey("dbo.ExpenseDetails", "ExpenseItemId", "dbo.ExpenseItems");
            DropForeignKey("dbo.ExpenseItems", "ExpenseCategoryId", "dbo.ExpenseCategories");
            DropForeignKey("dbo.ExpenseCategories", "ParentId", "dbo.ExpenseCategories");
            DropForeignKey("dbo.ExpenseDetails", "ExpenseId", "dbo.Expenses");
            DropForeignKey("dbo.Expenses", "EmployeeInfoId", "dbo.EmployeeInfoes");
            DropForeignKey("dbo.PurchaseReceivingDetails", "PurchaseReceivingId", "dbo.PurchaseReceivings");
            DropForeignKey("dbo.PurchaseReceivingDetails", "ItemId", "dbo.Items");
            DropForeignKey("dbo.PurchaseReceivings", "PartyId", "dbo.Parties");
            DropForeignKey("dbo.PurchaseReceivings", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "ItemCategoryId", "dbo.ItemCategories");
            DropForeignKey("dbo.ItemCategories", "ParentId", "dbo.ItemCategories");
            DropForeignKey("dbo.PurchaseReceivings", "EmployeeInfoId", "dbo.EmployeeInfoes");
            DropForeignKey("dbo.PurchaseReceivings", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.EmployeeInfoes", "EmployeeInfosId", "dbo.EmployeeInfoes");
            DropForeignKey("dbo.EmployeeInfoes", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Expenses", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.ExpenseReportDetails", "ExpenseReportId", "dbo.ExpenseReports");
            DropForeignKey("dbo.ExpenseReports", "BranchId", "dbo.Branches");
            DropIndex("dbo.Stocks", new[] { "ItemId" });
            DropIndex("dbo.Stocks", new[] { "BranchId" });
            DropIndex("dbo.StockReportDetails", new[] { "StockReportId" });
            DropIndex("dbo.StockReportDetails", new[] { "ItemId" });
            DropIndex("dbo.StockReportDetails", new[] { "StockId" });
            DropIndex("dbo.StockReports", new[] { "BranchId" });
            DropIndex("dbo.SalesDetails", new[] { "ItemId" });
            DropIndex("dbo.SalesDetails", new[] { "SalesId" });
            DropIndex("dbo.Sales", new[] { "EmployeeInfoId" });
            DropIndex("dbo.Sales", new[] { "BranchId" });
            DropIndex("dbo.Sales", new[] { "PartyId" });
            DropIndex("dbo.SalesReportDetails", new[] { "SalesReportId" });
            DropIndex("dbo.SalesReportDetails", new[] { "PartyId" });
            DropIndex("dbo.SalesReports", new[] { "BranchId" });
            DropIndex("dbo.PurchaseReportDetails", new[] { "PurchaseReportId" });
            DropIndex("dbo.PurchaseReportDetails", new[] { "PartyId" });
            DropIndex("dbo.PurchaseReports", new[] { "BranchId" });
            DropIndex("dbo.IncomeReportDetails", new[] { "IncomeReportId" });
            DropIndex("dbo.IncomeReports", new[] { "SalesReportId" });
            DropIndex("dbo.IncomeReports", new[] { "PurchaseReportId" });
            DropIndex("dbo.IncomeReports", new[] { "BranchId" });
            DropIndex("dbo.ExpenseCategories", new[] { "ParentId" });
            DropIndex("dbo.ExpenseItems", new[] { "ExpenseCategoryId" });
            DropIndex("dbo.ExpenseDetails", new[] { "ExpenseItemId" });
            DropIndex("dbo.ExpenseDetails", new[] { "ExpenseId" });
            DropIndex("dbo.PurchaseReceivingDetails", new[] { "ItemId" });
            DropIndex("dbo.PurchaseReceivingDetails", new[] { "PurchaseReceivingId" });
            DropIndex("dbo.ItemCategories", new[] { "ParentId" });
            DropIndex("dbo.Items", new[] { "ItemCategoryId" });
            DropIndex("dbo.PurchaseReceivings", new[] { "EmployeeInfoId" });
            DropIndex("dbo.PurchaseReceivings", new[] { "PartyId" });
            DropIndex("dbo.PurchaseReceivings", new[] { "BranchId" });
            DropIndex("dbo.PurchaseReceivings", new[] { "ItemId" });
            DropIndex("dbo.EmployeeInfoes", new[] { "BranchId" });
            DropIndex("dbo.EmployeeInfoes", new[] { "EmployeeInfosId" });
            DropIndex("dbo.Expenses", new[] { "EmployeeInfoId" });
            DropIndex("dbo.Expenses", new[] { "BranchId" });
            DropIndex("dbo.Expenses", new[] { "ExpenseItemId" });
            DropIndex("dbo.ExpenseReportDetails", new[] { "ExpenseReportId" });
            DropIndex("dbo.ExpenseReports", new[] { "BranchId" });
            DropIndex("dbo.Branches", new[] { "OrganizationsId" });
            DropTable("dbo.Stocks");
            DropTable("dbo.StockReportDetails");
            DropTable("dbo.StockReports");
            DropTable("dbo.SalesDetails");
            DropTable("dbo.Sales");
            DropTable("dbo.Organizations");
            DropTable("dbo.SalesReportDetails");
            DropTable("dbo.SalesReports");
            DropTable("dbo.PurchaseReportDetails");
            DropTable("dbo.PurchaseReports");
            DropTable("dbo.IncomeReportDetails");
            DropTable("dbo.IncomeReports");
            DropTable("dbo.ExpenseCategories");
            DropTable("dbo.ExpenseItems");
            DropTable("dbo.ExpenseDetails");
            DropTable("dbo.PurchaseReceivingDetails");
            DropTable("dbo.Parties");
            DropTable("dbo.ItemCategories");
            DropTable("dbo.Items");
            DropTable("dbo.PurchaseReceivings");
            DropTable("dbo.EmployeeInfoes");
            DropTable("dbo.Expenses");
            DropTable("dbo.ExpenseReportDetails");
            DropTable("dbo.ExpenseReports");
            DropTable("dbo.Branches");
        }
    }
}
