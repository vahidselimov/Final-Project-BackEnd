using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pixieset.Models
{
    public class AppUser:IdentityUser
    {
         public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool TermsAndContensions { get; set; }
        public bool IsBlock { get; set; }
        public bool IsAdmin { get; set; }
    }
}
