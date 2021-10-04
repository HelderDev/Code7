using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip.DomainModel.Models
{
    public class DeliveryClientAddressModel
    {
        public string CEP { get; set; }
        public string Street { get; set; }
        public int NumberAddress { get; set; }
        public string Complement { get; set; }
        public string Neighbourhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
