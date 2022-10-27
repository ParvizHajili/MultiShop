using Business.Abstract;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class ProductPictureManager : IProductPictureService
    {
        private readonly IProductPictureDal _productPictureDal;

        public ProductPictureManager(IProductPictureDal productPictureDal)
        {
            _productPictureDal = productPictureDal;
        }
    }
}
