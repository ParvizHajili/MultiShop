using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetActiveCategories();

            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _categoryService.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            _categoryService.UpdateCategory(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            var categoryId = _categoryService.GetCategoryById(category.Id);
            categoryId.IsDeleted = true;
            _categoryService.UpdateCategory(categoryId);
            return RedirectToAction(nameof(Index));
        }
    }
}
