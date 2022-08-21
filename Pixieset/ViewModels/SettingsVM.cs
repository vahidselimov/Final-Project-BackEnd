using System.ComponentModel.DataAnnotations;

namespace Pixieset.ViewModels
{
    public class SettingsVM
    {
       public string Id { get; set; }
        
        [Required, StringLength(maximumLength: 15)]
       
        public string LastName { get; set; }
        [Required, StringLength(maximumLength: 15)]
        public string UserName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
    }
}
