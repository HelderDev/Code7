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

        /// <summary>
        /// Cria uma carga genérica para teste
        /// </summary>
        /// <returns></returns>
        public static List<ClientModel> LoadClientDump()
        {
            if (ClientList == null)
                ClientList = new List<ClientModel>();
            ClientList.AddRange
                (
                new List<ClientModel>()
                {
                    new ClientModel()
                    {
                        CPF = "099.554.570-74",
                        Credit = 0.50m,
                        Name = "CLIENTE SEM CRÉDITO",
                        Phone = "(11) 94002-8922",
                        Status = new StatusModel()
                        {
                            AccountSale = false,
                            Description = "Nome Livre",
                            StatusCode = DomainModel.Enums.StatusEnum.FreeName,
                            TerminateClient = false
                        }
                    },
                    new ClientModel{
                        CPF = "068.620.510-32",
                        Credit = 50000.99m,
                        Name = "CLIENTE FULL",
                        Phone = "(21) 94123-4567",
                        DeliveryClientAddress = new DeliveryClientAddressModel(){
                            CEP = "1234578",
                            City = "Itú",
                            Complement = "Em frente ao mercado",
                            Neighbourhood = "Jardim das Luzes",
                            NumberAddress = 3332,
                            State = "SP",
                            Street = "Malfredo Alves"
                        },
                        Status = new StatusModel()
                        {
                            AccountSale = false,
                            Description = "Nome Livre",
                            StatusCode = DomainModel.Enums.StatusEnum.FreeName,
                            TerminateClient = false
                        }
                    },
                    new ClientModel{
                        CPF = "751.093.050-21",
                        Credit = 500.0m,
                        Name = "CLIENTE HARDWARE",
                        Phone = "(21) 94123-4567",
                        Status = new StatusModel()
                        {
                            AccountSale = false,
                            Description = "Nome Livre",
                            StatusCode = DomainModel.Enums.StatusEnum.FreeName,
                            TerminateClient = false
                        }
                    }
                });

            return ClientList;
        }
    }
}

