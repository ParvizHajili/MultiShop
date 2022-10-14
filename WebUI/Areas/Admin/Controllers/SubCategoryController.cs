using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        public IActionResult Index()
        {
            var result = _subCategoryService.GetActiveSubCategories();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SubCategory subcategory)
        {
            _subCategoryService.AddSubCategory(subcategory);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = _subCategoryService.GetSubCategoryById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Update(SubCategory subCategory)
        {
            _subCategoryService.UpdateSubCategory(subCategory);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var subCategory = _subCategoryService.GetSubCategoryById(id);
            return View(subCategory);
        }

        [HttpPost]
        public IActionResult Delete(SubCategory subCategory)
        {
            var subCategoryId = _subCategoryService.GetSubCategoryById(subCategory.Id);
            subCategoryId.IsDeleted = true;
            _subCategoryService.UpdateSubCategory(subCategoryId);
            return RedirectToAction(nameof(Index));
        }
    }
}
