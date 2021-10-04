using System.Collections.Generic;
using WeChip.DomainModel.Models;

namespace WeChip.Repository.Interface
{
    public interface IProductRepository
    {
        /// <summary>
        /// Retorna todos os Produtos da base
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductModel> GetAll();
        /// <summary>
        /// Retorna todos os Produtos da base que foram selecionados na tela LinkOfferClient.cshtml
        /// </summary>
        /// <param name="productCodes">Código de produtos selecionados</param>
        /// <returns></returns>
        IEnumerable<ProductModel> GetAllSelected(int[] productCodes);

        /// <summary>
        /// Busca um Produto pelo seu código
        /// </summary>
        /// <param name="productCode">Código do Produto</param>
        /// <returns></returns>
        ProductModel Get(int productCode);
    }
}
