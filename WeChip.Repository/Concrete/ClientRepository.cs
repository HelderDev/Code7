using System.Collections.Generic;
using System.Linq;
using WeChip.Domain.Database;
using WeChip.DomainModel.Models;
using WeChip.Repository.Interface;

namespace WeChip.Repository.Concrete
{
    public class ClientRepository : IClientRepository
    {
        ClientModel IClientRepository.Get(string CPF)
        {
            return Get(CPF);
        }

        IEnumerable<ClientModel> IClientRepository.GetAll()
        {
            return LoadFromMemory.LoadClient();
        }

        void IClientRepository.Insert(ClientModel client)
        {
            Insert(client);
        }
        void IClientRepository.Update(ClientModel client)
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
