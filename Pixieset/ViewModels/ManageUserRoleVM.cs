using Microsoft.AspNetCore.Identity;

namespace Pixieset.ViewModels
{
    public class ManageUserRoleVM
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool Selected { get; set; }
       

    }
}
