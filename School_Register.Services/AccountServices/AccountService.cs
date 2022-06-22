using School_Register.Data.Models;
using School_Register.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Register.Services.AccountServices
{
    public class AccountService : IAccountService
    {
        private IRepository<Account> accRepo;

        public AccountService(IRepository<Account> accRepo)
        {
            this.accRepo = accRepo;
        }

        public bool CheckIfAccountExists(string username)
        {
            return this.accRepo.All()
                .Any(a => a.Username == username);
        }

        public Account GetAccount(string username)
        {
            return this.accRepo.All()
                .FirstOrDefault(a => a.Username == username);
        }

        public bool isPasswordCorrect(string username, string password)
        {
            var acc = this.GetAccount(username);

            if (acc.Password == password)
                return true;
            else
                return false;
        }
    }
}
