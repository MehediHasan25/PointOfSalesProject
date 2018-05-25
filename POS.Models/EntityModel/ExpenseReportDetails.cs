using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public class ExpenseReportDetails
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public double TotalExpense { get; set; }

        public int? ExpenseReportId { get; set; }
        public ExpenseReport ExpenseReport { get; set; }
    }
}
