using Product_Apis.DTOs;
using Product_Apis.Models;

namespace Product_Apis.Repository
{
    public interface IProductRepository
    {
        public ProductDTO AddProduct(ProductDTO product);
        public List<ProductDTO> GetAllProducts();
        public ProductDTO GetProductById(int id);

    }
}
