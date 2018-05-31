using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public class ExpenseDetails
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ExpenseItemTotalPrice { get; set; }
        public String Description { get; set; }
        public int Amount { get; set; }

        public int? ExpenseId { get; set; }
        public Expense Expense { get; set; }

        public int? ExpenseItemId { get; set; }
        public ExpenseItem ExpenseItem { get; set; }

    }
}
