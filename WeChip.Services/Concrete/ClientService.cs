﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChip.Domain.Database;
using WeChip.Services.Interface;

namespace WeChip.Services.Concrete
{
    public class ClientService : IClientService
    {
        Domain.Models.ClientModel IClientService.Get(string CPF)
        {
            return LoadFromMemory.LoadClient().FirstOrDefault(c=>c.CPF == CPF);
        }

        IEnumerable<Domain.Models.ClientModel> IClientService.GetAll()
        {
            return LoadFromMemory.LoadClient();
        }

        void IClientService.Insert(Domain.Models.ClientModel client)
        {
            LoadFromMemory.Insert(client);
        }

        void IClientService.UpdateStatus(string CPF)
        {
            throw new NotImplementedException();
        }
    }
}
