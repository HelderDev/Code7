using System;
using System.Collections.Generic;
using System.Text;
using WeChip.Domain.Models;

namespace WeChip.Model.ViewModels
{
    public class LinkOfferClientViewModel
    {
        public ClientRegisterViewModel Client { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public List<ProductViewModel> Products { get; set; }
        public DeliveryClientAddressViewModel Address { get; set; }
    }
}
