using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class Expense
    {
        public int Id { get; set; }
        public int ExpenseNumber { get; set; }
        public string ExpenseDate { get; set; }
        public string ReasonsOfExpense { get; set; }
        public long  ExpenseTotalAmount { get; set; }

        //Organization Refered
        public int OrgnaizationId { get; set; }
        public Organizations organization { get; set; }

        //Branch Refered
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        //Employee Refered
        public int EmployeeInfoId { get; set; }
        public EmployeeInfo Employee { get; set; }

        /// List OF Purchase Detais
        public List<ExpenseDetails> ExpenseDetailses { get; set; }
    }
}
