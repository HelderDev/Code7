using System;
using System.Collections.Generic;
using System.Text;

namespace WeChip.Domain.Models
{
    public class ClientModel
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public decimal Credit { get; set; }
        public string Phone { get; set; }
        public StatusModel Status { get; set; }
        public DeliveryClientAddressModel DeliveryClientAddress { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
