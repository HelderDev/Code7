using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChip.Domain.Database;
using WeChip.Services.Interface;

namespace WeChip.Services.Concrete
{
    public class StatusService : IStatusService
    {
        Domain.Models.StatusModel IStatusService.Get(byte statusCode)
        {
            return LoadDump.LoadStatus().FirstOrDefault(s => s.StatusCode == statusCode);
        }
        IEnumerable<Domain.Models.StatusModel> IStatusService.GetAll()
        {
            return LoadDump.LoadStatus();
        }
    }
}
