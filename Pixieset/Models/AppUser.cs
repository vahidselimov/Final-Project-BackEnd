﻿using Microsoft.AspNetCore.Identity;

namespace Pixieset.Models
{
    public class AppUser:IdentityUser
    {
         public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool TermsAndContensions { get; set; }
    }
}