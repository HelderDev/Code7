using System;
using System.Collections.Generic;
using System.Text;

namespace WeChip.Model.ViewModels
{
    public class ProductViewModel
    {
        public string Description { get; set; }
        public string Price { get; set; }
        public string Type { get; set; }
        public string ProductCode { get; set; }
        public bool IsSelected { get; set; }
    }
}
