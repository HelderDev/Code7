using WeChip.Domain.Enums;
namespace WeChip.Domain.Models
{
    public class ProductModel
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public TypeEnum Type { get; set; }
        public int ProductCode { get; set; }
    }
}
