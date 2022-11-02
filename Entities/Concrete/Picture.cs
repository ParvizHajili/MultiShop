using Core.Entities;

namespace Entities.Concrete
{
    public class Picture : IEntity
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public List<ProductPicture> ProductPictures { get; set; }
    }
}
