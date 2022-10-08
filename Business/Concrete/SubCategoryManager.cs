﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        private readonly ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public void AddSubCategory(SubCategory subCategory)
        {
            _subCategoryDal.Add(subCategory);
        }

        public void DeleteSubCategory(SubCategory subCategory)
        {
            _subCategoryDal.Delete(subCategory);
        }

        public List<SubCategory> GetActiveSubCategories()
        {
            return _subCategoryDal.GetAll(x => x.IsDeleted == false);
        }

        public List<SubCategory> GetAllSubCategories()
        {
            return _subCategoryDal.GetAll();
        }

        public SubCategory GetSubCategoryById(int id)
        {
            return _subCategoryDal.Get(x => x.Id == id);
        }

        public void UpdateSubCategory(SubCategory subCategory)
        {
            _subCategoryDal.Update(subCategory);
        }
    }
}
