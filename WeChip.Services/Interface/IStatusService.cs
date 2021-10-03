using System;
using System.Collections.Generic;
using System.Text;
using WeChip.Domain.Models;

namespace WeChip.Services.Interface
{
   public interface IStatusService
    {
        IEnumerable<StatusModel> GetAll();
        StatusModel Get(byte statusCode);

    }
}
