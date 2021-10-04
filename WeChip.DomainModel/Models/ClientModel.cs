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
        public string ErrorMessage { get; private set; }

     
        public bool CanBuy()
        {
            return IsProductSelected()
                && HasCreditEnough()
                && IsHardwareSelectedWithAddress();
        }

        private bool IsProductSelected()
        {
            if (Products != null && Products.Any())
                return true;
            else
            {
                ErrorMessage = "Selecione ao menos 1 (um) produto.";
                return false;
            }
        }
        private bool HasCreditEnough()
        {
            if (Credit >= Products.Sum(p => p.Price))
                return true;
            else
            {
                ErrorMessage = $"{Name} não possui créditos suficientes.";
                return false;
            }
        }
        private bool IsHardwareSelectedWithAddress()
        {
            if (Products.Select(s => s.Type == TypeEnum.HARDWARE)
                                .FirstOrDefault()
                                && DeliveryClientAddress != null
                                && !DeliveryClientAddress.IsAnyNullOrEmpty())
                return true;
            else
            {
                ErrorMessage = $"Ao selecionar itens do tipo {TypeEnum.HARDWARE} é necessário preencher todos os campos de endereço.";
                return false;
            }
             
        }

    }
}
