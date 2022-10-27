using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.SqlServer
{
    public class PictureDal : EfRepositoryBase<Picture, AppDbContext>, IPictureDal
    {
        public Picture AddPictures(Picture picture)
        {
            using (var context = new AppDbContext())
            {
                context.Pictures.Add(picture);
                context.SaveChanges();
            }
            return picture;
        }
    }
}
