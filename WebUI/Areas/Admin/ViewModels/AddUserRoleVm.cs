using Core.Entities.Concrete;

namespace WebUI.Areas.Admin.ViewModels
{
    public class AddUserRoleVm
    {
        public User User { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
