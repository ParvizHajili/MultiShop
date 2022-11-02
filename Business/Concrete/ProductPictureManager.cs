using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductPictureManager : IProductPictureService
    {
        private readonly IProductPictureDal _productPictureDal;

        public ProductPictureManager(IProductPictureDal productPictureDal)
        {
            _productPictureDal = productPictureDal;
        }

        public void AddProductPicture(ProductPicture productPicture)
        {
            _productPictureDal.Add(productPicture);
        }
    }
}
