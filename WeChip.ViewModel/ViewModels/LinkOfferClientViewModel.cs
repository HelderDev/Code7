using System.Collections.Generic;
using WeChip.DomainModel.Enums;

namespace WeChip.Model.ViewModels
{
    public class LinkOfferClientViewModel
    {
        public ClientRegisterViewModel Client { get; set; }
        public string Status { get; set; }
        public StatusEnum StatusCode { get; set; }
        public List<ProductViewModel> Products { get; set; }
        public DeliveryClientAddressViewModel Address { get; set; }
         
    }
}
