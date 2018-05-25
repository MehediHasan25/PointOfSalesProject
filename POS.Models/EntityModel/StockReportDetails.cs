using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
  public  class StockReportDetails
    {
        public int Id { get; set; }
        public string CategoryFullPath { get; set; }
        public double AveragePrice { get; set; }

        public int? StockId { get; set; }
        public Stock Stock { get; set; }

        public int? ItemId { get; set; }
        public Item Item { get; set; }

        public int? StockReportId { get; set; }
        public StockReport StockReport { get; set; }
    }
}
