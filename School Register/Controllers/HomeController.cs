using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School_Register.Data.Models;
using School_Register.Data.Repositories;
using School_Register.Services.Account;
using School_Register.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Register.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<StudentAccount> studentAccRepo;
        private readonly IRepository<TeacherAccount> teacherAccRepo;
        private readonly IStudentAccountService studentAccService;
        private readonly ITeacherAccountService teacherAccountService;

        public HomeController(
            IRepository<StudentAccount> studentAccRepo,
            IRepository<TeacherAccount> teacherAccRepo,
            IStudentAccountService studentAccService,
            ITeacherAccountService teacherAccountService
            )
        {
            this.studentAccRepo = studentAccRepo;
            this.teacherAccRepo = teacherAccRepo;
            this.studentAccService = studentAccService;
            this.teacherAccountService = teacherAccountService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            var model = new AccountViewModel();
            return this.View(model);
        }

        //public async Task<IActionResult> LoginAsync()
        //{

        //}

        //public IActionResult Register()
        //{
        //    var model = new AccountViewModel();
        //    return this.View(model);
        //}

        public async Task<IActionResult> RegisterAsync(AccountViewModel acc)
        {
            if(acc.AccountType == AccountType.Student)
            {
                if(!this.studentAccService.CheckIfAccountExists(acc.Username))
                {
                    var newAcc = new StudentAccount()
                    {
                        Username = acc.Username,
                        Password = acc.Password,
                        ConfirmPassword = acc.ConfirmPassword,
                        ClassNumber = acc.ClassNumber,
                        Email = acc.Email,
                        FirstName = acc.FirstName,
                        LastName = acc.LastName,
                        Grade = acc.Grade,
                        StudentNumber = acc.StudentNumber,
                    };

                    await this.studentAccRepo.AddAsync(newAcc);
                    await this.studentAccRepo.SaveChangesAsync();
                    this.HttpContext.Session.SetString("username", newAcc.Username);
                    return this.RedirectToAction("Index", "Home");
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, "Потребителското име вече е заето");

                    return this.View();
                }
            }
            else if (acc.AccountType == AccountType.Teacher)
            {
                if(!this.teacherAccountService.CheckIfAccountExists(acc.Username))
                {
                    var newAcc = new TeacherAccount()
                    {
                        Username = acc.Username,
                        Password = acc.Password,
                        ConfirmPassword = acc.ConfirmPassword,
                        Email = acc.Email,
                        FirstName = acc.FirstName,
                        LastName = acc.LastName,
                    };

                    await this.teacherAccRepo.AddAsync(newAcc);
                    await this.teacherAccRepo.SaveChangesAsync();
                    this.HttpContext.Session.SetString("username", newAcc.Username);
                    return this.RedirectToAction("Index", "Home");
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, "Потребителското име вече е заето");

                    return this.View();
                }
            }
            return this.View();
        }
    }
}
