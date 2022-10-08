using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Concrete
{
    public class User : IdentityUser, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoUrl { get; set; }
    }
}
