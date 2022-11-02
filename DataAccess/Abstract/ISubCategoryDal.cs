using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ISubCategoryDal : IRepositoryBase<SubCategory>
    {
        void AddSubCategoryWithCategories(SubCategory subCategory, List<int> categoryIds);
    }
}
