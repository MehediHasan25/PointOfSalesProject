using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class Branch
    {
        public int Id { get; set; }
        public string BranchCode { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }

        public int? OrganizationsId { get; set; }
        public virtual Organizations Organizations { get; set; }

        public virtual  List<Expense> Expenses { get; set; }
        public virtual List<Sales> Saleses { get; set; }
        public virtual List<PurchaseReceiving> PurchaseReceivings { get; set; }
         public virtual List<PurchaseReport> PurchaseReports { get; set; }
        public virtual List<ExpenseReport> ExpenseReports { get; set; }
        public virtual List<SalesReport> SalesReports { get; set; }
        public virtual List<StockReport> StockReports { get; set; }
        public virtual List<IncomeReport> IncomeReports { get; set; }

    }
}
