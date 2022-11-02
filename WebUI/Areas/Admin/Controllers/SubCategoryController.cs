using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;
        public SubCategoryController(ISubCategoryService subCategoryService, ICategoryService categoryService)
        {
            _subCategoryService = subCategoryService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categories = _categoryService.GetAllCategories();

            return View(categories);
        }

        [HttpPost]
        public IActionResult Create(SubCategory subCategory, List<int> categoryIds)
        {
            _subCategoryService.AddSubCategory(subCategory, categoryIds);

            return RedirectToAction("Index");
        }
    }
}
