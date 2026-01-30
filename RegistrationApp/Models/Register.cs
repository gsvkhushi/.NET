using System.ComponentModel.DataAnnotations;

namespace RegistrationApp.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-zA-Z ]+$",
           ErrorMessage = "Name must contain only alphabets")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression
            (@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$",
            ErrorMessage = "Password must be at least one uppercase letter, one lowercase letter, one digit, one special character and minimum length of 6")]
        [MinLengthAttribute(6, ErrorMessage = "password must be atleast 6 characters")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }
    }
}
