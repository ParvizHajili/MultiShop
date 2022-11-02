
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        void AddProduct(Product product);
        List<Product> GetAllRecentProducts();
        List<Product> GetAllPopularProducts();
    }
}
