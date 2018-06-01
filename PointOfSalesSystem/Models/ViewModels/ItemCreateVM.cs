using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class ItemCreateVM
    {
        public string Name { get; set; }
        public double CostsPrice { get; set; }
        public double SalesPrice { get; set; }
        public string ItemCode { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }

        public int? ItemCategoryId { get; set; }
        public List<ItemCategory> ItemCategories { get; set; }

        public List<Item> ChildItems { get; set; }
    }
}