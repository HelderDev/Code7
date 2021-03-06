using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChip.DomainModel.Enums;

namespace WeChip.DomainModel.Models
{
    public class StatusModel
    {
        public string Description { get; set; }
        public bool TerminateClient { get; set; }
        public bool AccountSale { get; set; }
        public StatusEnum StatusCode { get; set; }
    }

}
