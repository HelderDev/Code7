using System.Collections.Generic;
using System.Linq;
using WeChip.DomainModel.Models;
using WeChip.Model.ViewModels;
using WeChip.ViewModel.ViewModels;

namespace WeChip.Helpers
{
    public static class MapperExtension
    {
        /// <summary>
        /// Converte o objeto Client da ViewModel para Client da DomainModel
        /// </summary>
        /// <param name="client">objeto cliente da ViewModel</param>
        /// <returns></returns>
        public static ClientModel ToClient(this ClientRegisterViewModel client)
        {
            return new ClientModel()
            {

                CPF = client.CPF,
                Credit = !string.IsNullOrEmpty(client.Credit) ? decimal.Parse(client.Credit) : 0,
                Name = client.Name,
                Phone = client.Phone
            };
        }

        /// <summary>
        /// Converte o objeto Client da DomainModel para o objeto LinkOfferClient da ViewModel
        /// </summary>
        /// <param name="client">Objeto Client da DomainModel</param>
        /// <returns></returns>
        public static LinkOfferClientViewModel ToLinkOfferView(this ClientModel client)
        {
            var linkOfferClient = new LinkOfferClientViewModel()
            {
                Client = new ClientRegisterViewModel()
                {

                    CPF = client.CPF,
                    Credit = client.Credit.ToString(),
                    Name = client.Name,
                    Phone = client.Phone
                },
                Status = $"{((short)client.Status.StatusCode).ToString().PadLeft(4, '0')} - {client.Status.Description}",
                StatusCode = ((short)client.Status.StatusCode).ToString().PadLeft(4, '0'),
                Products = client.Products != null ? client.Products.ToList().ToProductList() : new List<ProductViewModel>()
            };
            if (client.DeliveryClientAddress != null)
            {
                linkOfferClient.Address = new DeliveryClientAddressViewModel()
                {
                    CEP = client.DeliveryClientAddress.CEP,
                    City = client.DeliveryClientAddress.City,
                    Complement = client.DeliveryClientAddress.Complement,
                    Neighbourhood = client.DeliveryClientAddress.Neighbourhood,
                    NumberAddress = client.DeliveryClientAddress.NumberAddress.ToString(),
                    State = client.DeliveryClientAddress.State,
                    Street = client.DeliveryClientAddress.Street
                };
            }
            return linkOfferClient;
        }

        /// <summary>
        /// Converte a lista do tipo Product da DomainModel para a lista do tipo Product da ViewModel
        /// </summary>
        /// <param name="product">Lista de produtos da DomainModel</param>
        /// <returns></returns>
        public static List<ProductViewModel> ToProductList(this List<ProductModel> product)
        {
            if (product == null || !product.Any())
                return new List<ProductViewModel>();

            var productViewModelList = new List<ProductViewModel>();
            foreach (var item in product)
            {
                productViewModelList.Add(
                     new ProductViewModel()
                     {
                         Description = item.Description,
                         ProductCode = item.ProductCode.ToString().PadLeft(4, '0'),
                         Type = item.Type.ToString(),
                         Price = item.Price.ToString()
                     }
                    );
            }
            return productViewModelList;
        }

        /// <summary>
        /// Converte o objeto DeliveryAddress da ViewModel para o objeto DeliveryAddress da DomainModel
        /// </summary>
        /// <param name="address">Objeto DeliveryAddress da ViewModel</param>
        /// <returns></returns>
        public static DeliveryClientAddressModel ToAddress(this DeliveryClientAddressViewModel address)
        {

            return new DeliveryClientAddressModel()
            {
                State = address.State,
                CEP = address.CEP,
                City = address.City,
                Complement = address.Complement,
                Neighbourhood = address.Neighbourhood,
                NumberAddress = int.Parse(address.NumberAddress),
                Street = address.Street
            };
        }
        /// <summary>
        /// Converte uma lista de Status do DomainModel para uma lista de Status da ViewModel
        /// </summary>
        /// <param name="statusModelList">Lista de Status da DomainModel</param>
        /// <returns></returns>
        public static List<StatusViewModel> ToStatus(this List<StatusModel> statusModelList)
        {
            var statusViewList = new List<StatusViewModel>();
            foreach (var item in statusModelList)
            {
                statusViewList.Add(
                    new StatusViewModel()
                    {
                        AccountSale = item.AccountSale,
                        Description = item.Description,
                        StatusCode = (short)item.StatusCode,
                        TerminateClient = item.TerminateClient
                    }
                    );
            }
            return statusViewList;
        }

    }
}
