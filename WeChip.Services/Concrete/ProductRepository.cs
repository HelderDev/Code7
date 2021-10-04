using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChip.Domain.Database;
using WeChip.Domain.Models;
using WeChip.Repository.Interface;

namespace WeChip.Repository.Concrete
{
    public class ProductRepository : IProductRepository
    {
        Domain.Models.ProductModel IProductRepository.Get(int productCode)
        {
            return LoadDump.LoadProduct().FirstOrDefault(p => p.ProductCode == productCode);
        }

        IEnumerable<Domain.Models.ProductModel> IProductRepository.GetAll()
        {
            return LoadDump.LoadProduct();
        }

        IEnumerable<ProductModel> IProductRepository.GetAllSelected(int[] productCodes)
        {
            return LoadDump.LoadProduct().Where(p => productCodes.Contains(p.ProductCode));
        }
    }
}
