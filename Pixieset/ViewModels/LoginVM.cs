using System.ComponentModel.DataAnnotations;

namespace Pixieset.ViewModels
{
    public class LoginVM
    {
        [Required,StringLength(maximumLength:15,MinimumLength =3)]

        public string UserName { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool RememberMe { get; set; }
    }


}
