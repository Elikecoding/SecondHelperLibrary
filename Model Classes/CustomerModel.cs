using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ModelClasses
{
    //Create a model with some properties tha can be use for customer sign ups
    [DebuggerDisplay("{email}")]
    public class CustomerModel
    {

        public int Id { get; set; }

        [Display(Name="Customer Id")]
        [Required(ErrorMessage = "You must have a customer Id")]
        [Range(1,100000, ErrorMessage = "You need to enter a valid customer Id ")]
        public int customer_Id { get; set; }

        
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Please provide a first name")]
        public string first_name { get; set; }

        
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please provide a last name")]
        public string last_name { get; set; }

        
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please provide an email address")]
        public string email { get; set; }
        
        
        [Display(Name = "Confirm email")]
        [Compare("email", ErrorMessage ="Email Address must matach")]
        public string confirm_email { get; set; }

        [Display(Name = "Mobile")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Phone number must be the correct length")]
        public string phone { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password must be provided")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password needs to be between 8-1oo characters")]
        public string password { get; set; }


        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Passwords must match")]
        public string confirm_password { get; set; }

    }
}
