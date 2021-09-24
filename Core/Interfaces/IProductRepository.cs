using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
         Task<Product> GetProductByIdAsync(int id);
         Task<IReadOnlyList<Product>> GetProducts();
         Task<IReadOnlyList<ProductBrand>> GetProductBrandAsync();
         Task<IReadOnlyList<ProductType>> GetProductTypeAsync();
    }
}