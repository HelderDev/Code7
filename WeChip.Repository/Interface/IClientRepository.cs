using System.Collections.Generic;
using WeChip.DomainModel.Models;

namespace WeChip.Repository.Interface
{
    public interface IClientRepository
    {
        /// <summary>
        /// Insere um novo cliente na base de dados
        /// </summary>
        /// <param name="client">Objeto cliente</param>
        void Insert(ClientModel client);
        /// <summary>
        /// Busca um cliente da base
        /// </summary>
        /// <param name="CPF">Busca o cliente pelo seu CPF</param>
        /// <returns></returns>
        ClientModel Get(string CPF);

        /// <summary>
        /// Retorna todos os clientes da base
        /// </summary>
        /// <returns></returns>
        IEnumerable<ClientModel> GetAll();

        /// <summary>
        /// Retorna todos os clientes disponíveis
        /// </summary>
        /// <returns></returns>
        IEnumerable<ClientModel> GetAllAvailable();

        /// <summary>
        /// Atualiza um cliente na base
        /// </summary>
        /// <param name="client">Objeto cliente</param>
        void Update(ClientModel client);
    }
}
