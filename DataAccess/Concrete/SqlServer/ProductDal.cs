using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.SqlServer
{
    public class ProductDal : EfRepositoryBase<Product, AppDbContext>, IProductDal
    {
        public List<Product> GetPopularProducts()
        {
            using AppDbContext context = new();
            var products = context.Products.Include(x => x.ProductPictures).ThenInclude(x => x.Picture).OrderByDescending(x => x.Hit).Take(8).ToList();

            return products;
        }

        public List<Product> GetRecentProducts()
        {
            using AppDbContext context = new();
            return context.Products.Include(x => x.ProductPictures).ThenInclude(x => x.Picture).OrderByDescending(x => x.Id).ToList();
        }
    }
}
