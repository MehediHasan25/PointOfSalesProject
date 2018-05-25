using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public  class SalesReport
    {
        public int Id { get; set; }
        public string SalesCode { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }

        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

        public List<SalesReportDetails> SalesReportDetailses { get; set; }
    }
}
