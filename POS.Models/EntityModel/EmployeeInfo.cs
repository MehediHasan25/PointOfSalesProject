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

        public int PersonalInfoId { get; set; }
        public PersonalInfo PersonalInfo { get; set; }

        public int OfficialInfoId { get; set; }
        public OfficialInfo OfficialInfo { get; set; }

        public int ReferenceId { get; set; }
        public EmployeeInfo Reference { get; set; }
    }
}
