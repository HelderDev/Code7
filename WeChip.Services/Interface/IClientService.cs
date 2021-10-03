using System;
using System.Collections.Generic;
using System.Text;
using WeChip.Domain.Models;

namespace WeChip.Services.Interface
{
    public interface IClientService
    {
        void Insert(ClientModel client);
        void UpdateStatus(string CPF);
        ClientModel Get(string CPF);
        IEnumerable<ClientModel> GetAll();
    }
}
