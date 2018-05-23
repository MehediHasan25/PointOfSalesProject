using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public class OfficialInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JoiningDate { get; set; }
        public string PersonalContactNo { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
