using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class OrganizationsCreateVM
    {
        public string Name { get; set; }
        [Display(Name= "Code")]
        public string OrganizationCode { get; set; }
        public string ContactNo { get; set; }
        public byte[] Image { get; set; }
        public string Address { get; set; }
        public List<Organizations> Organizationses { get; set; }
    }
}