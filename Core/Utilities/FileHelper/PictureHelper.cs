using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.FileHelper
{
    public static class PictureHelper
    {
        public static string UploadPicture( this IFormFile file, string webRootPath)
        {
            var path = "/uploads/" + Guid.NewGuid().ToString() + file.FileName;
            using (var fileStream = new FileStream(webRootPath + path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            return path;
        }
    }
}
