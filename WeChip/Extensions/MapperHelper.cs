using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChip.Domain.Models;
using WeChip.Model.ViewModels;

namespace WeChip.Helpers
{
    public static class MapperExtension
    {
        public static ClientModel ToClient(this ClientRegisterViewModel client)
        {
            return new ClientModel()
            {

                CPF = client.CPF,
                Credit = decimal.Parse(client.Credit),
                Name = client.Name,
                Phone = client.Phone
            };
        }
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
                Status = $"{client.Status.StatusCode.ToString().PadLeft(4, '0')} - {client.Status.Description}",
                StatusCode = client.Status.StatusCode.ToString().PadLeft(4, '0'),
                Products = client.Products.ToProductList()
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
        public static DeliveryClientAddressModel ToAddress(this DeliveryClientAddressViewModel address) {

            return new DeliveryClientAddressModel()
            {
                State = address.State,
                CEP = address.CEP,
                City = address.City,
                Complement = address.Complement,
                Neighbourhood = address.Neighbourhood,
                NumberAddress = byte.Parse(address.NumberAddress),
                Street = address.Street
            };
        }
    }
}
