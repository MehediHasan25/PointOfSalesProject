using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class IncomeReport
    {
        public int Id { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }

        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

        public int? PurchaseReportId { get; set; }
        public PurchaseReport PurchaseReport { get; set; }

        public int? SalesReportId { get; set; }
        public SalesReport SalesReport { get; set; }

        public List<IncomeReportDetails> IncomeReportDetailses { get; set; }

    }
}
