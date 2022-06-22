using School_Register.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Register.ViewModels
{
    public class AccountViewModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public int Grade { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ClassNumber { get; set; }

        public int StudentNumber { get; set; }

        public AccountType AccountType { get; set; }
    }
}
