using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository.DatabaseContext
{
    public class PosManagementDbContext : DbContext
    {
        public DbSet<Organizations> Organizationses { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfoes { get; set; }
        
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<ExpenseDetails> ExpenseDetailses { get; set; }
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<ExpenseReport> ExpenseReports { get; set; }
        public DbSet<ExpenseReportDetails> ExpenseReportDetailses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<PurchaseReceiving> PurchaseReceivings { get; set; }
        public DbSet<PurchaseReceivingDetails> PurchaseDetailses { get; set; }
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
        public DbSet<IncomeReportDetails> IncomeReportDetailses { get; set; }

        
    }
}