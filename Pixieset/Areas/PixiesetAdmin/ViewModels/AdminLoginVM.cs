using System.ComponentModel.DataAnnotations;

namespace Pixieset.Areas.PixiesetAdmin.ViewModels
{
    public class AdminLoginVM
    {
        [Required, StringLength(maximumLength: 15)]
        public string Username { get; set; }
        [Required, StringLength(maximumLength: 15)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
