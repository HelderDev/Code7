using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChip.DomainModel.Enums;
using WeChip.DomainModel.Extensions;

namespace WeChip.DomainModel.Models
{
    public class ClientModel
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public decimal Credit { get; set; }
        public string Phone { get; set; }
        public StatusModel Status { get; set; }
        public DeliveryClientAddressModel DeliveryClientAddress { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }

        public bool CanBuy()
        {
            return IsProductSelected() 
                && HasCreditEnough() 
                && IsHardwareSelectedWithAddress();
        }

        private bool IsProductSelected()
        {
            return Products != null && Products.Any();
        }
        private bool HasCreditEnough()
        {
            return Credit >= Products.Sum(p => p.Price);
        }
        private bool IsHardwareSelectedWithAddress()
        {
            return Products.Select(s => s.Type == TypeEnum.HARDWARE)
                                .FirstOrDefault() 
                                && DeliveryClientAddress != null 
                                && !DeliveryClientAddress.IsAnyNullOrEmpty();
        }

    }
}
