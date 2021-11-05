using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="Username required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Password must be between 5 and 15 characters")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Username must be between 6 and 20 characters")]

        public string Password { get; set; }
        [EmailAddress(ErrorMessage = "Email must be valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please confirm your password")]
        [Compare("Password", ErrorMessage = "Password must match")]
        public string VerifyPassword { get; set; }

    }
}
