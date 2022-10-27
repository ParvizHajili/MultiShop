using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace Business.Abstract
{
    public interface IPictureService
    {
        List<Picture> AddPicture(List<IFormFile> Picture, string webrootpath);
    }
}
