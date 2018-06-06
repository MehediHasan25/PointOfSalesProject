using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public class EmployeeInfo
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
        public string Code { get; set;}
        public string ContactNo { get; set; }
        public string JoiningDate { get; set; }
        public string PersonalContactNo { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }

        public int? EmployeeInfosId { get; set; }
        public virtual EmployeeInfo EmployeeInfos { get; set; }



        public int? BranchId { get; set; }
        public virtual Branch Branch{ get; set;}

        public virtual List<PurchaseReceiving> PurchasesReceivings { get; set; }



    }
}
