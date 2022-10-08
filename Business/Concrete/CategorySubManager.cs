using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategorySubManager : ICategorySubService
    {
        private readonly ICategorySubDal _categorySubDal;

        public CategorySubManager(ICategorySubDal categorySubDal)
        {
            _categorySubDal = categorySubDal;
        }

        public void AddCategorySub(CategorySub category)
        {
            _categorySubDal.Add(category);
        }

        public void DeleteCategorySub(CategorySub category)
        {
            _categorySubDal.Delete(category);
        }

        public List<CategorySub> GetActiveCategorySubs()
        {
            return _categorySubDal.GetAll(x => x.IsDeleted == false);
        }

        public List<CategorySub> GetAllCategorySubs()
        {
            return _categorySubDal.GetAll();
        }

        public CategorySub GetCategorySubById(int id)
        {
            return _categorySubDal.Get(x => x.Id == id);
        }

        public void UpdateCategorySub(CategorySub category)
        {
            _categorySubDal.Update(category);
        }
    }
}
