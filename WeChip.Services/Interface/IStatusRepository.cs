using System;
using System.Collections.Generic;
using System.Text;
using WeChip.Domain.Models;

namespace WeChip.Repository.Interface
{
   public interface IStatusRepository
    {
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
        StatusModel Get(byte statusCode);

    }
}
