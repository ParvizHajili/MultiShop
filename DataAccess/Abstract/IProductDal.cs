using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal : IRepositoryBase<Product>
    {
        List<Product> GetRecentProducts();
        List<Product> GetPopularProducts();
    }
}
