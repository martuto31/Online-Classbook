using System;
using System.Collections.Generic;
using System.Text;

namespace School_Register.Services.Account
{
    public interface IStudentAccountService
    {
        public bool CheckIfAccountExists(string username);
    }
}
