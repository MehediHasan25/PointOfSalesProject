using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class Branch
    {
        public int Id { get; set; }
        public string BranchCode { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }

        public int OrganizationId { get; set; }
        public Organizations Organization { get; set; }

    }
}
