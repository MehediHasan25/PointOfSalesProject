using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class EmployeeInfoCreateVM
    {
        public int Id { get; set; }
        //Personal Info
        public string EmergencyContactNo { get; set; }
        public string NationalId { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }

        //Official Info

        public string Name { get; set; }
        public string Code { get; set; }
        public string ContactNo { get; set; }
        public string JoiningDate { get; set; }
        public string PersonalContactNo { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }

        public int? EmployeeInfosId { get; set; }

        public int? BranchId { get; set; }
        public List<Branch> Branches { get; set; }

        public List<EmployeeInfo> EmployeeInfoses { get; set; }
    }
}