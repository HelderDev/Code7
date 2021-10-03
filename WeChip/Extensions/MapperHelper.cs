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
                Credit = client.Credit,
                Name = client.Name,
                Phone = client.Phone
            };
        }
    }
}
