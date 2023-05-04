using System.ComponentModel.DataAnnotations;

namespace HyperMart.Models
{
    public class LoginModel
    {   
        [StringLength(20, MinimumLength = 3, ErrorMessage = "You need to provide a long enough name.")]
        public string Name { get; set; }

        public string Email { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "You need to provide a long enough password.")]
        public string Password { get; set; }
    }
}