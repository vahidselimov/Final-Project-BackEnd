using Microsoft.AspNetCore.Identity;

namespace Pixieset.ViewModels
{
    public class ManageUserRole
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool Selected { get; set; }
        public RoleManager<RegisterVM> RoleManager { get; set; }

    }
}
