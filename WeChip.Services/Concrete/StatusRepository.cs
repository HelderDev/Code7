using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChip.Domain.Database;
using WeChip.Repository.Interface;

namespace WeChip.Repository.Concrete
{
    public class StatusRepository : IStatusRepository
    {
        Domain.Models.StatusModel IStatusRepository.Get(byte statusCode)
        {
            return LoadDump.LoadStatus().FirstOrDefault(s => s.StatusCode == statusCode);
        }
        IEnumerable<Domain.Models.StatusModel> IStatusRepository.GetAll()
        {
            return LoadDump.LoadStatus();
        }
    }
}
