using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School_Register.Data.Models
{
    public abstract class BaseAccount
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fill in all the required fields.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please fill in all the required fields.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please fill in all the required fields.")]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword{ get; set; }

        [Required(ErrorMessage = "Please fill in all the required fields.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please fill in all the required fields.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please fill in all the required fields.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
    }
}
