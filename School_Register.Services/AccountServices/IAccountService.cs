using System;
using System.Collections.Generic;
using System.Text;

namespace School_Register.Services.AccountServices
{
    public interface IAccountService
    {
        public bool CheckIfAccountExists(string username);
    }
}
