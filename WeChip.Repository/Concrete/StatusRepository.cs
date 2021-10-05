using System.Collections.Generic;
using System.Linq;
using WeChip.Data.Database;
using WeChip.DomainModel.Enums;
using WeChip.DomainModel.Models;
using WeChip.Repository.Interface;

namespace WeChip.Repository.Concrete
{
    public class StatusRepository : IStatusRepository
    {
        StatusModel IStatusRepository.Get(StatusEnum statusCode)
        {
            return LoadDump.LoadStatus().FirstOrDefault(s => s.StatusCode == statusCode);
        }
        IEnumerable<StatusModel> IStatusRepository.GetAll()
        {
            return LoadDump.LoadStatus();
        }
    }
}
