using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISubCategoryService
    {
        void AddSubCategory(SubCategory subCategory);
        void DeleteSubCategory(SubCategory subCategory);
        void UpdateSubCategory(SubCategory subCategory);
        SubCategory GetSubCategoryById(int id);
        List<SubCategory> GetAllSubCategories();
        List<SubCategory> GetActiveSubCategories();
    }
}
