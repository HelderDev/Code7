using System.Collections.Generic;
using WeChip.DomainModel.Enums;
using WeChip.DomainModel.Models;

namespace WeChip.Repository.Interface
{
    public interface IStatusRepository
    {
        /// <summary>
        /// Retorna todos os Status, exceto FreeName - 0001
        /// </summary>
        /// <returns></returns>
        IEnumerable<StatusModel> GetAllAvailable();

        /// <summary>
        /// Retorna todos os Status disponíveis
        /// </summary>
        /// <returns></returns>
        IEnumerable<StatusModel> GetAll();
        /// <summary>
        /// Retorna um Status específico
        /// </summary>
        /// <param name="statusCode">Código do Status a retornar</param>
        /// <returns></returns>
        StatusModel Get(StatusEnum statusCode);

    }
}
