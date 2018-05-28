using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class Organizations
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string OrganizationCode { get; set; }
        public string ContactNo { get; set; }
        public byte[] Image { get; set; }
        public string Address { get; set; }
        

        public List<Branch> Branches { get; set; }
    }
}
