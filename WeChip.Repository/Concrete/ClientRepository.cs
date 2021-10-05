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
            try
            {
                Insert(client);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
        void IClientRepository.Update(ClientModel client)
        {
            try
            {
                var cli = Get(client.CPF);
                Delete(cli);
                Insert(client);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
        private ClientModel Get(string CPF)
        {
            return LoadFromMemory.LoadClient() != null && LoadFromMemory.LoadClient().Any() ?
             LoadFromMemory.LoadClient().FirstOrDefault(c => c.CPF == CPF) : null;
        }
        private void Delete(ClientModel client)
        {
            LoadFromMemory.RemoveClient(client);
        }
        private void Insert(ClientModel client)
        {
            try
            {
                LoadFromMemory.Insert(client);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        IEnumerable<ClientModel> IClientRepository.GetAllAvailable()
        {
            return LoadFromMemory.LoadClient() != null && LoadFromMemory.LoadClient().Any() ?
                LoadFromMemory.LoadClient().Where(s => !s.Status.TerminateClient) : null;
        }
    }
}
