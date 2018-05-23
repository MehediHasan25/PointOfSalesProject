using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemCategoryCode { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public int? ParentId { get; set; }
        public ExpenseCategory Parent { get; set; }

        public List<ExpenseCategory> Childs { get; set; }
    }
}
