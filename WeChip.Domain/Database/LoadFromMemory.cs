using System;
using System.Collections.Generic;
using System.Text;
using WeChip.Domain.Models;

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
        public static IEnumerable<ClientModel> LoadClient() {
            return ClientList;
        }

    }
}

