using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategorySubService
    {
        void AddCategorySub(CategorySub category);
        void DeleteCategorySub(CategorySub category);
        void UpdateCategorySub(CategorySub category);
        CategorySub GetCategorySubById(int id);
        List<CategorySub> GetAllCategorySubs();
        List<CategorySub> GetActiveCategorySubs();
    }
}
