using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ModelClasses
{
    //Create a model with some properties tha can be use for customer sign ups
    public class CustomerModel
    {
        [Display(Name ="customer Id")]
        [Range(1, 100, ErrorMessage = "You need to enter a valid customer Id ")]
        public int customerId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Please provide a first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please provide a last name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please provide an email address")]
        public string Email { get; set; }
        
        [Display(Name = "Confirm email")]
        [Compare("Email", ErrorMessage ="Email Address must matach")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password must be provided")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password needs to be between 8-1oo characters")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords must match")]
        public string ConfirmPassword { get; set; }
    }
}
