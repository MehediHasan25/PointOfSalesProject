using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string PartyCode { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PartyType { get; set; }
        
    }
}
