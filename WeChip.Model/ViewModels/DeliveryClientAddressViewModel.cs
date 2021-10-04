using System;
using System.Collections.Generic;
using System.Text;

namespace WeChip.Model.ViewModels
{
    public class DeliveryClientAddressViewModel
    {
        public string CEP { get; set; }
        public string Street { get; set; }
        public string NumberAddress { get; set; }
        public string Complement { get; set; }
        public string Neighbourhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
