using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class ExpenseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ItemCode { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }

        //Expense Category Refere
        public int? ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }

        
    }
}
