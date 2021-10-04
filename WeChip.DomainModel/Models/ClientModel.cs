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

        /// <summary>
        /// Faz todas as seguintes validações:
        /// > Verifica se há algum produto associado ao cliente
        /// > Verifica se há crédito suficiente para efetuar a compra
        /// > Verifica se o cliente que preencheu com a opção HARDWARE também preencheu o endereço
        /// > Verifica se o cliente conseguiu aceitar a oferta
        /// </summary>
        /// <returns></returns>
        public bool CanBuy()
        {
            return IsProductSelected()
                && HasCreditEnough()
                && IsHardwareSelectedWithAddress()
                && HasClientAccepted();
        }

        /// <summary>
        /// Verifica se há algum produto associado ao cliente
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Verifica se há crédito suficiente para efetuar a compra
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Verifica se o cliente que preencheu com a opção HARDWARE também preencheu o endereço
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Verifica se o cliente conseguiu aceitar a oferta
        /// </summary>
        /// <returns></returns>
        private bool HasClientAccepted()
        {
            if (Status.AccountSale)
                return true;
            else
            {
                ErrorMessage = $"Não foi possivel para o cliente {Name} aceitar a oferta \n[Motivo: {Status.Description}]";
                return false;
            }
        }
    }
}
