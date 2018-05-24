using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository.DatabaseContext
{
   public  class PosManagementDbContext:DbContext
    {
        
        public DbSet<Branch> Branches { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public DbSet<OfficialInfo> OfficialInfos { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<ExpenseDetails> ExpenseDetailses { get; set; }
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<ExpenseReport> ExpenseReports { get; set; }
        public DbSet<ExpenseReportDetails> ExpenseReportDetails { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Organizations> Organizationses { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetailses { get; set; }
        public DbSet<PurchaseReport> PurchaseReports { get; set; }
        public DbSet<PurchaseReportDetails> PurchaseReportDetailses { get; set; }
        public DbSet<Sales> Saleses { get; set; }
        public DbSet<SalesDetails> SalesDetailses { get; set; }
        public DbSet<SalesReport> SalesReports { get; set; }
        public DbSet<SalesReportDetails> GetSalesReportDetailses { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockReport> StockReports { get; set; }
        public DbSet<StockReportDetails> StockReportDetailses { get; set; }
        public DbSet<IncomeReport> IncomeReports { get; set; }
        public DbSet<IncomeReportDetails> IncomeReportDetails { get; set; }


    }
}
