using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.SqlServer
{
    public class CategoryDal : EfRepositoryBase<Category, AppDbContext>, ICategoryDal
    {

    }
}
