using System;
using System.Collections.Generic;
using System.Linq;
using WeChip.Data.Database;
using WeChip.DomainModel.Models;
using WeChip.Repository.Interface;

namespace WeChip.Repository.Concrete
{
    public class ProductRepository : IProductRepository
    {
        ProductModel IProductRepository.Get(int productCode)
        {
            return LoadDump.LoadProduct().FirstOrDefault(p => p.ProductCode == productCode);
        }

        IEnumerable<ProductModel> IProductRepository.GetAll()
        {
            return LoadDump.LoadProduct();
        }

        IEnumerable<ProductModel> IProductRepository.GetAllSelected(int[] productCodes)
        {
            return LoadDump.LoadProduct().Where(p => productCodes.Contains(p.ProductCode));
        }
    }
}
