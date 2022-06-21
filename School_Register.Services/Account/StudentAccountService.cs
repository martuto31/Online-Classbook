using School_Register.Data.Models;
using School_Register.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Register.Services.Account
{
    public class StudentAccountService : IStudentAccountService
    {
        private IRepository<StudentAccount> studentAccRepo;

        public StudentAccountService(IRepository<StudentAccount> studentAccRepo)
        {
            this.studentAccRepo = studentAccRepo;
        }

        public bool CheckIfAccountExists(string username)
        {
            return this.studentAccRepo.All()
                .Any(a => a.Username == username);
        }
    }
}
