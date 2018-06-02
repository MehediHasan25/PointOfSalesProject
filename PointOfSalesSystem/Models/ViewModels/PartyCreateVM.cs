using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class PartyCreateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string PartyCode { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PartyType { get; set; }
        public string RadioButton { get; set; }

        public List<Party> Parties;
    }
}