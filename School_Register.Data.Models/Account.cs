using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School_Register.Data.Models
{
    public class Account : BaseAccount
    {
        public ICollection<Mark> Marks { get; set; }

        public int Grade { get; set; }

        [Display(Name = "Class number")]
        public int ClassNumber { get; set; }

        [Display(Name = "Student number")]
        public int StudentNumber { get; set; }

        [Required(ErrorMessage = "Please fill in all the required fields.")]
        [Display(Name = "Account type")]
        public AccountType AccountType { get; set; }
    }
}
