using System.Collections.Generic;
using WeChip.DomainModel.Models;

namespace WeChip.Domain.Database
{
    public static class LoadFromMemory
    {
        private static List<ClientModel> ClientList { get; set; }
        public static void Insert(ClientModel client)
        {
            if (ClientList == null)
                ClientList = new List<ClientModel>();

            ClientList.Add(client);
        }
        public static IEnumerable<ClientModel> LoadClient()
        {
            return ClientList;
        }
        public static void RemoveClient(ClientModel client)
        {
            ClientList.Remove(client);
        }
    }
}

