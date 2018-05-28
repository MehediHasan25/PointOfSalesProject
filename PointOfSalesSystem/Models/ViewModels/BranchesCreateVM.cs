using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class BranchesCreateVM
    {
        
        [Display(Name = "Organization")]
        public int? OrganizationId { get; set; }
        [Display(Name = "BranchName")]
        public string Name { get; set; }
        [Display(Name="Code")]
        public string BranchCode { get; set; }
        
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public List <Organizations> Organization { get; set; }
    }
}