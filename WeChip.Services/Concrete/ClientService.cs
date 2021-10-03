using System;
using System.Collections.Generic;
using System.Text;
using WeChip.Domain.Database;
using WeChip.Services.Interface;

namespace WeChip.Services.Concrete
{
    public class ClientService : IClientService
    {
        Domain.Models.ClientModel IClientService.Get(string CPF)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Domain.Models.ClientModel> IClientService.GetAll()
        {
            throw new NotImplementedException();
        }

        void IClientService.Insert(Domain.Models.ClientModel client)
        {
            LoadFromMemory.Insert(client);
        }

        void IClientService.UpdateStatus(string CPF)
        {
            throw new NotImplementedException();
        }
    }
}
