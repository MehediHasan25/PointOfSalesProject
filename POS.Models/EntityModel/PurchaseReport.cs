using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class PurchaseReport
    {
        public int Id { get; set; }
        public string PurchaseCode { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }

        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

        public List<PurchaseReportDetails> PurchaseReportDetailses { get; set; }
    }
}
