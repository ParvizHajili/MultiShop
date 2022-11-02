using Entities.Concrete;

namespace WebUI.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> PopularProducts { get; set; }
        public List<Product> RecentProducts { get; set; }
    }
}
