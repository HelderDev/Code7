using System;
using System.Collections.Generic;
using System.Text;
using WeChip.Domain.Models;

namespace WeChip.Services.Interface
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetAllSelected(int[] productCodes);

        ProductModel Get(int productCode);
    }
}
