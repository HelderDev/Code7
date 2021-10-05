using System;
using System.Collections.Generic;
using System.Text;

namespace WeChip.ViewModel.ViewModels
{
    public class StatusViewModel
    {
        public string Description { get; set; }
        public bool TerminateClient { get; set; }
        public bool AccountSale { get; set; }
        public short StatusCode { get; set; }
    }
}
