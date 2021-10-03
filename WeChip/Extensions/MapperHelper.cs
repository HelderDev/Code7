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
            return new LinkOfferClientViewModel()
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
                Products = client.Products
            };
        }
    }
}
