using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class StockReport
    {
        public int Id { get; set; }

        public int? BranchId { get; set; }
        public Branch Branch { get; set; }


        public List<StockReportDetails> StockReportDetailses { get; set; }
    }
}
