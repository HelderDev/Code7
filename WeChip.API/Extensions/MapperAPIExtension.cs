using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChip.DomainModel.Models;
using WeChip.ViewModel.API;

namespace WeChip.API.Extensions
{
    public static class MapperAPIExtension
    {
        public static OfferApiModel ToAPIOffer(this ClientModel client)
        {
            return new OfferApiModel()
            {
                CPF = client.CPF,
                ProductIds = client.Products != null ?
                             client.Products
                            .Select(p => p.ProductCode).ToArray() 
                            : null,
                StatusCode = (short)client.Status.StatusCode,
                OfferCode = client.OfferCode
            };
        }
    }
}
