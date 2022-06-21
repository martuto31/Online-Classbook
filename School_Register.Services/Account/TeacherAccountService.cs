using School_Register.Data.Models;
using School_Register.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Register.Services.Account
{
    public class TeacherAccountService : ITeacherAccountService
    {
        private readonly IRepository<TeacherAccount> teacherAccRepo;

        public TeacherAccountService(IRepository<TeacherAccount> teacherAccRepo)
        {
            this.teacherAccRepo = teacherAccRepo;
        }

        public bool CheckIfAccountExists(string username)
        {
            return this.teacherAccRepo.All()
                .Any(a => a.Username == username);
        }
    }
}
