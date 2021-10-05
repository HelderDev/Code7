using System.Collections.Generic;
using System.Linq;
using WeChip.DomainModel.Models;

namespace WeChip.Domain.Database
{
    public static class LoadFromMemory
    {
        private static List<ClientModel> ClientList { get; set; }

        /// <summary>
        /// Insere o cliente na base de dados
        /// </summary>
        /// <param name="client">Objeto Domain do cliente</param>
        public static void Insert(ClientModel client)
        {
            try
            {
                if (ClientList == null)
                    ClientList = new List<ClientModel>();

                //Verifica se existe o cliente cadastrado na base
                if (ClientList.Select(c => c.CPF.Contains(client.CPF)).FirstOrDefault())
                    throw new System.Exception("Esse CPF já está cadastrado na base");

                ClientList.Add(client);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
         
        }
        /// <summary>
        /// Carrega todos os clientes da base
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ClientModel> LoadClient()
        {
            return ClientList;
        }
        /// <summary>
        /// Remove um cliente da base
        /// </summary>
        /// <param name="client"></param>
        public static void RemoveClient(ClientModel client)
        {
            ClientList.Remove(client);
        }
    }
}

