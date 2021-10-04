using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChip.Domain.Database;
using WeChip.Domain.Models;
using WeChip.Services.Interface;

namespace WeChip.Services.Concrete
{
    public class ProductService : IProductService
    {
        Domain.Models.ProductModel IProductService.Get(int productCode)
        {
            return LoadDump.LoadProduct().FirstOrDefault(p => p.ProductCode == productCode);
        }

        IEnumerable<Domain.Models.ProductModel> IProductService.GetAll()
        {
            return LoadDump.LoadProduct();
        }

        IEnumerable<ProductModel> IProductService.GetAllSelected(int[] productCodes)
        {
            return LoadDump.LoadProduct().Where(p => productCodes.Contains(p.ProductCode));
        }
    }
}
