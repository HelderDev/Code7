using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChip.Domain.Database;
using WeChip.Domain.Models;
using WeChip.Services.Interface;

namespace WeChip.Services.Concrete
{
    public class ClientService : IClientService
    {
        ClientModel IClientService.Get(string CPF)
        {
            return Get(CPF);
        }

        IEnumerable<ClientModel> IClientService.GetAll()
        {
            return LoadFromMemory.LoadClient();
        }

        void IClientService.Insert(ClientModel client)
        {
            Insert(client);
        }
        void IClientService.Update(ClientModel client)
        {
            var cli = Get(client.CPF);
            Delete(cli);
            Insert(cli);
        }
        private ClientModel Get(string CPF)
        {
            return LoadFromMemory.LoadClient().FirstOrDefault(c => c.CPF == CPF);
        }
        private void Delete(ClientModel client)
        {
            LoadFromMemory.RemoveClient(client);
        }
        private void Insert(ClientModel client)
        {
            LoadFromMemory.Insert(client);
        }
    }
}
