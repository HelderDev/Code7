using System;
using System.Collections.Generic;
using System.Text;
using WeChip.Domain.Models;

namespace WeChip.Services.Interface
{
    public interface IClientService
    {
        void Insert(ClientModel client);
        ClientModel Get(string CPF);
        IEnumerable<ClientModel> GetAll();
        void Update(ClientModel client);
    }
}
