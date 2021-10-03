using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChip.Domain.Database;
using WeChip.Services.Interface;

namespace WeChip.Services.Concrete
{
    public class Product : IProductService
    {
        Domain.Models.ProductModel IProductService.Get(byte productCode)
        {
            return LoadDump.LoadProduct().FirstOrDefault(p => p.ProductCode == productCode);
        }

        IEnumerable<Domain.Models.ProductModel> IProductService.GetAll()
        {
            return LoadDump.LoadProduct();
        }
    }
}
