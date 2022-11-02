using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISubCategoryService
    {
        void AddSubCategory(SubCategory subCategory, List<int> categoryIds);
        void DeleteSubCategory(SubCategory subCategory);
        void UpdateSubCategory(SubCategory subCategory);
        SubCategory GetSubCategoryById(int id);
        List<SubCategory> GetAllSubCategories();
        List<SubCategory> GetActiveSubCategories();
    }
}
