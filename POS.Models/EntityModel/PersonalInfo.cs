using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class PersonalInfo
    {
        public int Id { get; set; }
        public string EmergencyContactNo { get; set; }
        public string NationalId { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }

    }
}
