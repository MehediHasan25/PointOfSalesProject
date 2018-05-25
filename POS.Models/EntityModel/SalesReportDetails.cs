using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class SalesReportDetails
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string  SalesTotal { get; set; }

        public int? PartyId { get; set; }
        public Party Party { get; set; }

        public int? SalesReportId { get; set; }
        public SalesReport SalesReport { get; set; }
    }
}
