using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.SqlServer
{
    public class CategorySubDal : EfRepositoryBase<CategorySub, AppDbContext>, ICategorySubDal
    {
    }
}
