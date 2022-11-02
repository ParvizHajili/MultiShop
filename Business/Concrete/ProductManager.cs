using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void AddProduct(Product product)
        {
            _productDal.Add(product);
        }

        public List<Product> GetAllPopularProducts()
        {
            return _productDal.GetPopularProducts();
        }

        public List<Product> GetAllRecentProducts()
        {
            return _productDal.GetRecentProducts();
        }
    }
}
