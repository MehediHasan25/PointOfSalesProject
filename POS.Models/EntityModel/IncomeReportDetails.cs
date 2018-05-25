using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public class IncomeReportDetails
    {
        public int Id { get; set; }
        public double TotalPurchase { get; set; }
        public double TotalSales { get; set; }

        public int? IncomeReportId { get; set; }
        public IncomeReport IncomeReport { get; set; }
    }
}
