using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class StockCreateVM
    {
        public int StockQuantity { get; set; }

        public double AvgPrice { get; set; }

        public string CategoryFullPath { get; set; }



        public int? BranchId { get; set; }
        //Item Reference
        public int? ItemId { get; set; }
    }
}